using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Janitor_V1.Models
{
    public class Device
    {
        //Viso įrenginio objektas su properčiais
        public ModelDoc2 swModel { get; set; }
        public string Configuration { get; set; }
        public string FileLocation { get; set; }


        public double TotalPrice { get; set; }
        public double TotalHours { get; set; }
        public int AmountOfDevices { get; set; }

        //design tabas
        
        public double PlannedDesigningDuration { get; set; }
        public double RealDesigningDuration { get; set; }
        public double DesigningCostWithoutVAT { get; set; }
        public double DesigningTotalPricePerUnit { get; set; }


        //welding tabas
        public double PlannedWeldingDuration { get; set; }
        public double RealWeldingDuration { get; set; }
        public double WeldingCostWithoutVAT { get; set; }
        public double WeldingTotalPrice { get; set; }
        
        //assembly tabas
        public double TotalWorkManagementDuration { get; set; }
        public double WorkManagementCost { get; set; }
        public double WorkManagementTotalCostPerUnit { get; set; }

        public double TotalSupplyDuration { get; set; }
        public double SupplyCost { get; set; }
        public double SupplyTotalCostPerUnit { get; set; }
        
        public double IndividualComponentsAssembly { get; set; }
        public double AssemblyToParentDuration { get; set; }
        public double ChildNodeAssemblyDuration { get; set; }
        public double TotalAssemblyDuration { get; set; }
        public double AssemblyCost { get; set; }
        public double AssemblyTotalCost { get; set; }
        
        public double TotalPackagingDuration { get; set; }
        public double PackingCost { get; set; }
        public double PackagingMaterialCost { get; set; }
        public double PackagingTotalCost { get; set; }
        //parts tabas
        public int NumberOfParts { get; set; }
        public double TotalPartsCost { get; set; }
        public double TotalToolboxWeight { get; set; }
        public double TotalToolboxCost { get; set; }
        public double TotalPartsAndToolboxCost { get; set; }
        //other costs tabas
        public double OtherCosts { get; set; }
        public string OtherCostsDescription { get; set; }

        public Device() 
        {
            //defaulto sukūrimas
            this.TotalPrice = 0;
            this.TotalHours = 0;
            this.AmountOfDevices = 1;

            this.PlannedDesigningDuration = 0;
            this.RealDesigningDuration = 0;
            this.DesigningCostWithoutVAT = 0;
            this.DesigningTotalPricePerUnit = 0;

            this.PlannedWeldingDuration = 0;
            this.RealWeldingDuration = 0;
            this.WeldingCostWithoutVAT = 0;
            this.WeldingTotalPrice = 0;
            
            this.TotalWorkManagementDuration = 0;
            this.WorkManagementCost = 0;
            this.WorkManagementTotalCostPerUnit = 0;

            this.TotalSupplyDuration = 0;
            this.SupplyCost = 0;
            this.SupplyTotalCostPerUnit = 0;

            this.IndividualComponentsAssembly = 0;
            this.AssemblyToParentDuration = 0;
            this.ChildNodeAssemblyDuration = 0;
            this.TotalAssemblyDuration = 0;
            this.AssemblyCost = 0;
            this.AssemblyTotalCost = 0;

            this.TotalPackagingDuration = 0;
            this.PackingCost = 0;
            this.PackagingMaterialCost = 0;
            this.PackagingTotalCost = 0;
            
            this.NumberOfParts = 0;
            this.TotalPartsCost = 0;
            this.TotalToolboxWeight = 0;
            this.TotalToolboxCost = 0;
            this.TotalPartsAndToolboxCost = 0;

            this.OtherCosts = 0;
        }

        public string GetEncodedString()
        {
            var encoded = "";
            //designing
            encoded += "1x" + this.PlannedDesigningDuration + "<&?&>";
            encoded += "2x" + this.DesigningCostWithoutVAT + "<&?&>";
            encoded += "3x" + this.DesigningTotalPricePerUnit + "<&?&>";
            //welding
            encoded += "4x" + this.PlannedWeldingDuration + "<&?&>";
            encoded += "5x" + this.WeldingCostWithoutVAT + "<&?&>";
            encoded += "6x" + this.WeldingTotalPrice + "<&?&>";

            //assembly and packaging
            encoded += "7x" + this.TotalWorkManagementDuration + "<&?&>";
            encoded += "8x" + this.WorkManagementCost + "<&?&>";
            encoded += "9x" + this.WorkManagementTotalCostPerUnit + "<&?&>";
            //-------------------------
            encoded += "10x" + this.TotalSupplyDuration + "<&?&>";
            encoded += "11x" + this.SupplyCost + "<&?&>";
            encoded += "12x" + this.SupplyTotalCostPerUnit + "<&?&>";
            //-------------------------
            encoded += "13x" + this.ChildNodeAssemblyDuration + "<&?&>";
            encoded += "14x" + this.IndividualComponentsAssembly + "<&?&>";
            encoded += "15x" + this.AssemblyToParentDuration + "<&?&>";
            encoded += "16x" + this.TotalAssemblyDuration + "<&?&>";
            encoded += "17x" + this.AssemblyCost + "<&?&>";
            encoded += "18x" + this.AssemblyTotalCost + "<&?&>";
            //-------------------------
            encoded += "19x" + this.TotalPackagingDuration + "<&?&>";
            encoded += "20x" + this.PackingCost + "<&?&>";
            encoded += "21x" + this.PackagingMaterialCost + "<&?&>";
            encoded += "22x" + this.PackagingTotalCost + "<&?&>";

            //parts tab
            encoded += "23x" + this.NumberOfParts + "<&?&>";
            encoded += "24x" + this.TotalPartsCost + "<&?&>";
            encoded += "25x" + this.TotalToolboxWeight + "<&?&>";
            encoded += "26x" + this.TotalToolboxCost + "<&?&>";
            encoded += "27x" + this.TotalPartsAndToolboxCost + "<&?&>";

            //other costs
            encoded += "28x" + this.OtherCosts + "<&?&>";
            encoded += "29x" + this.OtherCostsDescription + "<&?&>";

            //footer
            encoded += "30x" + this.AmountOfDevices + "<&?&>";
            encoded += "31x" + this.TotalPrice + "<&?&>";
            encoded += "32x" + this.TotalHours + "<&?&>";
            encoded += "33x" + DateTime.Now.ToString() + "<&?&>";

            return encoded;
        }

        public bool WriteEncodedData(string encodedData)
        {
            string[] separators = new string[] { "<&?&>" };
            double tempDouble = 0;
            int tempInt = 0;

            var data = encodedData.Split(separators, System.StringSplitOptions.None);

            if (data.Length < 33)
            {
                return false;
            }

            try
            {
                //designing
                if (double.TryParse(DecodeValue(data[0]), out tempDouble))
                {
                    this.PlannedDesigningDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[1]), out tempDouble))
                {
                    this.DesigningCostWithoutVAT = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[2]), out tempDouble))
                {
                    this.DesigningTotalPricePerUnit = tempDouble;
                }
                //welding
                if (double.TryParse(DecodeValue(data[3]), out tempDouble))
                {
                    this.PlannedWeldingDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[4]), out tempDouble))
                {
                    this.WeldingCostWithoutVAT = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[5]), out tempDouble))
                {
                    this.WeldingTotalPrice = tempDouble;
                }
                //assembly and packaging
                if (double.TryParse(DecodeValue(data[6]), out tempDouble))
                {
                    this.TotalWorkManagementDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[7]), out tempDouble))
                {
                    this.WorkManagementCost = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[8]), out tempDouble))
                {
                    this.WorkManagementTotalCostPerUnit = tempDouble;
                }
                //-------------------------
                if (double.TryParse(DecodeValue(data[9]), out tempDouble))
                {
                    this.TotalSupplyDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[10]), out tempDouble))
                {
                    this.SupplyCost = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[11]), out tempDouble))
                {
                    this.SupplyTotalCostPerUnit = tempDouble;
                }
                //-------------------------
                if (double.TryParse(DecodeValue(data[12]), out tempDouble))
                {
                    this.ChildNodeAssemblyDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[13]), out tempDouble))
                {
                    this.IndividualComponentsAssembly = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[14]), out tempDouble))
                {
                    this.AssemblyToParentDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[15]), out tempDouble))
                {
                    this.TotalAssemblyDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[16]), out tempDouble))
                {
                    this.AssemblyCost = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[17]), out tempDouble))
                {
                    this.AssemblyTotalCost = tempDouble;
                }
                //-------------------------
                if (double.TryParse(DecodeValue(data[18]), out tempDouble))
                {
                    this.TotalPackagingDuration = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[19]), out tempDouble))
                {
                    this.PackingCost = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[20]), out tempDouble))
                {
                    this.PackagingMaterialCost = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[21]), out tempDouble))
                {
                    this.PackagingTotalCost = tempDouble;
                }
                //parts tab
                if (int.TryParse(DecodeValue(data[22]), out tempInt))
                {
                    this.NumberOfParts = tempInt;
                }
                if (double.TryParse(DecodeValue(data[23]), out tempDouble))
                {
                    this.TotalPartsCost = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[24]), out tempDouble))
                {
                    this.TotalToolboxWeight = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[25]), out tempDouble))
                {
                    this.TotalToolboxCost = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[26]), out tempDouble))
                {
                    this.TotalPartsAndToolboxCost = tempDouble;
                }

                //other costs
                if (double.TryParse(DecodeValue(data[27]), out tempDouble))
                {
                    this.OtherCosts = tempDouble;
                }
                this.OtherCostsDescription = DecodeValue(data[28]);

                //footer

                if (int.TryParse(DecodeValue(data[29]), out tempInt))
                {
                    this.AmountOfDevices = tempInt;
                }
                if (double.TryParse(DecodeValue(data[30]), out tempDouble))
                {
                    this.TotalPrice = tempDouble;
                }
                if (double.TryParse(DecodeValue(data[31]), out tempDouble))
                {
                    this.TotalHours = tempDouble;
                }

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
            var result = data.Split(new char[] { 'x' }, 2);
            if (result.Length != 2)
            {
                return "";
            }
            return result[1];
        }
    }
}
