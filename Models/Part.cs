using System;
using System.ComponentModel;
using System.Drawing;
using SolidWorks.Interop.sldworks;

namespace Janitor_V1.Models
{
    public enum PartType
    {
        //parto tipo enumeratorius
        Sheet, //kol kas šito tipo dar neatskyrėm, bet turbūt reikės
        Toolbox,
        Other
    }
    public class Part
    {
        [Category("General"),
        Description("Name of the component")]
        public string ComponentName { get; set; }
        
        [Category("General"),
        Description("Part type")]
        public PartType PartType { get; set; } 

        [Category("General"),
        Description("Description of the component")]
        public string Description { get; set; }

        [Category("Other"),
        Description("Part reference configuration")]
        public string ReferencedConfiguration { get; set; }

        [Category("General"),
        Description("Component ID")]
        public int ComponentID { get; set; }

        [Category("Other"),
        Description("Location of the file")]
        public string FileLocation { get; set; }

        [Category("Image"),
        Description("Image of the part")]
        public Image Image { get; set; }

        [Category("Image"),
        Description("Image file location")]
        public string ImageLocation { get; set; }

        [Category("Properties"),
        Description("Material")]
        public string Material { get; set; }

        [Category("Properties"),
        Description("Weight")]
        public double? Weight { get; set; }

        [Category("Properties"),
        Description("Surface area")]
        public double? SurfaceArea { get; set; }

        [Category("Properties"),
        Description("Sheet thickness")]
        public double? SheetThickness { get; set; }

        [Category("Properties"),
        Description("Coverage")]
        public string Coverage { get; set; }

        [Category("Price"),
        Description("Price")]
        public double? Price { get; set; }
        [Category("Price"),
        Description("Markup price of the part")]
        public double? Markup { get; set; }

        [Category("Price"),
        Description("Price to purchese")]
        public double? PurchasePrice { get; set; }

        [Category("Price"),
        Description("Metal price")]
        public double? MetalPrice { get; set; }

        [Category("Price"),
        Description("Cost of painting the part with powder paint")]
        public double? PaintingCost { get; set; }

        [Category("Price"),
        Description("Cost to cut the part")]
        public double? CuttingCost { get; set; }

        [Category("Price"),
        Description("Cost to punch the part")]
        public double? PunchingCost { get; set; }

        [Category("Price"),
        Description("Cost to bend the part")]
        public double? BendingCost { get; set; }

        [Category("Manufacturing"),
        Description("Length of the cut in meters")]
        public double? CutLength { get; set; }

        [Category("Manufacturing"),
        Description("Number of bends")]
        public int? NumberOfBends { get; set; }

        [Category("Manufacturing"),
        Description("Number of punches")]
        public int? NumberOfPunches { get; set; }

        [Category("Manufacturing"),
        Description("Does the part require welding")]
        public bool? Welded { get; set; }

        [Category("Manufacturing"),
        Description("Does the part require bending")]
        public bool? Bent { get; set; }

        [Category("General"),
        Description("Date properties was last updated")]
        public DateTime? UpdatedAt { get; set; }
        
        [Category("Other"),
        Description("Other part parameters")]
        public OtherPart OtherPart { get; set; }

        public ModelDoc2 swModel { get; set; }
        public Component2 swComp { get; set; }

        public Part()
        {
            ComponentID = 0;
            Weight = 0;
            SurfaceArea = 0;
            SheetThickness = 0;
            Price = 0;
            Markup = 0;
            PurchasePrice = 0;
            MetalPrice = 0;
            PaintingCost = 0;
            CuttingCost = 0;
            PunchingCost = 0;
            BendingCost = 0;
            CutLength = 0;
            NumberOfBends = 0;
            NumberOfPunches = 0;
            Welded = false;
            Bent = false;
            OtherPart = new OtherPart();
        }
        public Part(string componentName, string description, string referencedConfiguration, int componentID, string fileLocation, Image image, string material, double? weight, double? surfaceArea, double? sheetThickness, string coverage, double? price, double? markup, double? purchasePrice, double? metalPrice, double? paintingCost, double? cuttingCost, double? punchingCost, double? bendingCost, double? cutLength, int? numberOfBends, int? numberOfPunches, bool? welded, bool? bent, DateTime? updatedAt)
        {
            ComponentName = componentName;
            Description = description;
            ReferencedConfiguration = referencedConfiguration;
            ComponentID = componentID;
            FileLocation = fileLocation;
            Image = image;
            Material = material;
            Weight = weight;
            SurfaceArea = surfaceArea;
            SheetThickness = sheetThickness;
            Coverage = coverage;
            Price = price;
            Markup = markup;
            PurchasePrice = purchasePrice;
            MetalPrice = metalPrice;
            PaintingCost = paintingCost;
            CuttingCost = cuttingCost;
            PunchingCost = punchingCost;
            BendingCost = bendingCost;
            CutLength = cutLength;
            NumberOfBends = numberOfBends;
            NumberOfPunches = numberOfPunches;
            Welded = welded;
            Bent = bent;
            UpdatedAt = updatedAt;
        }
    }
}
