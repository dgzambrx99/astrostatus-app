namespace Astrostatus
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelOpacityValue = new System.Windows.Forms.Label();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.groupBoxUIElements = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxStationNumber = new System.Windows.Forms.TextBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.checkBoxEmployeeName = new System.Windows.Forms.CheckBox();
            this.checkBoxTemperature = new System.Windows.Forms.CheckBox();
            this.checkBoxStationNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxEndpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.backgroundWorkerTest = new System.ComponentModel.BackgroundWorker();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.groupBoxUIElements.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(228, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(68, 27);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(302, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 27);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 239);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelOpacityValue);
            this.tabPage1.Controls.Add(this.labelOpacity);
            this.tabPage1.Controls.Add(this.trackBarOpacity);
            this.tabPage1.Controls.Add(this.groupBoxUIElements);
            this.tabPage1.Controls.Add(this.checkBoxTopMost);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(9);
            this.tabPage1.Size = new System.Drawing.Size(358, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UIX";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelOpacityValue
            // 
            this.labelOpacityValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpacityValue.AutoSize = true;
            this.labelOpacityValue.ForeColor = System.Drawing.Color.Black;
            this.labelOpacityValue.Location = new System.Drawing.Point(313, 147);
            this.labelOpacityValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpacityValue.Name = "labelOpacityValue";
            this.labelOpacityValue.Size = new System.Drawing.Size(33, 13);
            this.labelOpacityValue.TabIndex = 4;
            this.labelOpacityValue.Text = "100%";
            this.labelOpacityValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.ForeColor = System.Drawing.Color.Black;
            this.labelOpacity.Location = new System.Drawing.Point(9, 147);
            this.labelOpacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(46, 13);
            this.labelOpacity.TabIndex = 4;
            this.labelOpacity.Text = "&Opacity:";
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarOpacity.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarOpacity.Location = new System.Drawing.Point(3, 163);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 10;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(352, 45);
            this.trackBarOpacity.TabIndex = 3;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOpacity.Value = 100;
            this.trackBarOpacity.ValueChanged += new System.EventHandler(this.TrackBarOpacity_ValueChanged);
            // 
            // groupBoxUIElements
            // 
            this.groupBoxUIElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUIElements.Controls.Add(this.textBoxEmployeeName);
            this.groupBoxUIElements.Controls.Add(this.textBoxStationNumber);
            this.groupBoxUIElements.Controls.Add(this.textBoxTemperature);
            this.groupBoxUIElements.Controls.Add(this.checkBoxEmployeeName);
            this.groupBoxUIElements.Controls.Add(this.checkBoxTemperature);
            this.groupBoxUIElements.Controls.Add(this.checkBoxStationNumber);
            this.groupBoxUIElements.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUIElements.Name = "groupBoxUIElements";
            this.groupBoxUIElements.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxUIElements.Size = new System.Drawing.Size(334, 103);
            this.groupBoxUIElements.TabIndex = 0;
            this.groupBoxUIElements.TabStop = false;
            this.groupBoxUIElements.Text = "Immutable fields";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(114, 20);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ReadOnly = true;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(209, 20);
            this.textBoxEmployeeName.TabIndex = 6;
            // 
            // textBoxStationNumber
            // 
            this.textBoxStationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStationNumber.Location = new System.Drawing.Point(114, 44);
            this.textBoxStationNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStationNumber.Name = "textBoxStationNumber";
            this.textBoxStationNumber.ReadOnly = true;
            this.textBoxStationNumber.Size = new System.Drawing.Size(209, 20);
            this.textBoxStationNumber.TabIndex = 7;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTemperature.Location = new System.Drawing.Point(114, 68);
            this.textBoxTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ReadOnly = true;
            this.textBoxTemperature.Size = new System.Drawing.Size(209, 20);
            this.textBoxTemperature.TabIndex = 8;
            // 
            // checkBoxEmployeeName
            // 
            this.checkBoxEmployeeName.AutoSize = true;
            this.checkBoxEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.checkBoxEmployeeName.Location = new System.Drawing.Point(11, 22);
            this.checkBoxEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkBoxEmployeeName.Name = "checkBoxEmployeeName";
            this.checkBoxEmployeeName.Size = new System.Drawing.Size(103, 17);
            this.checkBoxEmployeeName.TabIndex = 0;
            this.checkBoxEmployeeName.Tag = "textBoxEmployeeName";
            this.checkBoxEmployeeName.Text = "&Employee Name";
            this.checkBoxEmployeeName.CheckedChanged += new System.EventHandler(this.CheckBoxEmployeeName_CheckedChanged);
            // 
            // checkBoxTemperature
            // 
            this.checkBoxTemperature.AutoSize = true;
            this.checkBoxTemperature.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTemperature.Location = new System.Drawing.Point(11, 70);
            this.checkBoxTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkBoxTemperature.Name = "checkBoxTemperature";
            this.checkBoxTemperature.Size = new System.Drawing.Size(86, 17);
            this.checkBoxTemperature.TabIndex = 2;
            this.checkBoxTemperature.Tag = "textBoxTemperature";
            this.checkBoxTemperature.Text = "&Temperature";
            this.checkBoxTemperature.CheckedChanged += new System.EventHandler(this.CheckBoxEmployeeName_CheckedChanged);
            // 
            // checkBoxStationNumber
            // 
            this.checkBoxStationNumber.AutoSize = true;
            this.checkBoxStationNumber.ForeColor = System.Drawing.Color.Black;
            this.checkBoxStationNumber.Location = new System.Drawing.Point(11, 46);
            this.checkBoxStationNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkBoxStationNumber.Name = "checkBoxStationNumber";
            this.checkBoxStationNumber.Size = new System.Drawing.Size(99, 17);
            this.checkBoxStationNumber.TabIndex = 1;
            this.checkBoxStationNumber.Tag = "textBoxStationNumber";
            this.checkBoxStationNumber.Text = "S&tation Number";
            this.checkBoxStationNumber.CheckedChanged += new System.EventHandler(this.CheckBoxEmployeeName_CheckedChanged);
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Location = new System.Drawing.Point(12, 121);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(134, 17);
            this.checkBoxTopMost.TabIndex = 1;
            this.checkBoxTopMost.Text = "&Top most main window";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxEndpoint);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonTestConnection);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(9);
            this.tabPage2.Size = new System.Drawing.Size(358, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxEndpoint
            // 
            this.textBoxEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEndpoint.Location = new System.Drawing.Point(9, 24);
            this.textBoxEndpoint.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEndpoint.Name = "textBoxEndpoint";
            this.textBoxEndpoint.Size = new System.Drawing.Size(341, 20);
            this.textBoxEndpoint.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Endpoint:";
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestConnection.Location = new System.Drawing.Point(280, 48);
            this.buttonTestConnection.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(70, 27);
            this.buttonTestConnection.TabIndex = 4;
            this.buttonTestConnection.Text = "&Test";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Visible = false;
            this.buttonTestConnection.Click += new System.EventHandler(this.ButtonTestConnection_Click);
            // 
            // backgroundWorkerTest
            // 
            this.backgroundWorkerTest.WorkerReportsProgress = true;
            this.backgroundWorkerTest.WorkerSupportsCancellation = true;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.SystemColors.Control;
            this.panelActions.Controls.Add(this.buttonSave);
            this.panelActions.Controls.Add(this.buttonCancel);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 257);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(384, 54);
            this.panelActions.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(9);
            this.panelMain.Size = new System.Drawing.Size(384, 257);
            this.panelMain.TabIndex = 3;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelActions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Activated += new System.EventHandler(this.FormSettings_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.groupBoxUIElements.ResumeLayout(false);
            this.groupBoxUIElements.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxEmployeeName;
        private System.Windows.Forms.CheckBox checkBoxStationNumber;
        private System.Windows.Forms.CheckBox checkBoxTemperature;
        private System.Windows.Forms.GroupBox groupBoxUIElements;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.TextBox textBoxEndpoint;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTest;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxStationNumber;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.Label labelOpacityValue;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelMain;
    }
}