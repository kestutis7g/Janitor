using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace Janitor_V1.Models
{
    public class Device
    {
        public ModelDoc2 swModel { get; set; }
        public string Configuration { get; set; }
        public string FileLocation { get; set; }


        public double TotalPrice { get; set; }
        public int AmountOfDevices { get; set; }

        //design
        public double PlannedDesigningDuration { get; set; }
        public double RealDesigningDuration { get; set; }
        public double DesigningCostWithoutVAT { get; set; }
        public double DesigningTotalPrice { get; set; }


        //welding
        public double PlannedWeldingDuration { get; set; }
        public double RealWeldingDuration { get; set; }
        public double WeldingCostWithoutVAT { get; set; }
        public double WeldingTotalPrice { get; set; }
        
        //assembly
        public double TotalWorkManagementDuration { get; set; }
        public double WorkManagementCost { get; set; }
        public double WorkManagementTotalCost { get; set; }

        public double TotalSupplyDuration { get; set; }
        public double SupplyCost { get; set; }
        public double SupplyTotalCost { get; set; }
        
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
        //parts
        public int NumberOfParts { get; set; }
        public double TotalPartsCost { get; set; }
        public double TotalToolboxWeight { get; set; }
        public double TotalToolboxCost { get; set; }
        public double TotalPartsAndToolboxCost { get; set; }
        //other costs
        public double OtherCosts { get; set; }
        public string OtherCostsDescription { get; set; }

        public Device() 
        {
            this.TotalPrice = 0;
            this.AmountOfDevices = 1;

            this.PlannedDesigningDuration = 0;
            this.RealDesigningDuration = 0;
            this.DesigningCostWithoutVAT = 0;
            this.DesigningTotalPrice = 0;

            this.PlannedWeldingDuration = 0;
            this.RealWeldingDuration = 0;
            this.WeldingCostWithoutVAT = 0;
            this.WeldingTotalPrice = 0;
            
            this.TotalWorkManagementDuration = 0;
            this.WorkManagementCost = 0;
            this.WorkManagementTotalCost = 0;

            this.TotalSupplyDuration = 0;
            this.SupplyCost = 0;
            this.SupplyTotalCost = 0;

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
    }
}
