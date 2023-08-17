using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Janitor_V1.Models
{
    internal class Prices
    {
        private List<Price> allData = new List<Price>();
        private List<Price> workPrices = new List<Price>();
        private List<Price> materialPrices = new List<Price>();

        //private OleDbConnection mdbConnection = new OleDbConnection(
        //    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\DB\\Database.mdb"));
        private OleDbConnection mdbConnection = new OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\OneDrive - UAB Novatronas\\DARBAI su SOLIDWORKS_V2019\\JANITOR\\Janitor_V1\\DB\\Database.mdb");

        public Prices() 
        {
            //create table in Access database if table is not present
            mdbConnection.Open();
            DataTable dTable = mdbConnection.GetSchema("TABLES", new string[] { null, null, "Prices" });

            if (dTable.Rows.Count == 0)
            {
                string query =
                @"CREATE TABLE Prices
                (
                    Id AUTOINCREMENT PRIMARY KEY,
                    Name TEXT(64) NOT NULL,
                    Data NUMBER NOT NULL,
                    GroupName TEXT(64) NOT NULL,
                    UpdatedAt DATETIME NOT NULL
                );";
                OleDbCommand command = new OleDbCommand(query, mdbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Details: " + e.ToString(), "Error creating table in database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            mdbConnection.Close();
        }

        /// <summary>
        /// Refresh price lists
        /// </summary>
        /// <returns>Result if refresh was successful</returns>
        public bool Refresh()
        {
            this.workPrices = new List<Price>();
            this.materialPrices = new List<Price>();

            mdbConnection.Open();
            string query =
                @"SELECT Id, Name, Data, GroupName, UpdatedAt FROM Prices;";
            OleDbCommand command = new OleDbCommand(query, mdbConnection);
            try
            {
                //var result = command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var price = new Price((int)reader[0],
                                          reader[1].ToString(),
                                          (double)reader[2],
                                          reader[3].ToString(),
                                          (DateTime)reader[4]);

                    this.allData.Add(price);

                    if (reader[3].ToString() == "Darbo")
                    {
                        this.workPrices.Add(price);
                    }
                    else if(reader[3].ToString() == "Žaliavų")
                    {
                        this.materialPrices.Add(price);
                    }
                }
                reader.Close();
                mdbConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Details: " + e.ToString(), "Database request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdbConnection.Close();
                return false;
            }
        }

        public List<Price> GetWorkPrices()
        {
            return this.workPrices;
        }
        public List<Price> GetMaterialPrices()
        {
            return this.materialPrices;
        }
        public List<Price> GetAllPrices()
        {
            return this.allData;
        }

        public Price GetById(int id)
        {
            mdbConnection.Open();
            string query =
                @"SELECT Id, Name, Data, GroupName, UpdatedAt FROM Prices WHERE Id = " + id + ";";
            OleDbCommand command = new OleDbCommand(query, mdbConnection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                Price price = null;
                if(reader.Read())
                {
                    price = new Price((int)reader[0],
                                          reader[1].ToString(),
                                          (double)reader[2],
                                          reader[3].ToString(),
                                          (DateTime)reader[4]);
                }
                reader.Close();
                mdbConnection.Close();
                return price;
            }
            catch (Exception e)
            {
                MessageBox.Show("Details: " + e.ToString(), "Database request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdbConnection.Close();
                return null;
            }
        }

        public void Add(Price price)
        {
            string query = "INSERT INTO Prices (Name, Data, GroupName, UpdatedAt) VALUES (@Name,@Data,@GroupName,@UpdatedAt)";
            mdbConnection.Open();
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, mdbConnection))
                {
                    command.Parameters.AddWithValue("@Name", price.Name);
                    command.Parameters.AddWithValue("@Data", price.Value);
                    command.Parameters.AddWithValue("@GroupName", price.Group);
                    command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now.ToString());
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Details: " + exception.ToString(), "Error adding data into database. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mdbConnection.Close();
        }

        public void Update(int id, Price price)
        {
            string query = "UPDATE Prices SET Name = @Name, Data = @Data, GroupName = @GroupName, UpdatedAt = @UpdatedAt WHERE Id=@Id";
            mdbConnection.Open();
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, mdbConnection))
                {
                    command.Parameters.AddWithValue("@Name", price.Name);
                    command.Parameters.AddWithValue("@Data", price.Value);
                    command.Parameters.AddWithValue("@GroupName", price.Group);
                    command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Details: " + exception.ToString(), "Error adding data into database. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mdbConnection.Close();
        }
    }

    internal class Price
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Group { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Price(string name, double value, string group)
        {
            this.Name = name;
            this.Value = value;
            this.Group = group;
        }
        public Price(int id, string name, double value, string group, DateTime updatedAt) 
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
            this.Group = group;
            this.UpdatedAt = updatedAt;
        }
    }
}
