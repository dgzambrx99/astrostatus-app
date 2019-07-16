namespace Astrostatus
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelStationNumber = new System.Windows.Forms.Label();
            this.textBoxStationNumber = new System.Windows.Forms.TextBox();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.labelJobNumber = new System.Windows.Forms.Label();
            this.textBoxJobNumber = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.backgroundWorkerSendData = new System.ComponentModel.BackgroundWorker();
            this.timerHideMessage = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSubmit = new System.Windows.Forms.TabPage();
            this.tabPageSubmitted = new System.Windows.Forms.TabPage();
            this.listViewSubmitted = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelActions.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageSubmit.SuspendLayout();
            this.tabPageSubmitted.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmployeeName.AutoCompleteCustomSource.AddRange(new string[] {
            "ROBERTO",
            "JUAN",
            "RAFAEL",
            "JAVIER",
            "JOSE"});
            this.textBoxEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxEmployeeName.Location = new System.Drawing.Point(99, 11);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(258, 20);
            this.textBoxEmployeeName.TabIndex = 1;
            this.textBoxEmployeeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEmployeeName_KeyDown);
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.labelEmployeeName.Location = new System.Drawing.Point(11, 14);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.labelEmployeeName.TabIndex = 0;
            this.labelEmployeeName.Text = "&Employee Name";
            // 
            // labelStationNumber
            // 
            this.labelStationNumber.AutoSize = true;
            this.labelStationNumber.ForeColor = System.Drawing.Color.Black;
            this.labelStationNumber.Location = new System.Drawing.Point(15, 38);
            this.labelStationNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStationNumber.Name = "labelStationNumber";
            this.labelStationNumber.Size = new System.Drawing.Size(80, 13);
            this.labelStationNumber.TabIndex = 2;
            this.labelStationNumber.Text = "S&tation Number";
            // 
            // textBoxStationNumber
            // 
            this.textBoxStationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStationNumber.AutoCompleteCustomSource.AddRange(new string[] {
            "INSPECTION"});
            this.textBoxStationNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxStationNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxStationNumber.Location = new System.Drawing.Point(99, 35);
            this.textBoxStationNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStationNumber.Name = "textBoxStationNumber";
            this.textBoxStationNumber.Size = new System.Drawing.Size(258, 20);
            this.textBoxStationNumber.TabIndex = 3;
            this.textBoxStationNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEmployeeName_KeyDown);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.ForeColor = System.Drawing.Color.Black;
            this.labelTemperature.Location = new System.Drawing.Point(28, 62);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(67, 13);
            this.labelTemperature.TabIndex = 4;
            this.labelTemperature.Text = "&Temperature";
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTemperature.AutoCompleteCustomSource.AddRange(new string[] {
            "IN",
            "OUT",
            "PULL TEST",
            "PROBLEM"});
            this.textBoxTemperature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxTemperature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTemperature.Location = new System.Drawing.Point(99, 59);
            this.textBoxTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(258, 20);
            this.textBoxTemperature.TabIndex = 5;
            this.textBoxTemperature.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEmployeeName_KeyDown);
            // 
            // labelJobNumber
            // 
            this.labelJobNumber.AutoSize = true;
            this.labelJobNumber.ForeColor = System.Drawing.Color.Black;
            this.labelJobNumber.Location = new System.Drawing.Point(31, 86);
            this.labelJobNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJobNumber.Name = "labelJobNumber";
            this.labelJobNumber.Size = new System.Drawing.Size(64, 13);
            this.labelJobNumber.TabIndex = 6;
            this.labelJobNumber.Text = "&Job Number";
            // 
            // textBoxJobNumber
            // 
            this.textBoxJobNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJobNumber.Location = new System.Drawing.Point(99, 83);
            this.textBoxJobNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJobNumber.Name = "textBoxJobNumber";
            this.textBoxJobNumber.Size = new System.Drawing.Size(258, 20);
            this.textBoxJobNumber.TabIndex = 7;
            this.textBoxJobNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEmployeeName_KeyDown);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Location = new System.Drawing.Point(312, 15);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(70, 27);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(238, 15);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(68, 27);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.SystemColors.Control;
            this.panelActions.Controls.Add(this.buttonSubmit);
            this.panelActions.Controls.Add(this.buttonClear);
            this.panelActions.Controls.Add(this.buttonSettings);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 203);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(394, 54);
            this.panelActions.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Location = new System.Drawing.Point(12, 15);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(68, 27);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "&Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // progressBarMain
            // 
            this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarMain.Location = new System.Drawing.Point(0, 176);
            this.progressBarMain.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(394, 8);
            this.progressBarMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarMain.TabIndex = 8;
            this.progressBarMain.Visible = false;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.Green;
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResult.ForeColor = System.Drawing.Color.White;
            this.panelResult.Location = new System.Drawing.Point(0, 184);
            this.panelResult.Margin = new System.Windows.Forms.Padding(2);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(394, 19);
            this.panelResult.TabIndex = 9;
            this.panelResult.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(10, 2);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(48, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Success";
            // 
            // backgroundWorkerSendData
            // 
            this.backgroundWorkerSendData.WorkerReportsProgress = true;
            this.backgroundWorkerSendData.WorkerSupportsCancellation = true;
            this.backgroundWorkerSendData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerSendData_DoWork);
            this.backgroundWorkerSendData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerSendData_ProgressChanged);
            this.backgroundWorkerSendData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerSendData_RunWorkerCompleted);
            // 
            // timerHideMessage
            // 
            this.timerHideMessage.Interval = 2000;
            this.timerHideMessage.Tick += new System.EventHandler(this.TimerHideMessage_Tick);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSubmit);
            this.tabControlMain.Controls.Add(this.tabPageSubmitted);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(9, 9);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(376, 158);
            this.tabControlMain.TabIndex = 10;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabPageSubmit
            // 
            this.tabPageSubmit.Controls.Add(this.labelEmployeeName);
            this.tabPageSubmit.Controls.Add(this.labelTemperature);
            this.tabPageSubmit.Controls.Add(this.textBoxTemperature);
            this.tabPageSubmit.Controls.Add(this.textBoxEmployeeName);
            this.tabPageSubmit.Controls.Add(this.textBoxJobNumber);
            this.tabPageSubmit.Controls.Add(this.labelStationNumber);
            this.tabPageSubmit.Controls.Add(this.textBoxStationNumber);
            this.tabPageSubmit.Controls.Add(this.labelJobNumber);
            this.tabPageSubmit.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubmit.Name = "tabPageSubmit";
            this.tabPageSubmit.Padding = new System.Windows.Forms.Padding(9);
            this.tabPageSubmit.Size = new System.Drawing.Size(368, 132);
            this.tabPageSubmit.TabIndex = 0;
            this.tabPageSubmit.Text = "Submit";
            this.tabPageSubmit.UseVisualStyleBackColor = true;
            // 
            // tabPageSubmitted
            // 
            this.tabPageSubmitted.Controls.Add(this.listViewSubmitted);
            this.tabPageSubmitted.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubmitted.Name = "tabPageSubmitted";
            this.tabPageSubmitted.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubmitted.Size = new System.Drawing.Size(358, 118);
            this.tabPageSubmitted.TabIndex = 1;
            this.tabPageSubmitted.Text = "Submitted";
            this.tabPageSubmitted.UseVisualStyleBackColor = true;
            // 
            // listViewSubmitted
            // 
            this.listViewSubmitted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSubmitted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSubmitted.HideSelection = false;
            this.listViewSubmitted.Location = new System.Drawing.Point(3, 3);
            this.listViewSubmitted.Name = "listViewSubmitted";
            this.listViewSubmitted.Size = new System.Drawing.Size(352, 112);
            this.listViewSubmitted.TabIndex = 0;
            this.listViewSubmitted.UseCompatibleStateImageBehavior = false;
            this.listViewSubmitted.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9);
            this.panel1.Size = new System.Drawing.Size(394, 176);
            this.panel1.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(394, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 282);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astrostatus - 2019";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panelActions.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSubmit.ResumeLayout(false);
            this.tabPageSubmit.PerformLayout();
            this.tabPageSubmitted.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelStationNumber;
        private System.Windows.Forms.TextBox textBoxStationNumber;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.Label labelJobNumber;
        private System.Windows.Forms.TextBox textBoxJobNumber;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelResult;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSendData;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Timer timerHideMessage;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSubmit;
        private System.Windows.Forms.TabPage tabPageSubmitted;
        private System.Windows.Forms.ListView listViewSubmitted;
        private System.Windows.Forms.Panel panel1;
    }
}

