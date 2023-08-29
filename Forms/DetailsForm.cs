using Janitor_V1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Janitor_V1
{
    public partial class DetailsForm : Form
    {
        public string WorkingDirectory { set; get; }
        public Node Data { set; get; }
        public List<Node> List { set; get; }
        public bool ShowControls { set; get; }
        private Action UpdateMainForm { set; get; }
        int index;

        public DetailsForm(string workingDirectory, Node data, List<Node> list, Action updateMainForm, bool showControls)
        {
            InitializeComponent();

            this.WorkingDirectory = workingDirectory;
            this.Data = data;
            this.List = list;
            this.ShowControls = showControls;
            this.UpdateMainForm = updateMainForm;

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
                    ResizeTabControl("otherpart");
                }

                ReloadPart();
            }
            this.Text = Data.GetComponentName() + " | " + Data.GetReferencedConfiguration();
            this.pictureBox1.BackgroundImage = Data.GetBigImage(this.WorkingDirectory);
        }

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            Data = List[this.index + 1];
            InitializeData();
            UpdateMainForm();
        }

        private void previousButton_Click(object sender, System.EventArgs e)
        {
            Data = List[index - 1];
            InitializeData();
            UpdateMainForm();
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

        /// <summary>
        /// Remove tabControl tabs according to node type
        /// </summary>
        /// <param name="formType"></param>
        private void RemoveTabs(string formType)
        {
            if (formType == "part")
            {
                this.tabControl1.TabPages.RemoveByKey("weldingTabPage");
                this.tabControl1.TabPages.RemoveByKey("assemblyTabPage");
                this.tabControl1.TabPages.RemoveByKey("otherCostsTabPage");
                this.tabControl1.TabPages.RemoveByKey("manufacturingTabPage");
                this.tabControl1.TabPages.RemoveByKey("stripsTabPage");
                this.tabControl1.TabPages.RemoveByKey("purchasesTabPage");
            }
            else if (formType == "otherpart")
            {
                this.tabControl1.TabPages.RemoveByKey("weldingTabPage");
                this.tabControl1.TabPages.RemoveByKey("assemblyTabPage");
                this.tabControl1.TabPages.RemoveByKey("otherCostsTabPage");
            }
            else if(formType == "assembly")
            {
                this.tabControl1.TabPages.RemoveByKey("manufacturingTabPage");
                this.tabControl1.TabPages.RemoveByKey("stripsTabPage");
                this.tabControl1.TabPages.RemoveByKey("purchasesTabPage");
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

        private void FillManufacturingTab()
        {
            this.materialWeightTextBox.Text =
                Data.Part.Weight.ToString();

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

            //this.programmingCostTextBox.Text =
            //    Data.swModel.CustomInfo2[Data.GetReferencedConfiguration(), "Programavimo trukme_val"];

            //this.programmingDurationTextBox.Text =
            //    Data.swModel.CustomInfo2[Data.GetReferencedConfiguration(), "Pagaminimo trukme_min"];

            //this.materialCostTextBox.Text =
            //    Data.swModel.CustomInfo2[Data.GetReferencedConfiguration(), "Zaliavos kaina"];

            //this.amountOfThisPartTextBox.Text =
            //    Data.swModel.CustomInfo2[Data.GetReferencedConfiguration(), "Detaliu skaicius"];

            //this.manufacturingCostTextBox.Text =
            //    Data.swModel.CustomInfo2[Data.GetReferencedConfiguration(), "Gamybos valandos kaina_EUR"];


            var calculatedPartPrice = ((Data.Part.Weight * Data.Part.OtherPart.MaterialCost) + 
                (Data.Part.OtherPart.ProgrammingDuration * Data.Part.OtherPart.ProgrammingCost / Data.Part.OtherPart.AmountOfThisPart) + 
                (Data.Part.OtherPart.SinglePieceManufacturingDuration / 60 * Data.Part.OtherPart.ManufacturingCost));



        }
        private void FillStripsTab()
        {
            //uzpildyti juostos duomenis
        }
        private void FillPurchasesTab()
        {
            //uzpildyti pirktu daliu duomenis
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
            this.combinedAssemblyTimeMinuteTextBox.Text = time.Hour.ToString();
        }
        private void FillOtherCostsTab()
        {
            //uzpildyti kitu kastu duomenis
            this.otherCostsTextBox.Text = this.Data.Assembly.OtherCosts.ToString();
            this.otherCostsDescriptionTextBox.Text = this.Data.Assembly.OtherCostsDescription;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(this.Data.ComponentType == NodeType.Assembly)
            {
                SaveAssembly();

                ReloadAssembly();
            }
            else if(this.Data.ComponentType == NodeType.Part)
            {
                SavePart();

                ReloadPart();
            }
        }

        private void SavePart() 
        {
            //fill data
        }
        private void ReloadPart()
        {
            propertyGrid1.SelectedObject = Data.Part;
            FillManufacturingTab();
            FillStripsTab();
            FillPurchasesTab();
            UpdateMainForm();
        }

        private void SaveAssembly()
        {
            var time = new Time(this.childNodeAssemblyDurationHourTextBox.Text,
                                this.childNodeAssemblyDurationMinuteTextBox.Text);
            this.Data.Assembly.ChildNodeAssemblyDuration = time.HourTime;
            
            time = new Time(this.individualComponentAssemblyDurationHourTextBox.Text,
                                this.individualComponentAssemblyDurationMinuteTextBox.Text);
            this.Data.Assembly.IndividualComponentAssemblyDuration = time.HourTime;

            time = new Time(this.assemblyToParentNodeDurationHourTextBox.Text,
                                this.assemblyToParentNodeDurationMinuteTextBox.Text);
            this.Data.Assembly.AssemblyToParentNodeDuration = time.HourTime;

            time = new Time(this.combinedAssemblyTimeHourTextBox.Text,
                                this.combinedAssemblyTimeMinuteTextBox.Text);
            this.Data.Assembly.CombinedAssemblyTime = time.HourTime;
            
            time = new Time(this.plannedWeldingDurationHourTextBox.Text,
                                this.plannedWeldingDurationMinuteTextBox.Text);
            this.Data.Assembly.WeldingDuration = time.HourTime;

            double cost = 0;
            if(!double.TryParse(this.otherCostsTextBox.Text, out cost))
            {
                MessageBox.Show("Nepavyko įrasyti kitu kastu kainos!");
            }
            this.Data.Assembly.OtherCosts = cost;
            this.Data.Assembly.OtherCostsDescription = this.otherCostsDescriptionTextBox.Text;
        }
        private void ReloadAssembly()
        {
            propertyGrid1.SelectedObject = Data.Assembly;
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
            if ((e.KeyChar == '.'))
            {
                e.KeyChar = ',';
            }

            if (!((char.IsDigit(e.KeyChar) && double.TryParse((sender as TextBox).Text + e.KeyChar, out count) && count >= 0) ||
                (e.KeyChar == '\b') ||
                (e.KeyChar == ',')))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
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
    }
}
