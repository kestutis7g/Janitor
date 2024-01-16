using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Janitor_V1.Models;

namespace Janitor_V1.Forms
{
    public partial class SheetProcessingOptions : Form
    {
        private Prices Prices { get; set; }
        public string Material { get; private set; }
        public string CuttingType { get; private set; }
        public string PunchingType { get; private set; }
        public string BendingType { get; private set; }
        public string Painting { get; private set; }
        public SheetProcessingOptions(string workingDirectory)
        {
            InitializeComponent();
            this.Prices = new Prices(workingDirectory);
            this.Prices.Refresh();

            var materials = Prices.GetDistinctProcessingColumnValues("Material");
            foreach (var material in materials)
            {
                materialComboBox.Items.Add(material);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (materialComboBox.SelectedItem == null ||
                cuttingTypeComboBox.SelectedItem == null ||
                punchingTypeComboBox.SelectedItem == null ||
                bendingTypeComboBox.SelectedItem == null
                )
            {
                MessageBox.Show("Not all required field are selected!");
            }

            Material = materialComboBox.SelectedItem?.ToString();
            CuttingType = cuttingTypeComboBox.SelectedItem?.ToString();
            PunchingType = punchingTypeComboBox.SelectedItem?.ToString();
            BendingType = bendingTypeComboBox.SelectedItem?.ToString();
            Painting = paintingTypeComboBox.SelectedItem?.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void materialComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var material = "";
            if(this.materialComboBox.SelectedItem != null)
            {
                material = this.materialComboBox.SelectedItem.ToString();
            }
            cuttingTypeComboBox.Items.Clear();
            punchingTypeComboBox.Items.Clear();
            bendingTypeComboBox.Items.Clear();
            paintingTypeComboBox.Items.Clear();

            var cuttingTypes = Prices.GetProcessingDistinctTypes("Pjovimas", material);
            foreach (var type in cuttingTypes)
            {
                cuttingTypeComboBox.Items.Add(type.FormatedString());
            }

            var punchingTypes = Prices.GetProcessingDistinctTypes("Pramušimas", material);
            foreach (var type in punchingTypes)
            {
                punchingTypeComboBox.Items.Add(type.FormatedString());
            }

            var bendingTypes = Prices.GetProcessingDistinctTypes("Lankstymas", material);
            foreach (var type in bendingTypes)
            {
                bendingTypeComboBox.Items.Add(type.FormatedString());
            }

            var paintingTypes = Prices.GetProcessingDistinctTypes("Dažymas", material);
            foreach (var type in paintingTypes)
            {
                paintingTypeComboBox.Items.Add(type.FormatedString());
            }
        }
    }
}
