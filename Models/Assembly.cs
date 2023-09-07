using System.ComponentModel;
using System.Drawing;
using SolidWorks.Interop.sldworks;

namespace Janitor_V1.Models
{
    public class Assembly
    {
        [Category("General"),
        Description("Name of the component")]
        public string ComponentName { get; set; }

        [Category("General"),
        Description("Description of the component")]
        public string Description { get; set; }

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
    }
}
