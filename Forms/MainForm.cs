using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Janitor_V1.Forms;
using Janitor_V1.Models;
using Janitor_V1.Utils;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Janitor_V1
{
    public partial class MainForm : Form
    {
        private string WorkingDirectory { get; set; } //programos vieta, kur yra pats Janitor
        private string ProjectDirectory { get; set; } //atidaryto projekto vieta
        private Device Device { get; set; } //įrenginio objektas

        private List<Node> Data; //visų komponentų medžio struktūra
        private List<Node> PartsData; //detalių sąrašas (ne medis)
        private List<Node> NonTreeData;
        private Calculations Calculations; //skaičiavimų objektas

        private Prices Prices; //Įkainių objektas. Į jį kreipiamasi norint pasiimti, atnaujinti ir tt.
        private bool StainlessSteelToolbox = false; //naudojamas pasižymėti kokio tipo yra toolbox komponentai

        private SldWorks SwApp;
        private bool Initialized = false; //vėliavėlė pasižymėti ar jau supildyti duomenys į formą.

        public MainForm(SldWorks swApp, string workingDirectory, string projectDirectory)
        {
            InitializeComponent();

            this.ContextMenuStrip = contextMenuStrip1;

            //Fix split screen splitter size
            this.splitContainer1.SplitterDistance = (80 * this.splitContainer1.Size.Width / 100);
            this.splitContainer2.SplitterDistance = (80 * this.splitContainer2.Size.Width / 100);
            this.splitContainer3.SplitterDistance = (80 * this.splitContainer3.Size.Width / 100);

            //Fix tree list view size
            this.treeListView1.Location = new System.Drawing.Point(0, this.seachTextBox1.Size.Height);
            this.treeListView1.Size = new Size(this.splitContainer1.Panel1.Width, this.splitContainer1.Panel1.Height - this.seachTextBox1.Size.Height);
            this.treeListView2.Location = new System.Drawing.Point(0, this.seachTextBox2.Size.Height);
            this.treeListView2.Size = new Size(this.splitContainer2.Panel1.Width, this.splitContainer2.Panel1.Height - this.seachTextBox2.Size.Height);
            this.treeListView3.Location = new System.Drawing.Point(0, this.seachTextBox3.Size.Height);
            this.treeListView3.Size = new Size(this.splitContainer3.Panel1.Width, this.splitContainer3.Panel1.Height - this.seachTextBox3.Size.Height);

            this.WorkingDirectory = workingDirectory;
            this.ProjectDirectory = projectDirectory;
            this.Device = new Device();
            this.Prices = new Prices(this.WorkingDirectory);
            this.Calculations = new Calculations();
            this.SwApp = swApp;
        }

        public void Start()
        {
            //formos paleidimas, t.y. supildo formą, atnaujina skaičiavimus
            FillTree();
            FillAssembliesTree();
            FillPartsTree();

            CalculateChildNodeAssemblyDuration(Data);
            RefreshCalculations();
        }

        private void FillTree()
        {
            //grid view (tree list view) užpildymas
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView1.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView1.ChildrenGetter = x => (x as Node).Children;

            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).ItemNumber;
            colItemNumber.MinimumWidth = 80;
            colItemNumber.HeaderCheckBox = true;

            this.treeListView1.SmallImageList = new ImageList();
            this.treeListView1.LargeImageList = new ImageList();
            var colImage = new OLVColumn("Image", "Image");
            colImage.ImageGetter = delegate (object row) {
                String key = (row as Node).ItemNumber;
                if (!this.treeListView1.LargeImageList.Images.ContainsKey(key))
                {
                    Image smallImage = (row as Node).GetSmallImage(this.WorkingDirectory);
                    Image largeImage = (row as Node).GetBigImage(this.WorkingDirectory);
                    this.treeListView1.SmallImageList.Images.Add(key, smallImage);
                    this.treeListView1.LargeImageList.Images.Add(key, largeImage);
                }
                return key;
            };
            colImage.Width = 45;
            colImage.MinimumWidth = 40;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).GetComponentNameWithSpaces();
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

            var colPartType = new OLVColumn("PartType", "PartType");
            colPartType.AspectGetter = x => (x as Node).GetPartType();
            colPartType.Width = 100;

            var colChildNodeAssemblyDuration = new OLVColumn("Combined assembling duration of sub-assemblies", "Combined assembling duration of sub-assemblies");
            colChildNodeAssemblyDuration.AspectGetter = x => (x as Node).GetChildNodeAssemblyDurationString();
            colChildNodeAssemblyDuration.ToolTipText = "Combined assembling duration of sub-assemblies";
            colChildNodeAssemblyDuration.Width = 100;
            colChildNodeAssemblyDuration.IsVisible = false;

            var colIndividualComponentAssemblyDuration = new OLVColumn("Assembling duration of separate components", "Assembling duration of separate components");
            colIndividualComponentAssemblyDuration.AspectGetter = x => (x as Node).GetIndividualComponentAssemblyDurationString();
            colIndividualComponentAssemblyDuration.ToolTipText = "Assembling duration of separate components";
            colIndividualComponentAssemblyDuration.Width = 100;
            colIndividualComponentAssemblyDuration.IsVisible = false;

            var colAssemblyToParentNodeDuration = new OLVColumn("Integration to parent assembly duration", "Integration to parent assembly duration");
            colAssemblyToParentNodeDuration.AspectGetter = x => (x as Node).GetAssemblyToParentNodeDurationString();
            colAssemblyToParentNodeDuration.ToolTipText = "Integration to parent assembly duration";
            colAssemblyToParentNodeDuration.Width = 100;
            colAssemblyToParentNodeDuration.IsVisible = false;

            var colCombinedAssemblyTime = new OLVColumn("Combined assembling time", "Combined assembling time");
            colCombinedAssemblyTime.AspectGetter = x => (x as Node).GetCombinedAssemblyTimeString();
            colAssemblyToParentNodeDuration.ToolTipText = "Combined assembling time";
            colCombinedAssemblyTime.Width = 100;
            colCombinedAssemblyTime.IsVisible = false;

            var colWeldingDuration = new OLVColumn("Welding duration", "Welding duration");
            colWeldingDuration.AspectGetter = x => (x as Node).GetWeldingDurationString();
            colWeldingDuration.ToolTipText = "Welding duration";
            colWeldingDuration.Width = 100;
            colWeldingDuration.IsVisible = false;

            var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
            colFileLocation.AspectGetter = x => (x as Node).GetFileLocation();
            colFileLocation.Width = 100;
            colFileLocation.IsVisible = false;

            var colDescription = new OLVColumn("Description", "Description");
            colDescription.AspectGetter = x => (x as Node).GetDescription();
            colDescription.Width = 100;

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
            colPrice.Width = 100;
            colPrice.IsVisible = false;

            var colSheetThickness = new OLVColumn("SheetThickness", "SheetThickness");
            colSheetThickness.AspectGetter = x => (x as Node).GetSheetThickness();
            colSheetThickness.Width = 100;
            colSheetThickness.IsVisible = false;

            // add the columns to the tree
            this.treeListView1.Columns.Add(colItemNumber);
            this.treeListView1.Columns.Add(colImage);
            this.treeListView1.Columns.Add(colComponentName);
            this.treeListView1.Columns.Add(colReferencedConfiguration);
            this.treeListView1.Columns.Add(colComponentType);
            this.treeListView1.Columns.Add(colPartType);
            this.treeListView1.Columns.Add(colDescription);

            //add columns for column hiding
            this.treeListView1.AllColumns.Add(colItemNumber);
            this.treeListView1.AllColumns.Add(colImage);
            this.treeListView1.AllColumns.Add(colComponentName);
            this.treeListView1.AllColumns.Add(colReferencedConfiguration);
            this.treeListView1.AllColumns.Add(colComponentID);
            this.treeListView1.AllColumns.Add(colComponentType);
            this.treeListView1.AllColumns.Add(colPartType);
            this.treeListView1.AllColumns.Add(colChildNodeAssemblyDuration);
            this.treeListView1.AllColumns.Add(colIndividualComponentAssemblyDuration);
            this.treeListView1.AllColumns.Add(colAssemblyToParentNodeDuration);
            this.treeListView1.AllColumns.Add(colCombinedAssemblyTime);
            this.treeListView1.AllColumns.Add(colWeldingDuration);
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
            //assemblio tabo grid view užpildymas
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView3.CanExpandGetter = x => (x as Node).Children.Count > 0 &&
                                                      (x as Node).Children.Where(c => c.ComponentType == NodeType.Assembly).Count() > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView3.ChildrenGetter = x => (x as Node).Children.Where(c => c.ComponentType == NodeType.Assembly);

            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).ItemNumber;
            colItemNumber.MinimumWidth = 80;
            colItemNumber.HeaderCheckBox = true;

            this.treeListView3.SmallImageList = new ImageList();
            this.treeListView3.LargeImageList = new ImageList();
            var colImage = new OLVColumn("Image", "Image");
            colImage.ImageGetter = delegate (object row) {
                String key = (row as Node).ItemNumber;
                if (!this.treeListView3.LargeImageList.Images.ContainsKey(key))
                {
                    Image smallImage = (row as Node).GetSmallImage(this.WorkingDirectory);
                    Image largeImage = (row as Node).GetBigImage(this.WorkingDirectory);
                    this.treeListView3.SmallImageList.Images.Add(key, smallImage);
                    this.treeListView3.LargeImageList.Images.Add(key, largeImage);
                }
                return key;
            };
            colImage.Width = 45;
            colImage.MinimumWidth = 40;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).GetComponentNameWithSpaces();
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

            var colChildNodeAssemblyDuration = new OLVColumn("Combined assembling duration of sub-assemblies", "Combined assembling duration of sub-assemblies");
            colChildNodeAssemblyDuration.AspectGetter = x => (x as Node).GetChildNodeAssemblyDurationString();
            colChildNodeAssemblyDuration.ToolTipText = "Combined assembling duration of sub-assemblies";
            colChildNodeAssemblyDuration.Width = 100;

            var colIndividualComponentAssemblyDuration = new OLVColumn("Assembling duration of separate components", "Assembling duration of separate components");
            colIndividualComponentAssemblyDuration.AspectGetter = x => (x as Node).GetIndividualComponentAssemblyDurationString();
            colIndividualComponentAssemblyDuration.ToolTipText = "Assembling duration of separate components";
            colIndividualComponentAssemblyDuration.Width = 100;

            var colAssemblyToParentNodeDuration = new OLVColumn("Integration to parent assembly duration", "Integration to parent assembly duration");
            colAssemblyToParentNodeDuration.AspectGetter = x => (x as Node).GetAssemblyToParentNodeDurationString();
            colAssemblyToParentNodeDuration.ToolTipText = "Integration to parent assembly duration";
            colAssemblyToParentNodeDuration.Width = 100;

            var colCombinedAssemblyTime = new OLVColumn("Combined assembling time", "Combined assembling time");
            colCombinedAssemblyTime.AspectGetter = x => (x as Node).GetCombinedAssemblyTimeString();
            colAssemblyToParentNodeDuration.ToolTipText = "Combined assembling time";
            colCombinedAssemblyTime.Width = 100;
            
            var colWeldingDuration = new OLVColumn("Welding duration", "Welding duration");
            colWeldingDuration.AspectGetter = x => (x as Node).GetWeldingDurationString();
            colWeldingDuration.ToolTipText = "Welding duration";
            colWeldingDuration.Width = 100;

            var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
            colFileLocation.AspectGetter = x => (x as Node).GetFileLocation();
            colFileLocation.Width = 100;
            colFileLocation.IsVisible = false;

            var colDescription = new OLVColumn("Description", "Description");
            colDescription.AspectGetter = x => (x as Node).GetDescription();
            colDescription.Width = 100;
            colDescription.IsVisible = false;

            // add the columns to the tree
            this.treeListView3.Columns.Add(colItemNumber);
            this.treeListView3.Columns.Add(colImage);
            this.treeListView3.Columns.Add(colComponentName);
            this.treeListView3.Columns.Add(colReferencedConfiguration);
            //this.treeListView3.Columns.Add(colComponentID);
            this.treeListView3.Columns.Add(colComponentType);
            this.treeListView3.Columns.Add(colChildNodeAssemblyDuration);
            this.treeListView3.Columns.Add(colIndividualComponentAssemblyDuration);
            this.treeListView3.Columns.Add(colAssemblyToParentNodeDuration);
            this.treeListView3.Columns.Add(colCombinedAssemblyTime);
            this.treeListView3.Columns.Add(colWeldingDuration);
            //this.treeListView3.Columns.Add(colFileLocation);

            //add columns for column hiding
            this.treeListView3.AllColumns.Add(colItemNumber);
            this.treeListView3.AllColumns.Add(colImage);
            this.treeListView3.AllColumns.Add(colComponentName);
            this.treeListView3.AllColumns.Add(colReferencedConfiguration);
            this.treeListView3.AllColumns.Add(colComponentID);
            this.treeListView3.AllColumns.Add(colComponentType);
            this.treeListView3.AllColumns.Add(colChildNodeAssemblyDuration);
            this.treeListView3.AllColumns.Add(colIndividualComponentAssemblyDuration);
            this.treeListView3.AllColumns.Add(colAssemblyToParentNodeDuration);
            this.treeListView3.AllColumns.Add(colCombinedAssemblyTime);
            this.treeListView3.AllColumns.Add(colWeldingDuration);
            this.treeListView3.AllColumns.Add(colFileLocation);
            this.treeListView3.AllColumns.Add(colDescription);

            // set the tree roots (filter only Assembly type nodes)
            this.treeListView3.Roots = Data.Where(x => x.ComponentType.ToString() == "Assembly");
            this.treeListView3.CheckBoxes = true;
        }

        private void FillPartsTree()
        {
            //grid view užpildymas part tabe
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView2.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView2.ChildrenGetter = x => (x as Node).Children;

            // create the tree columns and set the delegates to print the desired object proerty
            var colItemNumber = new OLVColumn("ItemNumber", "ItemNumber");
            colItemNumber.AspectGetter = x => (x as Node).ItemNumber;
            colItemNumber.MinimumWidth = 80;
            colItemNumber.HeaderCheckBox = true;

            this.treeListView2.SmallImageList = new ImageList();
            this.treeListView2.LargeImageList = new ImageList();
            var colImage = new OLVColumn("Image", "Image");
            colImage.ImageGetter = delegate (object row) {
                String key = (row as Node).ItemNumber;
                if (!this.treeListView2.LargeImageList.Images.ContainsKey(key))
                {
                    Image smallImage = (row as Node).GetSmallImage(this.WorkingDirectory);
                    Image largeImage = (row as Node).GetBigImage(this.WorkingDirectory);
                    this.treeListView2.SmallImageList.Images.Add(key, smallImage);
                    this.treeListView2.LargeImageList.Images.Add(key, largeImage);
                }
                return key;
            };
            colImage.Width = 45;
            colImage.MinimumWidth = 40;

            var colComponentName = new OLVColumn("ComponentName", "ComponentName");
            colComponentName.AspectGetter = x => (x as Node).GetComponentName();
            colComponentName.Width = 100;

            var colReferencedConfiguration = new OLVColumn("ReferencedConfiguration", "ReferencedConfiguration");
            colReferencedConfiguration.AspectGetter = x => (x as Node).GetReferencedConfiguration();
            colReferencedConfiguration.Width = 100;

            var colPartType = new OLVColumn("PartType", "PartType");
            colPartType.AspectGetter = x => (x as Node).GetPartType();
            colPartType.Width = 100;
            
            var colAmount = new OLVColumn("Amount", "Amount");
            colAmount.AspectGetter = x => (x as Node).DuplicateAmount;
            colAmount.Width = 100;

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
            colPrice.Width = 100;

            var colSheetThickness = new OLVColumn("SheetThickness", "SheetThickness");
            colSheetThickness.AspectGetter = x => (x as Node).Part.SheetThickness;
            colSheetThickness.Width = 100;

            var colFileLocation = new OLVColumn("FileLocation", "FileLocation");
            colFileLocation.AspectGetter = x => (x as Node).GetFileLocation();
            colFileLocation.Width = 100;
            colFileLocation.IsVisible = false;


            // add the columns to the tree
            this.treeListView2.Columns.Add(colItemNumber);
            this.treeListView2.Columns.Add(colImage);
            this.treeListView2.Columns.Add(colComponentName);
            this.treeListView2.Columns.Add(colReferencedConfiguration);
            this.treeListView2.Columns.Add(colPartType);
            this.treeListView2.Columns.Add(colAmount);
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
            this.treeListView2.AllColumns.Add(colImage);
            this.treeListView2.AllColumns.Add(colComponentName);
            this.treeListView2.AllColumns.Add(colReferencedConfiguration);
            this.treeListView2.AllColumns.Add(colPartType);
            this.treeListView2.AllColumns.Add(colAmount);
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

        public void SetData(List<Node> data, List<Node> parts, List<Node> nonTreeData, Device device)
        {
            //prieš start metodo paleidimą iškviečiamas šis metodas, kad formai paduotų komponentų duomenis
            this.Data = data;
            this.PartsData = parts;
            this.NonTreeData = nonTreeData;
            this.Device = device;
            UpdateDevice();

            Initialized = true;
        }

        /// <summary>
        /// Initialize data tree
        /// Is exelio BANDYMAMS
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
        }

        /// <summary>
        /// Find parent of the node recursively
        /// Is exelio BANDYMAMS
        /// </summary>
        /// <param name="nodeNumber">node number</param>
        /// <param name="nodes">current level nodes</param>
        /// <param name="partInfo">child node data</param>
        /// <param name="currentLevel">parent search level</param>
        private void FindDataParent(string nodeNumber, List<Node> nodes, string partInfo, int currentLevel = 1)
        {
            var parent = String.Join(".", nodeNumber.Split('.').Take(currentLevel));

            var parentNode = nodes.FirstOrDefault(x => x.ItemNumber == parent);

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

        //Is exelio BANDYMAMS
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
                node.ItemNumber = info[0];
                node.Part.ComponentName = info[1];
                node.Part.ReferencedConfiguration = info[2];
                node.Part.ComponentID = int.Parse(info[3]);
                node.Part.FileLocation = info[9];
                return node;
            }
            else if(type == NodeType.Assembly)
            {
                node.ItemNumber = info[0];
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
        /// BANDYMAMS
        /// Add node to List<Node>
        /// Is exelio
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
            //suskaičiuoja vaikų surinkimo laiką
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
            //apatinio lango formoje reikšmių perskaičiavimas
            if(!Initialized)
            {
                return;
            }
            Calculations.Calculate(Data, PartsData);

            //ASSEMBLY TAB
            double individualComponentsAssemblyDuration = 0;
            double assemblyToParentDuration = 0;
            double.TryParse(individualComponentsAssemblyTextBox.Text, out individualComponentsAssemblyDuration);
            double.TryParse(assemblyToParentTextBox.Text, out assemblyToParentDuration);

            this.Device.IndividualComponentsAssembly = individualComponentsAssemblyDuration;
            this.Device.AssemblyToParentDuration = assemblyToParentDuration;
            this.Device.ChildNodeAssemblyDuration = Calculations.rootChildNodeAssemblyDuration;

            this.Device.TotalAssemblyDuration = this.Device.ChildNodeAssemblyDuration + this.Device.IndividualComponentsAssembly + this.Device.AssemblyToParentDuration;
            if(this.Device.AssemblyCost == 0)
            {
                this.Device.AssemblyCost = this.Prices.GetById(3).Value;
            }
            this.Device.AssemblyTotalCost = this.Device.AssemblyCost * this.Device.TotalAssemblyDuration;


            rootChildNodeAssemblyTime.Text     = "Child node assembly time: " + this.Device.ChildNodeAssemblyDuration + "h";
            combinedAssemblyDurationLabel.Text = "Combined assembly duration: " + this.Device.TotalAssemblyDuration + "h";
            assemblyCostLabel.Text             = "Assembly cost: " + this.Device.AssemblyCost + " €/h";
            totalAssemblyCostLabel.Text        = "Total assembly cost: " + this.Device.AssemblyTotalCost + " €";
            totalAssemblyCostGeneralLabel.Text = "Total assembly cost: " + this.Device.AssemblyTotalCost + " €";

            //PARTS TAB
            this.Device.NumberOfParts = Calculations.totalParts;
            this.Device.TotalPartsCost = Calculations.totalPartsCost;
            this.Device.TotalToolboxWeight = Calculations.toolboxWeight;

            totalPartsLabel.Text     = "Total number of parts: " + this.Device.NumberOfParts;
            totalPartsCostLabel.Text = "Total cost of the parts: " + this.Device.TotalPartsCost + " €";

            double toolboxPrice = 0;

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
            double toolboxWeight = 0;
            double.TryParse(this.toolboxWeightTextBox.Text, out toolboxWeight);
            //toolboxWeightTextBox.Text = this.Device.TotalToolboxWeight.ToString();
            this.Device.TotalToolboxWeight = toolboxWeight;

            this.Device.TotalToolboxCost = toolboxPrice * this.Device.TotalToolboxWeight;
            this.Device.TotalPartsAndToolboxCost = Calculations.totalPartsCost + this.Device.TotalToolboxCost;

            toolboxPriceLabel.Text = "Toolbox price: " + toolboxPrice + " €/kg";
            toolboxTotalPriceLabel.Text = "Toolbox price: " + this.Device.TotalToolboxCost + " €";

            
            totalPartsTabCostTextBox.Text        = this.Device.TotalPartsAndToolboxCost.ToString();
            totalPartsTabCostGeneralLabel.Text = "Total parts and toolbox cost: " + this.Device.TotalPartsAndToolboxCost + " €";

            finalPriceLabel.Text = "Final price: " + (this.Device.TotalPartsAndToolboxCost + this.Device.AssemblyTotalCost) + " €";
        }

        /// <summary>
        /// Open detailed view for selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeListView_ItemActivate(object sender, EventArgs e)
        {
            //atidaro pasirinktą objektą
            foreach (Node item in (sender as TreeListView).SelectedObjects)
            {
                OpenItemDetailedView(item, (sender as TreeListView).Name == "treeListView2");
                UpdateWindow();
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
            //dešinio pelės mygtuko paspaudimo virš pasirinkto aitemo eventas
            var toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.Name == "OpenDetailsMenuItem")
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
            else if(toolStripMenuItem.Name == "OpenInSolidworksMenuItem")
            {
                openItemButton_Click(sender, e);
            }
        }

        private void OpenItemDetailedView(Node item, bool showControls = false)
        {
            var detailsForm = new DetailsForm(this.WorkingDirectory, this.ProjectDirectory, item, this.PartsData, () => UpdateWindow(), this.SwApp, showControls);
            detailsForm.Show();
        }
        private void seachTextBox_TextChanged(object sender, EventArgs e)
        {
            //paieškos eventas
            TextMatchFilter filter;
            switch ((sender as TextBox).Name)
            {
                case "seachTextBox1":
                    filter = TextMatchFilter.Contains(this.treeListView1, seachTextBox1.Text.Split(' '));
                    this.treeListView1.AdditionalFilter = filter;
                    this.treeListView1.DefaultRenderer = new HighlightTextRenderer(filter);
                    break;
                case "seachTextBox2":
                    filter = TextMatchFilter.Contains(this.treeListView2, seachTextBox2.Text.Split(' '));
                    this.treeListView2.AdditionalFilter = filter;
                    this.treeListView2.DefaultRenderer = new HighlightTextRenderer(filter);
                    break;
                case "seachTextBox3":
                    filter = TextMatchFilter.Contains(this.treeListView3, seachTextBox3.Text.Split(' '));
                    this.treeListView3.AdditionalFilter = filter;
                    this.treeListView3.DefaultRenderer = new HighlightTextRenderer(filter);
                    break;
                default:
                    break;
            }
        }

        private void pricesButton_Click(object sender, EventArgs e)
        {
            //atidaroma įkainių forma paspaudus mygtuką
            var pricesForm = new PricesForm(this.WorkingDirectory);
            pricesForm.ShowDialog();
        }

        private void numbersOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //eventas, kuris užtikrina, kad Textboxe įrašomas realus skaičius
            double count = 0;
            if ((e.KeyChar == ','))
            {
                e.KeyChar = '.';
            }

            if (!((char.IsDigit(e.KeyChar) && double.TryParse((sender as TextBox).Text + e.KeyChar, out count) && count >= 0) ||
                (e.KeyChar == '\b') ||
                (e.KeyChar == '.')))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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
            //jei pasikeitė Toolbox tipas, tai šis eventas perskaičiuoja
            this.StainlessSteelToolbox = this.useStainlessSteel.Checked;
            RefreshCalculations();
        }

        private void openItemButton_Click(object sender, EventArgs e)
        {
            //atidarymo Solidworkse mygtuko eventas
            if (tabControl1.SelectedTab.Name == "tabPageGeneral")
            {
                openItemInSolidWorks(this.treeListView1, e);
            }
            else if (tabControl1.SelectedTab.Name == "tabPageParts")
            {
                openItemInSolidWorks(this.treeListView2, e);
            }
            else if (tabControl1.SelectedTab.Name == "tabPageAssemblies")
            {
                openItemInSolidWorks(this.treeListView3, e);
            }
        }

        private void openItemInSolidWorks(object sender, EventArgs e)
        {
            //Komponento atidarymas Solidworkse
            foreach (Node item in (sender as TreeListView).SelectedObjects)
            {
                if (item.ComponentType == NodeType.Part) 
                {
                    Solidworks_control_tools.OpenItem(this.SwApp, item.GetFileLocation(), (int)swDocumentTypes_e.swDocPART, (string)item.GetReferencedConfiguration());
                }
                else if (item.ComponentType == NodeType.Assembly)
                {
                    Solidworks_control_tools.OpenItem(this.SwApp,item.GetFileLocation(), (int)swDocumentTypes_e.swDocASSEMBLY, (string)item.GetReferencedConfiguration());
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //Atnaujinimo mygtukas, kad viską perskaičiuotų
            CalculateChildNodeAssemblyDuration(Data);
            RefreshCalculations();

            UpdateWindow();
        }

        public void UpdateWindow()
        {
            treeListView1.Update();
            treeListView2.Update();
            treeListView3.Update();
            treeListView1.Refresh();
            treeListView2.Refresh();
            treeListView3.Refresh();
        }
        public void UpdateDevice()
        {
            this.individualComponentsAssemblyTextBox.Text = this.Device.IndividualComponentsAssembly.ToString();
            this.assemblyToParentTextBox.Text = this.Device.AssemblyToParentDuration.ToString();
        }

        private void deviceButton_Click(object sender, EventArgs e)
        {
            //Atidaro įrenginio formą
            var deviceForm = new DeviceForm(this.WorkingDirectory, this.Device, this.Data, this.Calculations, () => UpdateDevice());
            deviceForm.ShowDialog();
        }

        private void treeListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //LEntelės aitemo pasirinkimo eventas (parodo nuotrauką dešinėje)
            var selected = (sender as TreeListView).SelectedObject as Node;

            if(selected != null)
            {
                switch ((sender as TreeListView).Name)
                {
                    case "treeListView1":
                        this.pictureBox1.BackgroundImage = selected.GetBigImage(this.WorkingDirectory);
                        break;
                    case "treeListView2":
                        this.pictureBox2.BackgroundImage = selected.GetBigImage(this.WorkingDirectory);
                        break;
                    case "treeListView3":
                        this.pictureBox3.BackgroundImage = selected.GetBigImage(this.WorkingDirectory);
                        break;
                    default:
                        break;
                }
            }
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //Split screeno eventas, kuris resaizina nuotrauką pagal splitscreeno dydį. 
            switch ((sender as SplitContainer).Name)
            {
                case "splitContainer1":
                    this.pictureBox1.Height = (this.pictureBox1.Width * 2 / 3);
                    break;
                case "splitContainer2":
                    this.pictureBox2.Height = (this.pictureBox2.Width * 2 / 3);
                    break;
                case "splitContainer3":
                    this.pictureBox3.Height = (this.pictureBox3.Width * 2 / 3);
                    break;
                default:
                    break;
            }
            
        }

        private void takePicture_Click(object sender, EventArgs e)
        {
            //nuotraukos nufotografavimas (pačekintos varnelėmis komponentai
            IList checkedItems;
            switch ((sender as Button).Name)
            {
                case "takePictureButton1":
                    checkedItems = treeListView1.CheckedObjects;
                    break;
                case "takePictureButton2":
                    checkedItems = treeListView2.CheckedObjects;
                    break;
                case "takePictureButton3":
                    checkedItems = treeListView3.CheckedObjects;
                    break;
                default:
                    return;
            }

            foreach (Node item in checkedItems)
            {
                if (item.ComponentType == NodeType.Assembly)
                {
                    item.Assembly.ImageLocation = Solidworks_control_tools.TakePictureOfItem(SwApp,  item.GetFileLocation(), (int)swDocumentTypes_e.swDocASSEMBLY, item.GetSwModel(), item.GetReferencedConfiguration(), this.ProjectDirectory + "Images\\", item.GetComponentName() + "(" + item.GetReferencedConfiguration() + ")");
                    //įrašo į properčius nuotraukos lokaciją
                    item.GetSwModel().AddCustomInfo3(item.GetReferencedConfiguration(),
                        "Paveikslelio failas", (int)swCustomInfoType_e.swCustomInfoText, "");
                    item.GetSwModel().CustomInfo2[item.GetReferencedConfiguration(),
                        "Paveikslelio failas"] = item.Assembly.ImageLocation;
                }
                else if (item.ComponentType == NodeType.Part)
                {
                    item.Part.ImageLocation = Solidworks_control_tools.TakePictureOfItem(SwApp, item.GetFileLocation(), (int)swDocumentTypes_e.swDocPART, item.GetSwModel(), item.GetReferencedConfiguration(), this.ProjectDirectory + "Images\\", item.GetComponentName() + "(" + item.GetReferencedConfiguration() + ")");
                    item.GetSwModel().AddCustomInfo3(item.GetReferencedConfiguration(),
                        "Paveikslelio failas", (int)swCustomInfoType_e.swCustomInfoText, "");
                    item.GetSwModel().CustomInfo2[item.GetReferencedConfiguration(),
                        "Paveikslelio failas"] = item.Part.ImageLocation;
                }
            }

            switch ((sender as Button).Name)
            {
                case "takePictureButton1":
                    treeListView_ItemSelectionChanged(treeListView1, null);
                    break;
                case "takePictureButton2":
                    treeListView_ItemSelectionChanged(treeListView2, null);
                    break;
                case "takePictureButton3":
                    treeListView_ItemSelectionChanged(treeListView3, null);
                    break;
                default:
                    return;
            }
        }

        private void treeListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //varnele pažymėjimo eventas, kuris įjungia ir išjungia mygtukus dešinėje
            switch ((sender as TreeListView).Name)
            {
                case "treeListView1":
                    if (treeListView1.CheckedObjects.Count > 0)
                    {
                        this.takePictureButton1.Enabled = true;
                        this.readPropertiesButton1.Enabled = true;
                    }
                    else
                    {
                        this.takePictureButton1.Enabled = false;
                        this.readPropertiesButton1.Enabled = false;
                    }
                    break;
                case "treeListView2":
                    if (treeListView2.CheckedObjects.Count > 0)
                    {
                        this.takePictureButton2.Enabled = true;
                        this.readPropertiesButton2.Enabled = true;
                    }
                    else
                    {
                        this.takePictureButton2.Enabled = false;
                        this.readPropertiesButton2.Enabled = false;
                    }
                    break;
                case "treeListView3":
                    if (treeListView3.CheckedObjects.Count > 0)
                    {
                        this.takePictureButton3.Enabled = true;
                        this.readPropertiesButton3.Enabled = true;
                    }
                    else
                    {
                        this.takePictureButton3.Enabled = false;
                        this.readPropertiesButton3.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void treeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //paselektinimo eventas, kuris įjungia atidarymo Solidworkse mygtuką
            switch ((sender as TreeListView).Name)
            {
                case "treeListView1":
                    if (treeListView1.SelectedIndices.Count > 0)
                    {
                        this.openInSolidworksButton1.Enabled = true;
                    }
                    else
                    {
                        this.openInSolidworksButton1.Enabled = false;
                    }
                    break;
                case "treeListView2":
                    if (treeListView2.SelectedIndices.Count > 0)
                    {
                        this.openInSolidworksButton2.Enabled = true;
                    }
                    else
                    {
                        this.openInSolidworksButton2.Enabled = false;
                    }
                    break;
                case "treeListView3":
                    if (treeListView3.SelectedIndices.Count > 0)
                    {
                        this.openInSolidworksButton3.Enabled = true;
                    }
                    else
                    {
                        this.openInSolidworksButton3.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void readPropertiesButton_Click(object sender, EventArgs e)
        {
            //nuskaitomi pažymėtų varnelėmis properčiai iš Solidworks
            var nodeTraversal = new NodeTraversal();
            nodeTraversal.swApp = SwApp;

            IList checkedItems;
            switch ((sender as Button).Name)
            {
                case "readPropertiesButton1":
                    checkedItems = treeListView1.CheckedObjects;
                    break;
                case "readPropertiesButton2":
                    checkedItems = treeListView2.CheckedObjects;
                    break;
                case "readPropertiesButton3":
                    checkedItems = treeListView3.CheckedObjects;
                    break;
                default:
                    return;
            }

            foreach (Node node in checkedItems)
            {
                ReadNodePropertiesFromSolidworks(nodeTraversal, node);
            }
            this.UpdateWindow();
        }

        private void ReadNodePropertiesFromSolidworks(NodeTraversal nodeTraversal, Node node)
        {
            var temp = nodeTraversal.ReadProperties(node.GetSwModel(), node.GetSwComp(), node.ItemNumber);
            node.Update(temp);
        }

        private void toolboxRefreshButton_Click(object sender, EventArgs e)
        {
            //atnaujina Toolbox komponentų svorį
            double toolboxWeight = 0;
            foreach(Node node in Data.Where(x => x.ComponentType == NodeType.Part && 
                                                 x.Part.PartType == PartType.Toolbox))
            {
                node.Part.Weight = Solidworks_control_tools.WeightOfComponent(SwApp, node.GetFileLocation(), node.GetReferencedConfiguration());
                toolboxWeight += node.Part.Weight ?? 0;
            }
            toolboxWeightTextBox.Text = toolboxWeight.ToString();
            this.Device.TotalToolboxWeight = toolboxWeight;
        }

        private void generateDXFandPDFbutton_Click(object sender, EventArgs e)
        {
            IList checkedItems;
            checkedItems = treeListView2.CheckedObjects;

            foreach (Node node in checkedItems)
            {
                generateDXFandPDF(node);
            }
        }

        private void generateDXFandPDF(Node node)
        {

        }
    }
}