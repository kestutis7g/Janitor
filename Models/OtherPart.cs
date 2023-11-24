using System;
using System.ComponentModel;
using System.Drawing;

namespace Janitor_V1.Models
{
    public class OtherPart
    {
        //Detalės tipo OTHER properčiai
        [Category("Manufacturing"),
        Description("MaterialWeight")]
        public double MaterialWeight { get; set; }

        [Category("Manufacturing"),
        Description("MaterialCost")]
        public double MaterialCost { get; set; }

        [Category("Manufacturing"),
        Description("AmountOfThisPart")]
        public int AmountOfThisPart { get; set; }

        [Category("Manufacturing"),
        Description("ProgrammingDuration")]
        public double ProgrammingDuration { get; set; }

        [Category("Manufacturing"),
        Description("ProgrammingCost")]
        public double ProgrammingCost { get; set; }

        [Category("Manufacturing"),
        Description("SinglePieceManufacturingDuration")]
        public double SinglePieceManufacturingDuration { get; set; }

        [Category("Manufacturing"),
        Description("ManufacturingCost")]
        public double ManufacturingCost { get; set; }

        //###########################################################

        [Category("Strip"),
        Description("StripType")]
        public string StripType { get; set; }

        [Category("Strip"),
        Description("StripMaterialCost")]
        public double StripMaterialCost { get; set; }

        [Category("Strip"),
        Description("StripLength")]
        public double StripLength { get; set; }

        [Category("Strip"),
        Description("StripWidth")]
        public double StripWidth { get; set; }
        
        [Category("Strip"),
        Description("StripPurchaseCost")]
        public double StripPurchaseCost { get; set; }

        //###########################################################

        [Category("Purchase"),
        Description("Supplier")]
        public string Supplier { get; set; }

        [Category("Purchase"),
        Description("Vendor number")]
        public string VendorNo { get; set; }

        [Category("Purchase"),
        Description("TechnicalParameters")]
        public string TechnicalParameters { get; set; }

        [Category("Purchase"),
        Description("PurchaseCost")]
        public double PurchaseCost { get; set; }

    }
}
