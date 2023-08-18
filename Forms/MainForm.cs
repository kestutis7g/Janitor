using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Janitor_V1.Models;
using Janitor_V1.Utils;

namespace Janitor_V1
{
    public partial class MainForm : Form
    {
        private List<Node> Data;
        private List<Node> PartsData;
        private Calculations Calculations;

        private Prices Prices;
        private bool StainlessSteelToolbox = false;

        // constructor
        public MainForm()
        {
            InitializeComponent();

            this.ContextMenuStrip = contextMenuStrip1;

            //Fix split screen splitter size
            this.splitContainer1.SplitterDistance = (80 * this.splitContainer1.Size.Width / 100);
            this.splitContainer2.SplitterDistance = (80 * this.splitContainer2.Size.Width / 100);
            this.splitContainer3.SplitterDistance = (80 * this.splitContainer3.Size.Width / 100);
            this.Prices = new Prices();
            this.Calculations = new Calculations();
        }

        public void Start()
        {
            FillTree();
            FillAssembliesTree();
            FillPartsTree();

            RefreshCalculations();
        }

        private void FillTree()
        {
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView1.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView1.ChildrenGetter = x => (x as Node).Children;

            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).GetItemNumber();
            colItemNumber.MinimumWidth = 80;
            colItemNumber.HeaderCheckBox = true;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).GetComponentName();
            colComponentName.Width = 100;

            var colReferencedConfiguration = new OLVColumn("ReferencedConfiguration", "ReferencedConfiguration");
            colReferencedConfiguration.AspectGetter = x => (x as Node).GetReferencedConfiguration();
            colReferencedConfiguration.Width = 100;

            var colComponentID = new OLVColumn("ComponentID", "ComponentID");
            colComponentID.AspectGetter = x => (x as Node).GetComponentID();
            colComponentID.Width = 100;
            colComponentID.IsVisible = false;

            var colComponentType = new OLVColumn("ComponentType", "ComponentType");
            colComponentType.AspectGetter = x => (x as Node).ComponentType;
            colComponentType.Width = 100;

            var colChildNodeAssemblyDuration = new OLVColumn("ChildNodeAssemblyDuration", "ChildNodeAssemblyDuration");
            colChildNodeAssemblyDuration.AspectGetter = x => (x as Node).GetChildNodeAssemblyDuration();
            colChildNodeAssemblyDuration.Width = 100;
            colChildNodeAssemblyDuration.IsVisible = false;

            var colIndividualComponentAssemblyDuration = new OLVColumn("IndividualComponentAssemblyDuration", "IndividualComponentAssemblyDuration");
            colIndividualComponentAssemblyDuration.AspectGetter = x => (x as Node).GetIndividualComponentAssemblyDuration();
            colIndividualComponentAssemblyDuration.Width = 100;
            colIndividualComponentAssemblyDuration.IsVisible = false;

            var colAssemblyToParentNodeDuration = new OLVColumn("AssemblyToParentNodeDuration", "AssemblyToParentNodeDuration");
            colAssemblyToParentNodeDuration.AspectGetter = x => (x as Node).GetAssemblyToParentNodeDuration();
            colAssemblyToParentNodeDuration.Width = 100;
            colAssemblyToParentNodeDuration.IsVisible = false;

            var colCombinedAssemblyTime = new OLVColumn("CombinedAssemblyTime", "CombinedAssemblyTime");
            colCombinedAssemblyTime.AspectGetter = x => (x as Node).GetCombinedAssemblyTime();
            colCombinedAssemblyTime.Width = 100;
            colCombinedAssemblyTime.IsVisible = false;

            var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
            colFileLocation.AspectGetter = x => (x as Node).GetFileLocation();
            colFileLocation.MinimumWidth = 100;
            colFileLocation.IsVisible = false;

            var colDescription = new OLVColumn("Description", "Description");
            colDescription.AspectGetter = x => (x as Node).GetDescription();
            colDescription.MinimumWidth = 100;

