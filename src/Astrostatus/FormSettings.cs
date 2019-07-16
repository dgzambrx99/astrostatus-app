using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrostatus
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            textBoxEmployeeName.DataBindings.Add(new Binding("Text", Program.Settings, "EmployeeNameText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            checkBoxEmployeeName.DataBindings.Add(new Binding("Checked", Program.Settings, "EmployeeNameReadOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            textBoxStationNumber.DataBindings.Add(new Binding("Text", Program.Settings, "StationNumberText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            checkBoxStationNumber.DataBindings.Add(new Binding("Checked", Program.Settings, "StationNumberReadOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            textBoxTemperature.DataBindings.Add(new Binding("Text", Program.Settings, "TemperatureText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            checkBoxTemperature.DataBindings.Add(new Binding("Checked", Program.Settings, "TemperatureReadOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            checkBoxTopMost.DataBindings.Add(new Binding("Checked", Program.Settings, "TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new Binding("TopMost", Program.Settings, "TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            trackBarOpacity.DataBindings.Add(new Binding("Value", Program.Settings, "OpacityValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            textBoxEndpoint.DataBindings.Add(new Binding("Text", Program.Settings, "Endpoint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
        }

        private void CheckBoxEmployeeName_CheckedChanged(object sender, EventArgs e)
        {
            var control = (CheckBox)sender;
            var target = control.Tag.ToString();
            var textBox = this.groupBoxUIElements.Controls.OfType<TextBox>().FirstOrDefault(m => m.Name == target);
            if (textBox != null)
            {
                textBox.ReadOnly = !control.Checked;
                //if (!control.Checked) textBox.Text = string.Empty;
            }
        }

        private void TrackBarOpacity_ValueChanged(object sender, EventArgs e)
        {
            labelOpacityValue.Text = $"{trackBarOpacity.Value}%";
            Program.Settings.Opacity = trackBarOpacity.Value / 100.00;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Program.Settings.Save();
            DialogResult = DialogResult.OK;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonTestConnection_Click(object sender, EventArgs e)
        {
        }

        private void FormSettings_Activated(object sender, EventArgs e)
        {
            Program.ActiveFormType = this.GetType();
        }
    }
}