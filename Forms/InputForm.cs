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
using static OfficeOpenXml.ExcelErrorValue;

namespace Janitor_V1.Forms
{
    public partial class InputForm : Form
    {
        public double Value { get; private set; }
        public InputForm()
        {
            Value = 0;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double value = 1;
            if(!double.TryParse(valueTextBox.Text, out value))
            {
                MessageBox.Show("Įvyko klaida skaičiaus konvertavime!");
                return;
            }
            Value = value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void numbersOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //eventas, kuris užtikrina, kad Textboxe įrašomas realus skaičius
            double count = 0;

            if (!((char.IsDigit(e.KeyChar) && double.TryParse((sender as TextBox).Text + e.KeyChar, out count) && count >= 0) ||
                (e.KeyChar == '\b') ||
                (e.KeyChar == '.') ||
                (e.KeyChar == ',')))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1) ||
                (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
