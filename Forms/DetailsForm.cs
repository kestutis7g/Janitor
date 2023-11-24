using Janitor_V1.Models;
using Janitor_V1.Utils;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Janitor_V1
{
    public partial class DetailsForm : Form
    {
        public string WorkingDirectory { set; get; }
        public string ProjectDirectory { set; get; }
        public Node Data { set; get; }
        public List<Node> List { set; get; }
        public bool ShowControls { set; get; }
        private Action UpdateMainForm { set; get; }
        private SldWorks SwApp;
        private int index;

        private Dictionary<string, TabPage> TabPages = new Dictionary<string, TabPage>();


        public DetailsForm(string workingDirectory, string projectDirectory, Node data, List<Node> list, Action updateMainForm, SldWorks swApp, bool showControls)
        {
            //komponentų properčių peržiūrėjimo lango kodas
            InitializeComponent();

            this.WorkingDirectory = workingDirectory;
            this.ProjectDirectory = projectDirectory;
            this.Data = data;
            this.List = list;
            this.ShowControls = showControls;
            this.UpdateMainForm = updateMainForm;
            this.SwApp = swApp;

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
            this.TabPages.Add("weldingTabPage", this.tabControl1.TabPages["weldingTabPage"]);
            this.TabPages.Add("assemblyTabPage", this.tabControl1.TabPages["assemblyTabPage"]);
            this.TabPages.Add("otherCostsTabPage", this.tabControl1.TabPages["otherCostsTabPage"]);
            this.TabPages.Add("manufacturingTabPage", this.tabControl1.TabPages["manufacturingTabPage"]);
            this.TabPages.Add("stripsTabPage", this.tabControl1.TabPages["stripsTabPage"]);
            this.TabPages.Add("purchasesTabPage", this.tabControl1.TabPages["purchasesTabPage"]);
            this.TabPages.Add("generalTabPage", this.tabControl1.TabPages["generalTabPage"]);
            this.TabPages.Add("propertiesTabPage", this.tabControl1.TabPages["propertiesTabPage"]);
            InitializeData();
        }

        private void InitializeData()
        {
            this.index = this.List.IndexOf(Data);
            UpdateControls();
            if(Data.ComponentType == NodeType.Assembly)
            {
                RemoveTabs("assembly");
                ResizeTabControl("assembly");

                ReloadAssembly();
            }
            else if(Data.ComponentType == NodeType.Part)
            {
                if(Data.Part.PartType == PartType.Other)
                {
                    RemoveTabs("otherpart");
                    ResizeTabControl("part");
                }
                else if (Data.Part.PartType != PartType.Other)
                {
                    RemoveTabs("part");
                    ResizeTabControl("part");
                }

                ReloadPart();
            }
            this.Text = Data.GetComponentName() + " | " + Data.GetReferencedConfiguration();
            this.pictureBox1.BackgroundImage = Data.GetBigImage(this.WorkingDirectory);
        }

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            //eina per detales
            Data = List[this.index + 1];
            InitializeData();
            UpdateMainForm();
        }

        private void previousButton_Click(object sender, System.EventArgs e)
        {
            //eina per detales
            Data = List[index - 1];
            InitializeData();
            UpdateMainForm();
        }

        private void UpdateControls()
        {
            //kai nueini iki galo, tai nebelaidžia ėjimo per komponentus mygtukų spaudžioti
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

        /// <summary>
        /// Remove tabControl tabs according to node type
        /// </summary>
        /// <param name="formType"></param>
        private void RemoveTabs(string formType)
        {
            this.tabControl1.TabPages.Clear();
            //tabų išjungimas pagal komponento tipą
            if (formType == "part")
            {
                this.tabControl1.TabPages.RemoveByKey("weldingTabPage");
                this.tabControl1.TabPages.RemoveByKey("assemblyTabPage");
                this.tabControl1.TabPages.RemoveByKey("otherCostsTabPage");
                this.tabControl1.TabPages.RemoveByKey("manufacturingTabPage");
                this.tabControl1.TabPages.RemoveByKey("stripsTabPage");
                this.tabControl1.TabPages.RemoveByKey("purchasesTabPage");
                this.tabControl1.TabPages.Add(TabPages["generalTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["propertiesTabPage"]);
            }
            else if (formType == "otherpart")
            {
                this.tabControl1.TabPages.RemoveByKey("weldingTabPage");
                this.tabControl1.TabPages.RemoveByKey("assemblyTabPage");
                this.tabControl1.TabPages.RemoveByKey("otherCostsTabPage");
                this.tabControl1.TabPages.Add(TabPages["manufacturingTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["stripsTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["purchasesTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["generalTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["propertiesTabPage"]);
            }
            else if(formType == "assembly")
            {
                this.tabControl1.TabPages.Add(TabPages["weldingTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["assemblyTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["otherCostsTabPage"]);
                this.tabControl1.TabPages.RemoveByKey("manufacturingTabPage");
                this.tabControl1.TabPages.RemoveByKey("stripsTabPage");
                this.tabControl1.TabPages.RemoveByKey("purchasesTabPage");
                this.tabControl1.TabPages.Add(TabPages["generalTabPage"]);
                this.tabControl1.TabPages.Add(TabPages["propertiesTabPage"]);
            }
        }
        /// <summary>
        /// Resize tabControl to fill window according to bottom panels
        /// </summary>
        /// <param name="formType"></param>
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

        private void FillGeneralTab()
        {
            this.descriptionTextBox.Text = Data.GetDescription();
            this.notesTextBox.Text = Data.GetNotes();
        }

        private void FillManufacturingTab()
        {
            //Užpildo gamybos tabo textboxus duomenimis
            this.materialWeightTextBox.Text =
                Data.Part.OtherPart.MaterialWeight.ToString();

            this.programmingCostTextBox.Text =
                Data.Part.OtherPart.ProgrammingCost.ToString();

            this.programmingDurationTextBox.Text =
                Data.Part.OtherPart.ProgrammingDuration.ToString();

            this.materialCostTextBox.Text =
                Data.Part.OtherPart.ManufacturingCost.ToString();

            this.amountOfThisPartTextBox.Text =
                Data.Part.OtherPart.AmountOfThisPart.ToString();

            this.manufacturingCostTextBox.Text =
                Data.Part.OtherPart.ManufacturingCost.ToString();

            var calculatedPartPrice = ((Data.Part.Weight * Data.Part.OtherPart.MaterialCost) + 
                (Data.Part.OtherPart.ProgrammingDuration * Data.Part.OtherPart.ProgrammingCost / Data.Part.OtherPart.AmountOfThisPart) + 
                (Data.Part.OtherPart.SinglePieceManufacturingDuration / 60 * Data.Part.OtherPart.ManufacturingCost));
        }
        private void FillStripsTab()
        {
            //Konvejerio juostų tabo duomenų pildymas
            this.stripMaterialCostTextBox.Text =
                Data.Part.OtherPart.StripMaterialCost.ToString();
        }
        private void FillPurchasesTab()
        {
            //Perkamų komponentų tabo textboxų užpildymas
            this.supplierTextBox.Text =
                Data.Part.OtherPart.Supplier.ToString();

            this.vendorNoTextBox.Text =
                Data.Part.OtherPart.VendorNo.ToString();

            this.technicalParametersTextBox.Text =
                Data.Part.OtherPart.TechnicalParameters.ToString();

            this.purchaseCostTextBox.Text =
                Data.Part.OtherPart.PurchaseCost.ToString();
            
            this.markupCostPurchaseTextBox.Text =
                Data.Part.Markup.ToString();
        }

        private void FillWeldingTab()
        {
            //uzpildyti virinimo duomenis
            var time = new Time((double)this.Data.Assembly.WeldingDuration);
            this.plannedWeldingDurationHourTextBox.Text = time.Hour.ToString();
            this.plannedWeldingDurationMinuteTextBox.Text = time.Minute.ToString();
        }
        private void FillAssemblyTab()
        {
            //Surinkimo tabo textboxo duomenų užpildymas
            var time = new Time((double)this.Data.Assembly.ChildNodeAssemblyDuration);
            this.childNodeAssemblyDurationHourTextBox.Text = time.Hour.ToString();
            this.childNodeAssemblyDurationMinuteTextBox.Text = time.Minute.ToString();

            time = new Time((double)this.Data.Assembly.IndividualComponentAssemblyDuration);
            this.individualComponentAssemblyDurationHourTextBox.Text = time.Hour.ToString();
            this.individualComponentAssemblyDurationMinuteTextBox.Text = time.Minute.ToString();

            time = new Time((double)this.Data.Assembly.AssemblyToParentNodeDuration);
            this.assemblyToParentNodeDurationHourTextBox.Text = time.Hour.ToString();
            this.assemblyToParentNodeDurationMinuteTextBox.Text = time.Minute.ToString();
            
            time = new Time((double)this.Data.Assembly.CombinedAssemblyTime);
            this.combinedAssemblyTimeHourTextBox.Text = time.Hour.ToString();
            this.combinedAssemblyTimeMinuteTextBox.Text = time.Minute.ToString();
        }
        private void FillOtherCostsTab()
        {
            //uzpildyti kitu kastu duomenis
            this.otherCostsTextBox.Text = this.Data.Assembly.OtherCosts.ToString();
            this.otherCostsDescriptionTextBox.Text = this.Data.Assembly.OtherCostsDescription;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Išsaugojimas į Solidworksą 
            if(this.Data.ComponentType == NodeType.Assembly)
            {
                SaveAssembly();

                ReloadAssembly();
            }
            else if(this.Data.ComponentType == NodeType.Part)
            {
                //Į partus kol kas nesaugo
                SavePart();

                ReloadPart();
            }
            Data.CheckIfComponentValuesEmpty();
        }

        private void SavePart() 
        {
            //part tipo komponentų properčių surašymas į Solidworks
            //šį metodą reikia papildyti
            double tempDouble = 0;

            this.Data.Part.Description = this.descriptionTextBox.Text;
            this.Data.Part.Notes = this.notesTextBox.Text;

            this.Data.Part.OtherPart.Supplier = this.supplierTextBox.Text;
            this.Data.Part.OtherPart.VendorNo = this.vendorNoTextBox.Text;
            this.Data.Part.OtherPart.TechnicalParameters = this.technicalParametersTextBox.Text;

            if(double.TryParse(this.purchaseCostTextBox.Text, out tempDouble))
            {
                this.Data.Part.OtherPart.PurchaseCost = tempDouble;
            }
            if(double.TryParse(this.markupCostPurchaseTextBox.Text, out tempDouble))
            {
                this.Data.Part.Markup = tempDouble;
            }

            //image
            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Paveikslelio failas", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Paveikslelio failas"] = this.Data.GetImageLocation();

            //general
            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Description", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Description"] = this.Data.GetDescription();
            
            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Uzrasai", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Uzrasai"] = this.Data.GetNotes();
            
            //purchase
            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Tiekejas", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Tiekejas"] = this.Data.Part.OtherPart.Supplier;

            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Uzsakymo kodas", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Uzsakymo kodas"] = this.Data.Part.OtherPart.VendorNo;

            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Techniniai parametrai", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Techniniai parametrai"] = this.Data.Part.OtherPart.TechnicalParameters;

            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Pirkimo kaina", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Pirkimo kaina"] = this.Data.Part.OtherPart.PurchaseCost.ToString();

            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Musu dedamas antkainis", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Musu dedamas antkainis"] = this.Data.Part.Markup.ToString();
        }
        private void ReloadPart()
        {
            //Perkrauna tabus, pvz įrašius laikus. Perkrauna tabų text boxus
            propertyGrid1.SelectedObject = Data.Part;
            FillGeneralTab();

            if(this.Data.Part.PartType == PartType.Other)
            {
                FillManufacturingTab();
                FillStripsTab();
                FillPurchasesTab();
            }
            UpdateMainForm();
        }

        private void SaveAssembly()
        {
            //Assemblingo properčių surašymas į Solidworksą
            var time = new Time(this.childNodeAssemblyDurationHourTextBox.Text,
                                this.childNodeAssemblyDurationMinuteTextBox.Text);
            this.Data.Assembly.ChildNodeAssemblyDuration = time.HourTime;
            
            time = new Time(this.individualComponentAssemblyDurationHourTextBox.Text,
                                this.individualComponentAssemblyDurationMinuteTextBox.Text);
            this.Data.Assembly.IndividualComponentAssemblyDuration = time.HourTime;

            time = new Time(this.assemblyToParentNodeDurationHourTextBox.Text,
                                this.assemblyToParentNodeDurationMinuteTextBox.Text);
            this.Data.Assembly.AssemblyToParentNodeDuration = time.HourTime;


            this.Data.Assembly.CombinedAssemblyTime = this.Data.Assembly.ChildNodeAssemblyDuration +
                                                      this.Data.Assembly.IndividualComponentAssemblyDuration +
                                                      this.Data.Assembly.AssemblyToParentNodeDuration;


            time = new Time(this.plannedWeldingDurationHourTextBox.Text,
                                this.plannedWeldingDurationMinuteTextBox.Text);
            this.Data.Assembly.WeldingDuration = time.HourTime;

            double cost = 0;
            double.TryParse(this.otherCostsTextBox.Text, out cost);

            this.Data.Assembly.OtherCosts = cost;
            this.Data.Assembly.OtherCostsDescription = this.otherCostsDescriptionTextBox.Text;

            this.Data.Assembly.Description = this.descriptionTextBox.Text;
            this.Data.Assembly.Notes = this.notesTextBox.Text;

            this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Meta", (int)swCustomInfoType_e.swCustomInfoText, "");
            this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                "Meta"] = this.Data.Assembly.GetEncodedString();

        }
        private void ReloadAssembly()
        {
            //Perkrauna assemblingui skirtus textboxus
            propertyGrid1.SelectedObject = Data.Assembly;
            FillGeneralTab();
            FillWeldingTab();
            FillAssemblyTab();
            FillOtherCostsTab();
            UpdateMainForm();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this.Data.ComponentType == NodeType.Assembly)
            {
                ReloadAssembly();
            }
            else if (this.Data.ComponentType == NodeType.Part)
            {
                ReloadPart();
            }
        }

        private void numbersOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void integersOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int count = 0;
            if (!((char.IsDigit(e.KeyChar) && int.TryParse((sender as TextBox).Text + e.KeyChar, out count) && count >= 0) ||
                (e.KeyChar == '\b')))
            {
                e.Handled = true;
            }
        }

        private void takePictureButton_Click(object sender, EventArgs e)
        {
            //paspaudus šį mygtuką padaroma nuotrauka
            if (Data.ComponentType == NodeType.Assembly)
            {
                Data.Assembly.ImageLocation = Solidworks_control_tools.TakePictureOfItem(SwApp, Data.GetFileLocation(), (int)swDocumentTypes_e.swDocASSEMBLY, Data.GetSwModel(), Data.GetReferencedConfiguration(), this.ProjectDirectory + "Images\\", Data.GetComponentName() + "(" + Data.GetReferencedConfiguration() + ")");

                this.Data.GetSwModel().AddCustomInfo3(this.Data.GetReferencedConfiguration(),
                "Meta", (int)swCustomInfoType_e.swCustomInfoText, "");
                this.Data.GetSwModel().CustomInfo2[this.Data.GetReferencedConfiguration(),
                    "Meta"] = this.Data.Assembly.GetEncodedString();
            }
            else if (Data.ComponentType == NodeType.Part)
            {
                Data.Part.ImageLocation = Solidworks_control_tools.TakePictureOfItem(SwApp, Data.GetFileLocation(), (int)swDocumentTypes_e.swDocPART, Data.GetSwModel(), Data.GetReferencedConfiguration(), this.ProjectDirectory + "Images\\", Data.GetComponentName() + "(" + Data.GetReferencedConfiguration() + ")");
                Data.GetSwModel().AddCustomInfo3(Data.GetReferencedConfiguration(),
                    "Paveikslelio failas", (int)swCustomInfoType_e.swCustomInfoText, "");
                Data.GetSwModel().CustomInfo2[Data.GetReferencedConfiguration(),
                    "Paveikslelio failas"] = Data.Part.ImageLocation;
            }

            this.pictureBox1.BackgroundImage = Data.GetBigImage(this.WorkingDirectory);
        }

        private void openInSolidworksButton_Click(object sender, EventArgs e)
        {
            if (Data.ComponentType == NodeType.Part)
            {
                Solidworks_control_tools.OpenItem(this.SwApp, Data.GetFileLocation(), (int)swDocumentTypes_e.swDocPART, (string)Data.GetReferencedConfiguration());
            }
            else if (Data.ComponentType == NodeType.Assembly)
            {
                Solidworks_control_tools.OpenItem(this.SwApp, Data.GetFileLocation(), (int)swDocumentTypes_e.swDocASSEMBLY, (string)Data.GetReferencedConfiguration());
            }
        }
    }
}