            var colSurfaceArea = new OLVColumn("SurfaceArea", "SurfaceArea");
            colSurfaceArea.AspectGetter = x => (x as Node).GetSurfaceArea();
            colSurfaceArea.Width = 100;
            colSurfaceArea.IsVisible = false;

            var colWeight = new OLVColumn("Weight", "Weight");
            colWeight.AspectGetter = x => (x as Node).GetWeight();
            colWeight.Width = 100;
            colWeight.IsVisible = false;

            var colWelded = new OLVColumn("Welded", "Welded");
            colWelded.AspectGetter = x => (x as Node).GetWelded();
            colWelded.Width = 100;
            colWelded.IsVisible = false;

            var colBent = new OLVColumn("Bent", "Bent");
            colBent.AspectGetter = x => (x as Node).GetBent();
            colBent.Width = 100;
            colBent.IsVisible = false;

            var colMaterial = new OLVColumn("Material", "Material");
            colMaterial.AspectGetter = x => (x as Node).GetMaterial();
            colMaterial.Width = 100;
            colMaterial.IsVisible = false;

            var colCoverage = new OLVColumn("Coverage", "Coverage");
            colCoverage.AspectGetter = x => (x as Node).GetCoverage();
            colCoverage.Width = 100;
            colCoverage.IsVisible = false;

            var colPrice = new OLVColumn("Price", "Price");
            colPrice.AspectGetter = x => (x as Node).GetPrice();
            colPrice.MinimumWidth = 100;
            colPrice.IsVisible = false;

            var colSheetThickness = new OLVColumn("SheetThickness", "SheetThickness");
            colSheetThickness.AspectGetter = x => (x as Node).GetSheetThickness();
            colSheetThickness.MinimumWidth = 100;
            colSheetThickness.IsVisible = false;


            // add the columns to the tree
            this.treeListView1.Columns.Add(colItemNumber);
            this.treeListView1.Columns.Add(colComponentName);
            this.treeListView1.Columns.Add(colReferencedConfiguration);
            this.treeListView1.Columns.Add(colComponentType);
            this.treeListView1.Columns.Add(colDescription);

            //add columns for column hiding
            this.treeListView1.AllColumns.Add(colItemNumber);
            this.treeListView1.AllColumns.Add(colComponentName);
            this.treeListView1.AllColumns.Add(colReferencedConfiguration);
            this.treeListView1.AllColumns.Add(colComponentID);
            this.treeListView1.AllColumns.Add(colComponentType);
            this.treeListView1.AllColumns.Add(colChildNodeAssemblyDuration);
            this.treeListView1.AllColumns.Add(colIndividualComponentAssemblyDuration);
            this.treeListView1.AllColumns.Add(colAssemblyToParentNodeDuration);
            this.treeListView1.AllColumns.Add(colCombinedAssemblyTime);
            this.treeListView1.AllColumns.Add(colFileLocation);
            this.treeListView1.AllColumns.Add(colDescription);
            this.treeListView1.AllColumns.Add(colSurfaceArea);
            this.treeListView1.AllColumns.Add(colWeight);
            this.treeListView1.AllColumns.Add(colWelded);
            this.treeListView1.AllColumns.Add(colBent);
            this.treeListView1.AllColumns.Add(colMaterial);
            this.treeListView1.AllColumns.Add(colCoverage);
            this.treeListView1.AllColumns.Add(colPrice);
            this.treeListView1.AllColumns.Add(colSheetThickness);


