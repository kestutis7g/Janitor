using Janitor_V1.Models;
using Janitor_V1.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Janitor_V1
{
    public partial class DetailsForm : Form
    {
        public Models.Node Data { set; get; }
        public List<Models.Node> List { set; get; }
        public bool ShowControls { set; get; }
        int index;

        public DetailsForm(Models.Node data, List<Models.Node> list, bool showControls)
        {
            InitializeComponent();
            this.Data = data;
            this.List = list;
            this.ShowControls = showControls;

            if(!ShowControls)
            {
                previousButton.Visible = false;
                nextButton.Visible = false;
                controlsPanel.Visible = false;
                tabControl1.Dock = DockStyle.Top;
            }

        }

        private void DetailsForm_Load(object sender, System.EventArgs e)
        {
            InitializeData();
        }

        private void InitializeData()
        {
            this.index = this.List.IndexOf(Data);
            UpdateControls();
            if(Data.ComponentType.ToString() == "Assembly")
            {
                RemoveTabs("assembly");
                ResizeTabControl("assembly");
            }
            else if(Data.ComponentType.ToString() == "Part")
            {
                RemoveTabs("part");
                ResizeTabControl("part");
            }

            DynamicTypeDescriptor dt = new DynamicTypeDescriptor(typeof(Models.Node));
            //hide unwanted properties
            if (Data.ComponentType.ToString() == "Assembly")
            {
                dt.RemoveProperty("Material");
                dt.RemoveProperty("Weight");
                dt.RemoveProperty("SurfaceArea");
                dt.RemoveProperty("SheetThickness");
                dt.RemoveProperty("Coverage");
                dt.RemoveProperty("Price");
                dt.RemoveProperty("Markup");
                dt.RemoveProperty("PurchasePrice");
                dt.RemoveProperty("MetalPrice");
                dt.RemoveProperty("PaintingCost");
                dt.RemoveProperty("CuttingCost");
                dt.RemoveProperty("PunchingCost");
                dt.RemoveProperty("BendingCost");
                dt.RemoveProperty("CutLength");
                dt.RemoveProperty("NumberOfBends");
                dt.RemoveProperty("NumberOfPunches");
                dt.RemoveProperty("Welded");
                dt.RemoveProperty("Bent");
            }
            if(Data.ComponentType.ToString() == "Part")
            {
                dt.RemoveProperty("ChildNodeAssemblyDuration");
                dt.RemoveProperty("IndividualComponentAssemblyDuration");
                dt.RemoveProperty("AssemblyToParentNodeDuration");
                dt.RemoveProperty("CombinedAssemblyTime");
            }

            propertyGrid1.SelectedObject = dt.FromComponent(Data);
        }

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            Data = List[this.index + 1];
            InitializeData();
        }

        private void previousButton_Click(object sender, System.EventArgs e)
        {
            Data = List[index - 1];
            InitializeData();
        }

        private void UpdateControls()
        {
            if (index == 0)
            {
                previousButton.Enabled = false;
            }
            else
            {
                previousButton.Enabled = true;
            }

            if (index == List.Count - 1)
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }

        private void RemoveTabs(string formType)
        {
            if(formType == "part")
            {
                this.tabControl1.TabPages.RemoveByKey("designingTabPage");
                this.tabControl1.TabPages.RemoveByKey("weldingTabPage");
                this.tabControl1.TabPages.RemoveByKey("assemblyAndPackagingTabPage");
                this.tabControl1.TabPages.RemoveByKey("partsTabPage");
                this.tabControl1.TabPages.RemoveByKey("otherCostsTabPage");
            }
            else if(formType == "assembly")
            {
                this.tabControl1.TabPages.RemoveByKey("manufacturingTabPage");
                this.tabControl1.TabPages.RemoveByKey("stripsTabPage");
                this.tabControl1.TabPages.RemoveByKey("purchasesTabPage");
            }
        }

        private void ResizeTabControl(string formType)
        {
            if (formType == "part")
            {
                assemblyDetailsPanel.Visible = false;
                this.tabControl1.Height = partDetailsPanel.Location.Y;
            }
            else if (formType == "assembly")
            {
                partDetailsPanel.Visible = false;
                this.tabControl1.Height = assemblyDetailsPanel.Location.Y;
            }
        }
    }
}
