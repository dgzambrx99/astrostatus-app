using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System;

namespace Astrostatus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeBinding();

            foreach (var item in this.tabPageSubmit.Controls.OfType<TextBox>())
                item.GotFocus += (s, v) => (s as TextBox).SelectAll();
        }

        private void InitializeBinding()
        {
            textBoxEmployeeName.DataBindings.Add(new Binding("ReadOnly", Program.Settings, "EmployeeNameReadOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            textBoxStationNumber.DataBindings.Add(new Binding("ReadOnly", Program.Settings, "StationNumberReadOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            textBoxTemperature.DataBindings.Add(new Binding("ReadOnly", Program.Settings, "TemperatureReadOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new Binding("TopMost", Program.Settings, "TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            Program.Settings.PropertyChanged += Settings_PropertyChanged;
            Settings_PropertyChanged(Program.Settings, new PropertyChangedEventArgs("All"));
        }

        private void Settings_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Program.Settings.EmployeeNameReadOnly)
                textBoxEmployeeName.Text = Program.Settings.EmployeeNameText;
            if (Program.Settings.StationNumberReadOnly)
                textBoxStationNumber.Text = Program.Settings.StationNumberText;
            if (Program.Settings.TemperatureReadOnly)
                textBoxTemperature.Text = Program.Settings.TemperatureText;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxEmployeeName.Focus();
            textBoxEmployeeName.Select();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            clearData();
            setFocus();
        }

        private bool validateControls()
        {
            var control = setFocus();

            panelResult.Visible = (control != null);

            if (control != null)
            {
                labelResult.Text = "Fields must not be empty!";
                panelResult.BackColor = ColorTranslator.FromHtml("#dc143c");
                timerHideMessage.Enabled = true;
            }

            return (control == null);
        }

        private void clearData()
        {
            textBoxJobNumber.Text = string.Empty;
        }

        private TextBox setFocus()
        {
            TextBox control = null;
            if (!textBoxEmployeeName.ReadOnly && string.IsNullOrEmpty(textBoxEmployeeName.Text.Trim()))
                control = textBoxEmployeeName;
            else if (!textBoxStationNumber.ReadOnly && string.IsNullOrEmpty(textBoxStationNumber.Text.Trim()))
                control = textBoxStationNumber;
            else if (!textBoxTemperature.ReadOnly && string.IsNullOrEmpty(textBoxTemperature.Text.Trim()))
                control = textBoxTemperature;
            else if (!textBoxJobNumber.ReadOnly && string.IsNullOrEmpty(textBoxJobNumber.Text.Trim()))
                control = textBoxJobNumber;

            tabControlMain.SelectedTab = tabPageSubmit;

            if (control != null)
            {
                control.Focus();
                control.Select();
            }
            return control;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerSendData.IsBusy)
            {
                backgroundWorkerSendData.CancelAsync();
                backgroundWorkerSendData = new BackgroundWorker();

                panelResult.Visible = false;
                progressBarMain.Visible = false;
                buttonSubmit.Text = "&Submit";
                buttonClear.Enabled = true;
                buttonSettings.Enabled = true;
                tabPageSubmit.Enabled = true;

                return;
            }

            if (validateControls())
            {
                panelResult.Visible = false;
                progressBarMain.Visible = true;
                buttonSubmit.Text = "&Cancel";
                buttonClear.Enabled = false;
                buttonSettings.Enabled = false;
                tabPageSubmit.Enabled = false;

                backgroundWorkerSendData.RunWorkerAsync();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (!textBoxEmployeeName.ReadOnly) textBoxEmployeeName.Text = string.Empty;
            if (!textBoxStationNumber.ReadOnly) textBoxStationNumber.Text = string.Empty;
            if (!textBoxTemperature.ReadOnly) textBoxTemperature.Text = string.Empty;
            textBoxJobNumber.Text = string.Empty;
            panelResult.Visible = false;
            FormMain_Shown(sender, e);
        }

        private void BackgroundWorkerSendData_DoWork(object sender, DoWorkEventArgs e)
        {
#if DEBUG
            Thread.Sleep(3000);
#endif
            var jobNumber = textBoxJobNumber.Text.Trim();
            var name = textBoxEmployeeName.Text.Trim();
            var stationNUmber = textBoxStationNumber.Text.Trim();
            var temperature = textBoxTemperature.Text.Trim();

            var urlAddress = $"{Program.Settings.Endpoint}?jobCardNo={jobNumber}&firstName={name}&stationNumber={stationNUmber}&temp={temperature}";
            var request = WebRequest.Create(urlAddress) as HttpWebRequest;
            //request.Timeout = 30000;
            var response = (HttpWebResponse)request.GetResponse();
            var responseText = string.Empty;
            var header = response.Headers;
            using (var reader = new StreamReader(response.GetResponseStream()))
                responseText = reader.ReadToEnd();

            e.Result = jobNumber;

#if DEBUG
            try
            {
                var logFile = Path.Combine(Program.appDir, "Astrostatus.log");
                File.AppendAllLines(logFile, new[] { $"{DateTime.Now.ToString()} - {urlAddress}" });
            }
            catch (Exception)
            {
            }
#endif
        }

        private void BackgroundWorkerSendData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void BackgroundWorkerSendData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                labelResult.Text = "Operation canceled";
                panelResult.BackColor = ColorTranslator.FromHtml("#dc143c");
                panelResult.ForeColor = Color.White;
            }
            else if (e.Error != null)
            {
                var message = e.Error.Message;
                if (MessageBox.Show(message, Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk) == DialogResult.Retry)
                {
                    buttonSubmit.PerformClick();
                    return;
                }

                labelResult.Text = "Operation error";
                panelResult.BackColor = ColorTranslator.FromHtml("#dc143c");
                panelResult.ForeColor = Color.White;
            }
            else
            {
                labelResult.Text = "Success";
                panelResult.BackColor = Color.Green;
                panelResult.ForeColor = Color.White;
                listViewSubmitted.Items.Add(e.Result.ToString());
                clearData();
            }

            panelResult.Visible = true;
            progressBarMain.Visible = false;
            buttonSubmit.Text = "&Submit";
            buttonClear.Enabled = true;
            buttonSettings.Enabled = true;
            tabPageSubmit.Enabled = true;

            timerHideMessage.Enabled = true;

            setFocus();
        }

        private void TextBoxEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSubmit.PerformClick();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            var child = new FormSettings();
            child.ShowDialog();
            clearData();
            setFocus();
        }

        private void ButtonLogs_Click(object sender, EventArgs e)
        {
            try
            {
                var logFile = Path.Combine(Program.appDir, "Astrostatus.log");
                if (!File.Exists(logFile)) File.Create(logFile);
                System.Diagnostics.Process.Start(logFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            Program.ActiveFormType = this.GetType();
            this.Opacity = 1;
            setFocus();
        }

        private void TimerHideMessage_Tick(object sender, EventArgs e)
        {
            panelResult.Visible = false;
            timerHideMessage.Enabled = false;
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageSubmit)
                setFocus();
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = Program.Settings.Opacity;
            }
            catch (Exception)
            {
            }
        }
    }
}