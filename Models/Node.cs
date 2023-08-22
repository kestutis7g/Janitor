using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

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
        public Image GetSmallImage()
        {
            return Image.FromFile("C:\\Users\\02\\Desktop\\Janitor\\Assets\\placeholder-small.jpg");

            if (this.ComponentType == NodeType.Part)
            {
                return Part.Image;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.Image;
            }
        }
        public Image GetBigImage()
        {
            return Image.FromFile("C:\\Users\\02\\Desktop\\Janitor\\Assets\\placeholder-big.jpg");

            if (this.ComponentType == NodeType.Part)
            {
                return Part.Image;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.Image;
            }
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


    }
}
