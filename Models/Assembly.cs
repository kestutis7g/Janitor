using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;

namespace Janitor_V1.Models
{
    public class Assembly
    {
        //assemblingo properčiai
        [Category("General"),
        Description("Name of the component")]
        public string ComponentName { get; set; }

        [Category("General"),
        Description("Description of the component")]
        public string Description { get; set; }

        [Category("General"),
        Description("Notes")]
        public string Notes { get; set; }

        [Category("Other"),
        Description("Part reference configuration")]
        public string ReferencedConfiguration { get; set; }

        [Category("General"),
        Description("Component ID")]
        public int ComponentID { get; set; }

        [Category("Assembly duration"),
        Description("Assembly duration of all child nodes")]
        public double? ChildNodeAssemblyDuration { get; set; }

        [Category("Assembly duration"),
        Description("Assembly duration of individual component")]
        public double? IndividualComponentAssemblyDuration { get; set; }

        [Category("Assembly duration"),
        Description("Assembly duration into parent node")]
        public double? AssemblyToParentNodeDuration { get; set; }

        [Category("Assembly duration"),
        Description("Total assembly duration of this node")]
        public double? CombinedAssemblyTime { get; set; }
        
        [Category("Welding"),
        Description("Assembly welding duration")]
        public double? WeldingDuration { get; set; }
        
        [Category("Other cost"),
        Description("Assembly other cost")]
        public double? OtherCosts { get; set; }
        
        [Category("Other cost"),
        Description("Assembly other cost description")]
        public string OtherCostsDescription { get; set; }

        [Category("Other"),
        Description("Location of the file")]
        public string FileLocation { get; set; }

        [Category("Image"),
        Description("Image of the part")]
        public Image Image { get; set; }
        
        [Category("Image"),
        Description("Image file location")]
        public string ImageLocation { get; set; }
        
        public ModelDoc2 swModel { get; set; }
        public Component2 swComp { get; set; }

        public Assembly() 
        {
            this.ComponentID = 0;
            this.ChildNodeAssemblyDuration = 0;
            this.IndividualComponentAssemblyDuration = 0;
            this.AssemblyToParentNodeDuration = 0;
            this.CombinedAssemblyTime = 0;
            this.WeldingDuration = 0;
            this.OtherCosts = 0;
        }

        public string GetEncodedString()
        {
            var encoded = "";
            //welding
            encoded += "1x" + this.WeldingDuration.ToString() + "<&?&>";
            //assembly
            encoded += "2x" + this.ChildNodeAssemblyDuration.ToString() + "<&?&>";
            encoded += "3x" + this.IndividualComponentAssemblyDuration.ToString() + "<&?&>";
            encoded += "4x" + this.AssemblyToParentNodeDuration.ToString() + "<&?&>";
            encoded += "5x" + this.CombinedAssemblyTime.ToString() + "<&?&>";
            //other costs
            encoded += "6x" + this.OtherCosts.ToString() + "<&?&>";
            encoded += "7x" + this.OtherCostsDescription + "<&?&>";
            //general
            encoded += "8x" + this.ImageLocation + "<&?&>";
            encoded += "9x" + this.Description + "<&?&>";
            encoded += "10x" + this.Notes + "<&?&>";
            return encoded;
        }

        public bool WriteEncodedData(string encodedData)
        {
            string[] separators = new string[] { "<&?&>" };
            double tempDouble = 0;

            var data = encodedData.Split(separators, System.StringSplitOptions.None);

            if(data.Length < 10)
            {
                return false;
            }

            try
            {
                if (double.TryParse(DecodeValue(data[0]), out tempDouble))
                {
                    this.WeldingDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[1]), out tempDouble))
                {
                    this.ChildNodeAssemblyDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[2]), out tempDouble))
                {
                    this.IndividualComponentAssemblyDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[3]), out tempDouble))
                {
                    this.AssemblyToParentNodeDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[4]), out tempDouble))
                {
                    this.CombinedAssemblyTime = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[5]), out tempDouble))
                {
                    this.OtherCosts = tempDouble;
                }

                this.OtherCostsDescription = DecodeValue(data[6]);
                this.ImageLocation = DecodeValue(data[7]);
                this.Description = DecodeValue(data[8]);
                this.Notes = DecodeValue(data[9]);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
            return true;
        }

        private string DecodeValue(string data)
        {
            var result = data.Split(new char[] {'x'}, 2);
            if(result.Length != 2)
            {
                return "";
            }
            return result[1];
        }
    }
}