            // set the tree roots
            this.treeListView1.Roots = Data;
            this.treeListView1.CheckBoxes = true;
        }

        private void FillAssembliesTree()
        {
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView3.CanExpandGetter = x => (x as Node).Children.Count > 0 &&
                                                      (x as Node).Children.Where(c => c.ComponentType.ToString() == "Assembly").Count() > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView3.ChildrenGetter = x => (x as Node).Children.Where(c => c.ComponentType.ToString() == "Assembly");

            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).GetItemNumber();
            colItemNumber.MinimumWidth = 80;
            colItemNumber.HeaderCheckBox = true;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).GetComponentName();
            colComponentName.Width = 100;

            var colReferencedConfiguration = new OLVColumn("ReferencedConfiguration", "ReferencedConfiguration");
            colReferencedConfiguration.AspectGetter = x => (x as Node).GetReferencedConfiguration();
            colReferencedConfiguration.Width = 100;

            var colComponentID = new OLVColumn("ComponentID", "ComponentID");
            colComponentID.AspectGetter = x => (x as Node).GetComponentID();
            colComponentID.Width = 100;
            colComponentID.IsVisible = false;

            var colComponentType = new OLVColumn("ComponentType", "ComponentType");
            colComponentType.AspectGetter = x => (x as Node).ComponentType;
            colComponentType.Width = 100;

            var colChildNodeAssemblyDuration = new OLVColumn("ChildNodeAssemblyDuration", "ChildNodeAssemblyDuration");
            colChildNodeAssemblyDuration.AspectGetter = x => (x as Node).GetChildNodeAssemblyDuration();
            colChildNodeAssemblyDuration.Width = 100;

            var colIndividualComponentAssemblyDuration = new OLVColumn("IndividualComponentAssemblyDuration", "IndividualComponentAssemblyDuration");
            colIndividualComponentAssemblyDuration.AspectGetter = x => (x as Node).GetIndividualComponentAssemblyDuration();
            colIndividualComponentAssemblyDuration.Width = 100;

            var colAssemblyToParentNodeDuration = new OLVColumn("AssemblyToParentNodeDuration", "AssemblyToParentNodeDuration");
            colAssemblyToParentNodeDuration.AspectGetter = x => (x as Node).GetAssemblyToParentNodeDuration();
            colAssemblyToParentNodeDuration.Width = 100;

            var colCombinedAssemblyTime = new OLVColumn("CombinedAssemblyTime", "CombinedAssemblyTime");
            colCombinedAssemblyTime.AspectGetter = x => (x as Node).GetCombinedAssemblyTime();
            colCombinedAssemblyTime.Width = 100;

            var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
            colFileLocation.AspectGetter = x => (x as Node).GetFileLocation();
            colFileLocation.MinimumWidth = 100;
            colFileLocation.IsVisible = false;

            var colDescription = new OLVColumn("Description", "Description");
            colDescription.AspectGetter = x => (x as Node).GetDescription();
            colDescription.MinimumWidth = 100;
            colDescription.IsVisible = false;

            // add the columns to the tree
            this.treeListView3.Columns.Add(colItemNumber);
            this.treeListView3.Columns.Add(colComponentName);
            this.treeListView3.Columns.Add(colReferencedConfiguration);
            //this.treeListView3.Columns.Add(colComponentID);
            this.treeListView3.Columns.Add(colComponentType);
            this.treeListView3.Columns.Add(colChildNodeAssemblyDuration);
            this.treeListView3.Columns.Add(colIndividualComponentAssemblyDuration);
            this.treeListView3.Columns.Add(colAssemblyToParentNodeDuration);
            this.treeListView3.Columns.Add(colCombinedAssemblyTime);
            //this.treeListView3.Columns.Add(colFileLocation);

            //add columns for column hiding
            this.treeListView3.AllColumns.Add(colItemNumber);
            this.treeListView3.AllColumns.Add(colComponentName);
            this.treeListView3.AllColumns.Add(colReferencedConfiguration);
            this.treeListView3.AllColumns.Add(colComponentID);
            this.treeListView3.AllColumns.Add(colComponentType);
            this.treeListView3.AllColumns.Add(colChildNodeAssemblyDuration);
            this.treeListView3.AllColumns.Add(colIndividualComponentAssemblyDuration);
            this.treeListView3.AllColumns.Add(colAssemblyToParentNodeDuration);
            this.treeListView3.AllColumns.Add(colCombinedAssemblyTime);
            this.treeListView3.AllColumns.Add(colFileLocation);
            this.treeListView3.AllColumns.Add(colDescription);

            // set the tree roots (filter only Assembly type nodes)
            this.treeListView3.Roots = Data.Where(x => x.ComponentType.ToString() == "Assembly");
            this.treeListView3.CheckBoxes = true;
        }

        private void FillPartsTree()
        {
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView2.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView2.ChildrenGetter = x => (x as Node).Children;


            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).GetItemNumber();
            colItemNumber.MinimumWidth = 80;
            colItemNumber.HeaderCheckBox = true;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).GetComponentName();
            colComponentName.Width = 100;

            var colReferencedConfiguration = new OLVColumn("ReferencedConfiguration", "ReferencedConfiguration");
            colReferencedConfiguration.AspectGetter = x => (x as Node).GetReferencedConfiguration();
            colReferencedConfiguration.Width = 100;

            var colDescription = new OLVColumn("Description", "Description");
            colDescription.AspectGetter = x => (x as Node).GetDescription();
            colDescription.Width = 100;

            var colComponentID = new OLVColumn("ComponentID", "ComponentID");
            colComponentID.AspectGetter = x => (x as Node).GetComponentID();
            colComponentID.Width = 100;
            colComponentID.IsVisible = false;

            var colSurfaceArea = new OLVColumn("SurfaceArea", "SurfaceArea");
            colSurfaceArea.AspectGetter = x => (x as Node).Part.SurfaceArea;
            colSurfaceArea.Width = 100;

            var colWeight = new OLVColumn("Weight", "Weight");
            colWeight.AspectGetter = x => (x as Node).Part.Weight;
            colWeight.Width = 100;

            var colWelded = new OLVColumn("Welded", "Welded");
            colWelded.AspectGetter = x => (x as Node).Part.Welded;
            colWelded.Width = 100;

            var colBent = new OLVColumn("Bent", "Bent");
            colBent.AspectGetter = x => (x as Node).Part.Bent;
            colBent.Width = 100;

            var colMaterial = new OLVColumn("Material", "Material");
            colMaterial.AspectGetter = x => (x as Node).Part.Material;
            colMaterial.Width = 100;

            var colCoverage = new OLVColumn("Coverage", "Coverage");
            colCoverage.AspectGetter = x => (x as Node).Part.Coverage;
            colCoverage.Width = 100;

            var colPrice = new OLVColumn("Price", "Price");
            colPrice.AspectGetter = x => (x as Node).Part.Price;
            colPrice.MinimumWidth = 100;

            var colSheetThickness = new OLVColumn("SheetThickness", "SheetThickness");
            colSheetThickness.AspectGetter = x => (x as Node).Part.SheetThickness;
            colSheetThickness.MinimumWidth = 100;

            var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
            colFileLocation.AspectGetter = x => (x as Node).GetFileLocation();
            colFileLocation.MinimumWidth = 100;
            colFileLocation.IsVisible = false;


            // add the columns to the tree
            this.treeListView2.Columns.Add(colItemNumber);
            this.treeListView2.Columns.Add(colComponentName);
            this.treeListView2.Columns.Add(colReferencedConfiguration);
            this.treeListView2.Columns.Add(colDescription);
            //this.treeListView3.Columns.Add(colComponentID);
            this.treeListView2.Columns.Add(colSurfaceArea);
            this.treeListView2.Columns.Add(colWeight);
            this.treeListView2.Columns.Add(colWelded);
            this.treeListView2.Columns.Add(colBent);
            this.treeListView2.Columns.Add(colMaterial);
            this.treeListView2.Columns.Add(colCoverage);
            this.treeListView2.Columns.Add(colPrice);
            this.treeListView2.Columns.Add(colSheetThickness);

            this.treeListView2.AllColumns.Add(colItemNumber);
            this.treeListView2.AllColumns.Add(colComponentName);
            this.treeListView2.AllColumns.Add(colReferencedConfiguration);
            this.treeListView2.AllColumns.Add(colDescription);
            this.treeListView2.AllColumns.Add(colComponentID);
            this.treeListView2.AllColumns.Add(colSurfaceArea);
            this.treeListView2.AllColumns.Add(colWeight);
            this.treeListView2.AllColumns.Add(colWelded);
            this.treeListView2.AllColumns.Add(colBent);
            this.treeListView2.AllColumns.Add(colMaterial);
            this.treeListView2.AllColumns.Add(colCoverage);
            this.treeListView2.AllColumns.Add(colPrice);
            this.treeListView2.AllColumns.Add(colSheetThickness);
            this.treeListView2.AllColumns.Add(colFileLocation);

            // set the tree roots
            this.treeListView2.Roots = PartsData;
            this.treeListView2.CheckBoxes = true;
        }

        public void SetData(List<Node> data, List<Node> parts)
        {
            this.Data = data;
            this.PartsData = parts;
        }

        /// <summary>
        /// Initialize data tree
        /// </summary>
        public void InitializeData()
        {
            Data = new List<Node>();
            PartsData = new List<Node>();

            var text = File.ReadAllText("..\\..\\Data.csv");

            var parts = text.Split('\n');
            //skip header line
            parts = parts.Skip(1).ToArray();
            //remove empty lines
            parts = parts.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            foreach (var partInfo in parts)
            {
                var info = partInfo.Split(';');

                if (info[0].Split('.').Length > 1)
                {
                    //child node
                    FindDataParent(info[0], Data, partInfo);
                    continue;
                }
                //root node
                AddNode(Data, partInfo);
            }
            CalculateChildNodeAssemblyDuration(Data);
        }

        /// <summary>
        /// Find parent of the node recursively
        /// </summary>
        /// <param name="nodeNumber">node number</param>
        /// <param name="nodes">current level nodes</param>
        /// <param name="partInfo">child node data</param>
        /// <param name="currentLevel">parent search level</param>
        private void FindDataParent(string nodeNumber, List<Node> nodes, string partInfo, int currentLevel = 1)
        {
            var parent = String.Join(".", nodeNumber.Split('.').Take(currentLevel));

            var parentNode = nodes.FirstOrDefault(x => x.GetItemNumber() == parent);

            if (parentNode == null)
            {
                return;
            }

            if (currentLevel + 1 == nodeNumber.Split('.').Count())
            {
                //parent was found
                AddNode(parentNode.Children, partInfo);
                return;
            }
            FindDataParent(nodeNumber, parentNode.Children, partInfo, currentLevel + 1);
        }

        private Node FormatNode(string data)
        {
            var info = data.Split(';');
            double temp1, temp2, temp3, temp4;
            NodeType type;

            Enum.TryParse(info[4], out type);
            double.TryParse(info[5], out temp1);
            double.TryParse(info[6], out temp2);
            double.TryParse(info[7], out temp3);
            double.TryParse(info[8], out temp4);

            var node = new Node();
            node.ComponentType = type;

            if(type == NodeType.Part)
            {
                node.Part.ItemNumber = info[0];
                node.Part.ComponentName = info[1];
                node.Part.ReferencedConfiguration = info[2];
                node.Part.ComponentID = int.Parse(info[3]);
                node.Part.FileLocation = info[9];
                return node;
            }
            else if(type == NodeType.Assembly)
            {
                node.Assembly.ItemNumber = info[0];
                node.Assembly.ComponentName = info[1];
                node.Assembly.ReferencedConfiguration = info[2];
                node.Assembly.ComponentID = int.Parse(info[3]);
                node.Assembly.ChildNodeAssemblyDuration = temp1;
                node.Assembly.IndividualComponentAssemblyDuration = temp2;
                node.Assembly.AssemblyToParentNodeDuration = temp3;
                node.Assembly.CombinedAssemblyTime = temp4;
                node.Assembly.FileLocation = info[9];
                return node;
            }
            return null;
        }

        /// <summary>
        /// Add node to List<Node>
        /// </summary>
        /// <param name="list">list of nodes</param>
        /// <param name="data">string data of the node</param>
        private void AddNode(List<Node> list, string data)
        {
            var node = FormatNode(data);
            list.Add(node);

            if (node.ComponentType.ToString() == "Part")
            {
                PartsData.Add(node);
            }
        }

        private void CalculateChildNodeAssemblyDuration(List<Node> nodes)
        {
            nodes.ForEach(x => {
                if (x.ComponentType.ToString() == "Assembly")
                {
                    x.Assembly.ChildNodeAssemblyDuration = GetChildrenAssemblyDuration(x.Children);
                    x.Assembly.CombinedAssemblyTime = (double)(x.Assembly.ChildNodeAssemblyDuration ?? 0) +
                                             (double)(x.Assembly.IndividualComponentAssemblyDuration ?? 0) +
                                             (double)(x.Assembly.AssemblyToParentNodeDuration ?? 0);
                }
            });
        }

        private double GetChildrenAssemblyDuration(List<Node> nodes)
        {
            double assemblyDuration = 0;
            foreach (var node in nodes)//jei vaiku nera taj 0
            {
                if (node.ComponentType.ToString() == "Assembly")
                {
                    node.Assembly.ChildNodeAssemblyDuration = GetChildrenAssemblyDuration(node.Children);
                    node.Assembly.CombinedAssemblyTime = (double)(node.Assembly.ChildNodeAssemblyDuration ?? 0) +
                                                (double)(node.Assembly.IndividualComponentAssemblyDuration ?? 0) +
                                                (double)(node.Assembly.AssemblyToParentNodeDuration ?? 0);
                    assemblyDuration += (double)node.Assembly.CombinedAssemblyTime;
                }
            }

            return assemblyDuration;
        }

        private void RefreshCalculations()
        {
            Calculations.Calculate(Data, PartsData);

            //ASSEMBLY TAB
            double individualComponentsAssemblyDuration = 0;
            double assemblyToParentDuration = 0;
            double.TryParse(individualComponentsAssemblyTextBox.Text, out individualComponentsAssemblyDuration);
            double.TryParse(assemblyToParentTextBox.Text, out assemblyToParentDuration);

            double combinedAssemblyDuration = Calculations.rootChildNodeAssemblyDuration + individualComponentsAssemblyDuration + assemblyToParentDuration;
            double assemblyPrice = this.Prices.GetById(3).Value;
            double totalAssemblyCost = assemblyPrice * combinedAssemblyDuration;

            rootChildNodeAssemblyTime.Text = "Child node assembly time: " + Calculations.rootChildNodeAssemblyDuration + "h";
            combinedAssemblyDurationLabel.Text = "Combined assembly duration: " + combinedAssemblyDuration + "h";
            assemblyCostLabel.Text = "Assembly cost: " + assemblyPrice + " €/h";
            totalAssemblyCostLabel.Text        = "Total assembly cost: " + totalAssemblyCost + " €";
            totalAssemblyCostGeneralLabel.Text = "Total assembly cost: " + totalAssemblyCost + " €";

            //PARTS TAB
            totalPartsLabel.Text = "Total parts: " + Calculations.totalParts;
            totalPartsCostLabel.Text = "Total parts cost: " + Calculations.totalPartsCost + " €";

            double toolboxPrice = 0;
            double toolboxWeight = 0;
            double.TryParse(toolboxWeightTextBox.Text, out toolboxWeight);

            switch (StainlessSteelToolbox)
            {
                case false:
                    toolboxPrice = this.Prices.GetById(10).Value;
                    break;
                case true:
                    toolboxPrice = this.Prices.GetById(11).Value;
                    break;
                default:
                    toolboxPrice = 0;
                    break;
            }


            toolboxPriceLabel.Text = "Toolbox price: " + toolboxPrice + " €/kg";
            toolboxTotalPriceLabel.Text = "Toolbox price: " + (toolboxPrice * toolboxWeight) + " €";

            double totalPartsTabCost = Calculations.totalPartsCost + (toolboxPrice * toolboxWeight);
            totalPartsTabCostLabel.Text        = "Total parts and toolbox cost: " + totalPartsTabCost + " €";
            totalPartsTabCostGeneralLabel.Text = "Total parts and toolbox cost: " + totalPartsTabCost + " €";

            finalPriceLabel.Text = "Final price: " + (totalPartsTabCost + totalAssemblyCost) + " €";
        }

        private void AddTree()
        {
            //treeListView1 = new TreeListView();
            //treeListView1.Dock = DockStyle.Fill;
            //this.Controls.Add(treeListView1);
        }

        /// <summary>
        /// Open detailed view for selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeListView_ItemActivate(object sender, EventArgs e)
        {
            foreach (Node item in (sender as TreeListView).SelectedObjects)
            {
                OpenItemDetailedView(item, (sender as TreeListView).Name == "treeListView2");
            }
        }

        /// <summary>
        /// Disable context menu if no items are selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (treeListView1.SelectedObjects.Count == 0 &&
                treeListView2.SelectedObjects.Count == 0 &&
                treeListView3.SelectedObjects.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void contextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.Name == "Open")
            {
                
                if (tabControl1.SelectedTab.Name == "tabPageGeneral")
                {
                    treeListView_ItemActivate(this.treeListView1, e);
                }
                else if(tabControl1.SelectedTab.Name == "tabPageParts")
                {
                    treeListView_ItemActivate(this.treeListView2, e);
                }
                else if (tabControl1.SelectedTab.Name == "tabPageAssemblies")
                {
                    treeListView_ItemActivate(this.treeListView3, e);
                }
            }
        }

        private void OpenItemDetailedView(Node item, bool showControls = false)
        {
            var detailsForm = new DetailsForm(item, this.PartsData, showControls);
            //detailsForm.Data = item;
            detailsForm.Show();
        }

        private void seachTextBox1_TextChanged(object sender, EventArgs e)
        {
            var filter = TextMatchFilter.Contains(this.treeListView1, seachTextBox1.Text.Split(' '));
            this.treeListView1.AdditionalFilter = filter;
            this.treeListView1.DefaultRenderer = new HighlightTextRenderer(filter);
        }

        private void seachTextBox2_TextChanged(object sender, EventArgs e)
        {
            var filter = TextMatchFilter.Contains(this.treeListView2, seachTextBox2.Text.Split(' '));
            this.treeListView2.AdditionalFilter = filter;
            this.treeListView2.DefaultRenderer = new HighlightTextRenderer(filter);
        }

        private void seachTextBox3_TextChanged(object sender, EventArgs e)
        {
            var filter = TextMatchFilter.Contains(this.treeListView3, seachTextBox3.Text.Split(' '));
            this.treeListView3.AdditionalFilter = filter;
            this.treeListView3.DefaultRenderer = new HighlightTextRenderer(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var checkedItems = treeListView1.CheckedObjects;

            foreach (Node item in checkedItems)
            {
                MessageBox.Show(item.GetFileLocation() + "\n" + item.GetReferencedConfiguration());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
        }

        private void pricesButton_Click(object sender, EventArgs e)
        {
            var pricesForm = new PricesForm();
            pricesForm.ShowDialog();

            //this.prices.Get();
        }

        private void numbersOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            double count = 0;
            if ((e.KeyChar == '.'))
            {
                e.KeyChar = ',';
            }

            //Allow user to input numbers from 1 to 15
            if (!((char.IsDigit(e.KeyChar) && double.TryParse((sender as System.Windows.Forms.TextBox).Text + e.KeyChar, out count) && count >= 0) ||
                (e.KeyChar == '\b') ||
                (e.KeyChar == ',')))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            RefreshCalculations();
        }

        private void useSteel_CheckedChanged(object sender, EventArgs e)
        {
            this.StainlessSteelToolbox = this.useStainlessSteel.Checked;
            RefreshCalculations();
        }
    }
}