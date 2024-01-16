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
        //Šis modulis yra skirtas darbų ir medžiagų įkainių pasiėmimui iš duomenų bazės
        private OleDbConnection mdbConnection { get; set; }

        private List<Price> workPrices = new List<Price>();
        private List<Price> materialPrices = new List<Price>();
        private List<ProcessingPrice> processingPrices = new List<ProcessingPrice>();

        //private OleDbConnection mdbConnection = new OleDbConnection(
        //    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\OneDrive - UAB Novatronas\\DARBAI su SOLIDWORKS_V2019\\JANITOR\\Janitor_V1\\DB\\Database.mdb");

        public Prices(string workingDirectory)
        {
            //prisijungimas prie duomenų bazės
            this.mdbConnection = new OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(workingDirectory, "DB\\Database.mdb"));

            //create table in Access database if table is not present
            mdbConnection.Open();
            //patikrinama ar duomenų bazėje yra tokia lentėlė
            //tokiu atveju, jei ten nebūtų tokios lentelės, tuomet lentelė būtų sukurta ir pradedama pildyti
            DataTable workPricesTable = mdbConnection.GetSchema("TABLES", new string[] { null, null, "WorkPrices" });
            DataTable materialPricesTable = mdbConnection.GetSchema("TABLES", new string[] { null, null, "MaterialPrices" });
            DataTable processingTable = mdbConnection.GetSchema("TABLES", new string[] { null, null, "ProcessingPrices" });

            if (workPricesTable.Rows.Count == 0)
            {
                string query =
                @"CREATE TABLE WorkPrices
                (
                    Id AUTOINCREMENT PRIMARY KEY,
                    Name TEXT(64) NOT NULL,
                    Price NUMBER NOT NULL,
                    UpdatedAt DATETIME NOT NULL
                );";
                OleDbCommand command = new OleDbCommand(query, mdbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Details: " + e.ToString(), "Error creating 'WorkPrices' table in database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (materialPricesTable.Rows.Count == 0)
            {
                string query =
                @"CREATE TABLE MaterialPrices
                (
                    Id AUTOINCREMENT PRIMARY KEY,
                    Name TEXT(64) NOT NULL,
                    Price NUMBER NOT NULL,
                    UpdatedAt DATETIME NOT NULL
                );";
                OleDbCommand command = new OleDbCommand(query, mdbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Details: " + e.ToString(), "Error creating 'MaterialPrices' table in database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //sukuria processing kainų lentelę jei jos nėra
            if (processingTable.Rows.Count == 0)
            {
                string query =
                @"CREATE TABLE ProcessingPrices
                (
                    Id AUTOINCREMENT PRIMARY KEY,
                    Processing TEXT(64) NOT NULL,
                    Material TEXT(64) NOT NULL,
                    Type TEXT(64) NOT NULL,
                    Supplier TEXT(64) NOT NULL,
                    Property NUMBER NOT NULL,
                    Data NUMBER NOT NULL,
                    UpdatedAt DATETIME NOT NULL
                );";
                OleDbCommand command = new OleDbCommand(query, mdbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Details: " + e.ToString(), "Error creating 'ProcessingPrices' table in database", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //pasiima šviežiai duomenis iš duomenų bazės
            this.workPrices = new List<Price>();
            this.materialPrices = new List<Price>();
            this.processingPrices = new List<ProcessingPrice>();

            mdbConnection.Open();
            //WORK PRICES TABLE
            string query =
                @"SELECT Id, Name, Price, UpdatedAt FROM WorkPrices;";
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
                                          (DateTime)reader[3]);
                    this.workPrices.Add(price);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Details: " + e.ToString(), "Database request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdbConnection.Close();
                return false;
            }
            //MATERIAL PRICES TABLE
            query =
                @"SELECT Id, Name, Price, UpdatedAt FROM MaterialPrices;";
            command = new OleDbCommand(query, mdbConnection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var price = new Price((int)reader[0],
                                          reader[1].ToString(),
                                          (double)reader[2],
                                          (DateTime)reader[3]);
                    this.materialPrices.Add(price);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Details: " + e.ToString(), "Database request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdbConnection.Close();
                return false;
            }

            //PROCESSING PRICES TABLE
            query =
                @"SELECT Id, Processing, Material, Type, Supplier, Property, Data, UpdatedAt FROM ProcessingPrices;";
            command = new OleDbCommand(query, mdbConnection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var price = new ProcessingPrice((int)reader[0],
                                          reader[1].ToString(),
                                          reader[2].ToString(),
                                          reader[3].ToString(),
                                          reader[4].ToString(),
                                          (double)reader[5],
                                          (double)reader[6],
                                          (DateTime)reader[7]);

                    this.processingPrices.Add(price);
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

        //šis metodas gauna visus darbų įkainius
        public List<Price> GetWorkPrices()
        {
            return this.workPrices;
        }

        //šis metodas gauna visus žaliavų įkainius
        public List<Price> GetMaterialPrices()
        {
            return this.materialPrices;
        }

        //grazina processing kainas
        public List<ProcessingPrice> GetProcessingPrices()
        {
            return this.processingPrices;
        }

        public Price GetPriceById(int id, string tableName)
        {
            //iš duomenų bazės paima įkainį pagal ID
            mdbConnection.Open();
            string query =
                $@"SELECT Id, Name, Price, UpdatedAt FROM {tableName} WHERE Id = {id} ;";
            OleDbCommand command = new OleDbCommand(query, mdbConnection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                Price price = null;
                if(reader.Read())
                {
                    var test = reader[0];
                    price = new Price((int)reader[0],
                                          reader[1].ToString(),
                                          (double)reader[2],
                                          (DateTime)reader[3]);
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
        public Price GetPriceByName(string name, string tableName = "WorkPrices")
        {
            //iš duomenų bazės paima įkainį pagal pavadinima
            mdbConnection.Open();
            string query =
                $@"SELECT Id, Name, Price, UpdatedAt FROM {tableName} WHERE Name = '{name}';";
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
                                          (DateTime)reader[3]);
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

        public ProcessingPrice GetProcessingPriceByParams(string processing, string material, string type, string supplier, string property)
        {
            //iš duomenų bazės paima įkainį pagal ID
            mdbConnection.Open();
            string query =
                @"SELECT Processing, Material, Type, Supplier, Property, Data FROM ProcessingPrices 
                    WHERE Processing = '" + processing + "' " +
                    "   AND Type = '" + type + "' " +
                    "   AND Supplier = '" + supplier + "' " +
                    "   AND Property = " + property + " ";

            if(material != "" || material != "-")
            {
                query += " AND Material = '" + material + "';";
            }
            else
            {
                query += ";";
            }

            OleDbCommand command = new OleDbCommand(query, mdbConnection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                ProcessingPrice price = null;
                if (reader.Read())
                {
                    price = new ProcessingPrice(reader[0].ToString(),
                                                reader[1].ToString(),
                                                reader[2].ToString(),
                                                reader[3].ToString(),
                                                (double)reader[4],
                                                (double)reader[5]);
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

        public List<string> GetDistinctProcessingColumnValues(string column = "Processing")
        {
            List<string> result = new List<string>();

            mdbConnection.Open();
            string query =
                @"SELECT DISTINCT " + column + " FROM ProcessingPrices;";
            OleDbCommand command = new OleDbCommand(query, mdbConnection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader[0].ToString());
                }
                reader.Close();
                mdbConnection.Close();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show("Details: " + e.ToString(), "Database request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdbConnection.Close();
                return result;
            }
        }

        public List<ProcessingType> GetProcessingDistinctTypes(string processing, string material)
        {
            List<ProcessingType> result = new List<ProcessingType>();

            mdbConnection.Open();
            string query =
                @"SELECT DISTINCT Type, Supplier FROM ProcessingPrices 
                    WHERE Processing = '" + processing + "'";
            if(material != "" || material != "-")
            {
                query += " AND (Material = '" + material + "' OR Material = '-' OR Material = '');";
            }
            else
            {
                query += ";";
            }
            
            OleDbCommand command = new OleDbCommand(query, mdbConnection);
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new ProcessingType(reader[0].ToString(), reader[1].ToString()));
                }
                reader.Close();
                mdbConnection.Close();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show("Details: " + e.ToString(), "Database request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdbConnection.Close();
                return result;
            }
        }

        public void AddPrice(Price price, string tableName)
        {
            //prideda įkainį į duomenų bazę
            string query = $"INSERT INTO {tableName} (Name, Price, UpdatedAt) VALUES (@Name,@Price,@UpdatedAt)";
            mdbConnection.Open();
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, mdbConnection))
                {
                    command.Parameters.AddWithValue("@Name", price.Name);
                    command.Parameters.AddWithValue("@Price", price.Value);
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
        public void AddProcessing(ProcessingPrice price)
        {
            //prideda įkainį į duomenų bazę
            string query = "INSERT INTO ProcessingPrices (Processing, Material, Type, Supplier, Property, Data, UpdatedAt) " +
                "VALUES (@Processing, @Material, @Type, @Supplier, @Property, @Data, @UpdatedAt)";
            mdbConnection.Open();
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, mdbConnection))
                {
                    command.Parameters.AddWithValue("@Processing", price.Processing);
                    command.Parameters.AddWithValue("@Material", price.Material);
                    command.Parameters.AddWithValue("@Type", price.Type);
                    command.Parameters.AddWithValue("@Supplier", price.Supplier);
                    command.Parameters.AddWithValue("@Property", price.Property);
                    command.Parameters.AddWithValue("@Data", price.Value);
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

        public void UpdatePrice(int id, Price price, string tableName)
        {

            //įkainio atnaujinimas duomenų bazėje
            string query = $"UPDATE {tableName} SET Name = @Name, Price = @Price, UpdatedAt = @UpdatedAt WHERE Id=@Id";
            mdbConnection.Open();
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, mdbConnection))
                {
                    command.Parameters.AddWithValue("@Name", price.Name);
                    command.Parameters.AddWithValue("@Price", price.Value);
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
        public void UpdateProcessing(int id, ProcessingPrice price)
        {

            //processing ikainio atnaujinimas duomenų bazėje
            string query = @"UPDATE ProcessingPrices SET Processing = @Processing, Material = @Material, Type = @Type,
                                Supplier = @Supplier, Property = @Property, Data = @Data,UpdatedAt = @UpdatedAt WHERE Id=@Id";
            mdbConnection.Open();
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, mdbConnection))
                {
                    command.Parameters.AddWithValue("@Processing", price.Processing);
                    command.Parameters.AddWithValue("@Material", price.Material);
                    command.Parameters.AddWithValue("@Type", price.Type);
                    command.Parameters.AddWithValue("@Supplier", price.Supplier);
                    command.Parameters.AddWithValue("@Property", price.Property);
                    command.Parameters.AddWithValue("@Data", price.Value);
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
        //įkainio objektas, t.y. duomenų struktūra
        public int? Id { get; set; }
        public string Name { get; set; } //įkainio pavadinimas
        public double Value { get; set; }
        public DateTime UpdatedAt { get; set; } //laikas kada atnaujinta

        public Price(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
        public Price(int id, string name, double value, DateTime updatedAt) 
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
            this.UpdatedAt = updatedAt;
        }
    }
    internal class ProcessingPrice
    {
        //įkainio objektas, t.y. duomenų struktūra
        public int? Id { get; set; }
        public string Processing { get; set; } //apdirbimo
        public string Material { get; set; }
        public string Type { get; set; } //apdirbimo tipas
        public string Supplier { get; set; } //apdirbimo tiekejas
        public double Property { get; set; } //apdirbimo skardos storis
        public double Value { get; set; } //apdirbimo kaina
        public DateTime UpdatedAt { get; set; } //laikas kada atnaujinta

        public ProcessingPrice(string processing, string material, string type, string supplier, double property, double value)
        {
            this.Processing = processing;
            this.Material = material;
            this.Type = type;
            this.Supplier = supplier;
            this.Property = property;
            this.Value = value;
        }
        public ProcessingPrice(int id, string processing, string material, string type, string supplier, double property, double value, DateTime updatedAt) 
        {
            this.Id = id;
            this.Processing = processing;
            this.Material = material;
            this.Type = type;
            this.Supplier = supplier;
            this.Property = property;
            this.Value = value;
            this.UpdatedAt = updatedAt;
        }
    }

    internal class ProcessingType
    {
        public string Type { get; set; }
        public string Supplier { get; set; }

        public ProcessingType(string type, string supplier)
        {
            Type = type;
            Supplier = supplier;
        }

        public string FormatedString()
        {
            return string.Format("{0} | {1}", Type, Supplier);
        }
    }
}
