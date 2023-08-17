using System.Collections.Generic;
using System.ComponentModel;

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
    }
}
