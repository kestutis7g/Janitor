using System;
using System.ComponentModel;
using System.Drawing;

namespace Janitor_V1.Models
{
    public class OtherPart
    {
        [Category("Manufacturing"),
        Description("Description")]
        public string Description { get; set; }

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
        
        [Category("Strip"),
        Description("MarkupForStrip")]
        public double MarkupForStrip { get; set; }

        //###########################################################

        [Category("Purchase"),
        Description("PurchaseDescription")]
        public string PurchaseDescription { get; set; }

        [Category("Purchase"),
        Description("StripMaterialCost")]
        public double Supplier { get; set; }

        [Category("Purchase"),
        Description("ComponentArticle")]
        public double ComponentArticle { get; set; }

        [Category("Purchase"),
        Description("TechnicalParameters")]
        public double TechnicalParameters { get; set; }

        [Category("Purchase"),
        Description("PurchaseCost")]
        public double PurchaseCost { get; set; }

        [Category("Purchase"),
        Description("MarkupCostPurchase")]
        public double MarkupCostPurchase { get; set; }

    }
}
