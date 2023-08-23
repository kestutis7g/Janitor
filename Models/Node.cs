using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using SolidWorks.Interop.sldworks;

namespace Janitor_V1.Models
{
    public enum NodeType
    {
        Part,
        Assembly,
    }

    public class Node
    {
        public Part Part { get; set; }
        public Assembly Assembly { get; set; }

        [Category("General"),
        Description("Component Type")]
        public NodeType ComponentType { get; set; }

        [Category("Other"),
        Description("All child nodes")]
        public List<Node> Children { get; set; }

        //public ModelDoc2 swModel { get; set; }

        public Node()
        {
            this.Children = new List<Node>();
            this.Part = new Part();
            this.Assembly = new Assembly();
        }

        public string GetItemNumber()
        {
            if(this.ComponentType == NodeType.Part)
            {
                return Part.ItemNumber;
            }
            else if(this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ItemNumber;
            }
            return "Unknown";
        }

        public string GetComponentName()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ComponentName;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ComponentName;
            }
            return "Unknown";
        }

        public string GetReferencedConfiguration()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ReferencedConfiguration;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ReferencedConfiguration;
            }
            return "Unknown";
        }

        public int GetComponentID()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ComponentID;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ComponentID;
            }
            return -999;
        }

        public string GetDescription()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Description;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.Description;
            }
            return "Unknown";
        }

        public string GetFileLocation()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.FileLocation;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.FileLocation;
            }
            return "Unknown";
        }
        public Image GetSmallImage(string workingDirectory)
        {
            if (this.ComponentType == NodeType.Part && !string.IsNullOrEmpty(Part.ImageLocation))
            {
                return Image.FromFile(Part.ImageLocation);
            }
            else if (this.ComponentType == NodeType.Assembly && !string.IsNullOrEmpty(Assembly.ImageLocation))
            {
                return Image.FromFile(Assembly.ImageLocation);
            }
            return Image.FromFile(workingDirectory + "Assets\\placeholder-small.jpg");
            //return Image.FromFile("C:\\Users\\Dell\\OneDrive - UAB Novatronas\\DARBAI su SOLIDWORKS_V2019\\JANITOR\\Janitor_V1\\Assets\\placeholder-small.jpg");
        }
        public Image GetBigImage(string workingDirectory)
        {

            if (this.ComponentType == NodeType.Part && !string.IsNullOrEmpty(Part.ImageLocation))
            {
                return Image.FromFile(Part.ImageLocation);
            }
            else if (this.ComponentType == NodeType.Assembly && !string.IsNullOrEmpty(Assembly.ImageLocation))
            {
                return Image.FromFile(Assembly.ImageLocation);
            }
            return Image.FromFile(workingDirectory + "Assets\\placeholder-big.jpg");
        }
        public string GetImageLocation()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ImageLocation;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ImageLocation;
            }
            return "Unknown";
        }


        public double? GetChildNodeAssemblyDuration()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ChildNodeAssemblyDuration;
            }
            return -999;
        }
        public double? GetIndividualComponentAssemblyDuration()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.IndividualComponentAssemblyDuration;
            }
            return -999;
        }
        public double? GetAssemblyToParentNodeDuration()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.AssemblyToParentNodeDuration;
            }
            return -999;
        }
        public double? GetCombinedAssemblyTime()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.CombinedAssemblyTime;
            }
            return -999;
        }

        public double? GetSurfaceArea()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.SurfaceArea;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public double? GetWeight()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Weight;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public bool? GetWelded()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Welded;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return false;
        }
        public bool? GetBent()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Bent;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return false;
        }
        public string GetMaterial()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Material;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return "";
            }
            return "Unknown";
        }
        public string GetCoverage()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Coverage;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return "";
            }
            return "Unknown";
        }
        public double? GetPrice()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Price;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public double? GetSheetThickness()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.SheetThickness;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public PartType? GetPartType()
        {
            if (this.ComponentType == NodeType.Part)
            {
                return Part.PartType;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return null;
        }


    }
}
