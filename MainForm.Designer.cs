namespace IrgaMonitor
{
    partial class MainForm
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
				if (ThreadStatus) trd.Join();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.SteamPressure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimeField = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SteamTemp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SteamCharge = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ThermalCap = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PressDif = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.StartStop = new System.Windows.Forms.Button();
            this.TrendFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CRCLight = new System.Windows.Forms.Label();
            this.SULight = new System.Windows.Forms.Label();
            this.ErrorLight = new System.Windows.Forms.Label();
            this.Version_text = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RefreshInterval = new System.Windows.Forms.ComboBox();
            this.MeasureChannel = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.DevNum = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.GetFilename = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.MonitorTab = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevNum)).BeginInit();
            this.MonitorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Давление пара:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SteamPressure
            // 
            this.SteamPressure.BackColor = System.Drawing.SystemColors.Control;
            this.SteamPressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SteamPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SteamPressure.Location = new System.Drawing.Point(124, 35);
            this.SteamPressure.Name = "SteamPressure";
            this.SteamPressure.Size = new System.Drawing.Size(120, 22);
            this.SteamPressure.TabIndex = 1;
            this.SteamPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "кгс/см²";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата и время:";
            // 
            // DateTimeField
            // 
            this.DateTimeField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateTimeField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimeField.Location = new System.Drawing.Point(124, 9);
            this.DateTimeField.Name = "DateTimeField";
            this.DateTimeField.Size = new System.Drawing.Size(178, 22);
            this.DateTimeField.TabIndex = 5;
            this.DateTimeField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Температура пара:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SteamTemp
            // 
            this.SteamTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SteamTemp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SteamTemp.Location = new System.Drawing.Point(124, 61);
            this.SteamTemp.Name = "SteamTemp";
            this.SteamTemp.Size = new System.Drawing.Size(120, 22);
            this.SteamTemp.TabIndex = 7;
            this.SteamTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "°C";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Расход пара:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SteamCharge
            // 
            this.SteamCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SteamCharge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SteamCharge.Location = new System.Drawing.Point(124, 87);
            this.SteamCharge.Name = "SteamCharge";
            this.SteamCharge.Size = new System.Drawing.Size(120, 22);
            this.SteamCharge.TabIndex = 10;
            this.SteamCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "т/ч";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Тепловая мощность:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThermalCap
            // 
            this.ThermalCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ThermalCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThermalCap.ForeColor = System.Drawing.Color.Blue;
            this.ThermalCap.Location = new System.Drawing.Point(124, 112);
            this.ThermalCap.Name = "ThermalCap";
            this.ThermalCap.Size = new System.Drawing.Size(120, 22);
            this.ThermalCap.TabIndex = 16;
            this.ThermalCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "гкал/ч";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Перепад давления:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PressDif
            // 
            this.PressDif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PressDif.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PressDif.Location = new System.Drawing.Point(124, 138);
            this.PressDif.Name = "PressDif";
            this.PressDif.Size = new System.Drawing.Size(120, 22);
            this.PressDif.TabIndex = 19;
            this.PressDif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "кгс/см²";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartStop
            // 
            this.StartStop.Enabled = false;
            this.StartStop.Location = new System.Drawing.Point(116, 206);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(76, 24);
            this.StartStop.TabIndex = 21;
            this.StartStop.Text = "Пуск";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // TrendFileDialog
            // 
            this.TrendFileDialog.DefaultExt = "list";
            this.TrendFileDialog.Filter = "Файл данных|MBMonData.list";
            this.TrendFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.TrendFileDialog_FileOk);
            // 
            // CRCLight
            // 
            this.CRCLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CRCLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CRCLight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CRCLight.Location = new System.Drawing.Point(216, 169);
            this.CRCLight.Name = "CRCLight";
            this.CRCLight.Size = new System.Drawing.Size(40, 20);
            this.CRCLight.TabIndex = 34;
            this.CRCLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SULight
            // 
            this.SULight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SULight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SULight.Location = new System.Drawing.Point(124, 169);
            this.SULight.Name = "SULight";
            this.SULight.Size = new System.Drawing.Size(40, 20);
            this.SULight.TabIndex = 35;
            this.SULight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLight
            // 
            this.ErrorLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ErrorLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLight.Location = new System.Drawing.Point(170, 169);
            this.ErrorLight.Name = "ErrorLight";
            this.ErrorLight.Size = new System.Drawing.Size(40, 20);
            this.ErrorLight.TabIndex = 36;
            this.ErrorLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Version_text
            // 
            this.Version_text.AutoSize = true;
            this.Version_text.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Version_text.Location = new System.Drawing.Point(6, 222);
            this.Version_text.Name = "Version_text";
            this.Version_text.Size = new System.Drawing.Size(47, 13);
            this.Version_text.TabIndex = 37;
            this.Version_text.Text = "Версия:";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Version.Location = new System.Drawing.Point(49, 222);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(0, 13);
            this.Version.TabIndex = 38;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SettingsTab);
            this.TabControl.Controls.Add(this.MonitorTab);
            this.TabControl.ItemSize = new System.Drawing.Size(80, 18);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(316, 264);
            this.TabControl.TabIndex = 39;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.label18);
            this.SettingsTab.Controls.Add(this.Version);
            this.SettingsTab.Controls.Add(this.label17);
            this.SettingsTab.Controls.Add(this.Version_text);
            this.SettingsTab.Controls.Add(this.RefreshInterval);
            this.SettingsTab.Controls.Add(this.MeasureChannel);
            this.SettingsTab.Controls.Add(this.label16);
            this.SettingsTab.Controls.Add(this.DevNum);
            this.SettingsTab.Controls.Add(this.label15);
            this.SettingsTab.Controls.Add(this.GetFilename);
            this.SettingsTab.Controls.Add(this.label13);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(308, 238);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Параметры";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(188, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "сек";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Интервал обновления:";
            // 
            // RefreshInterval
            // 
            this.RefreshInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RefreshInterval.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20"});
            this.RefreshInterval.Location = new System.Drawing.Point(131, 90);
            this.RefreshInterval.MaxDropDownItems = 5;
            this.RefreshInterval.MaxLength = 2;
            this.RefreshInterval.Name = "RefreshInterval";
            this.RefreshInterval.Size = new System.Drawing.Size(51, 21);
            this.RefreshInterval.TabIndex = 40;
            // 
            // MeasureChannel
            // 
            this.MeasureChannel.BackColor = System.Drawing.SystemColors.Window;
            this.MeasureChannel.Location = new System.Drawing.Point(131, 64);
            this.MeasureChannel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MeasureChannel.Name = "MeasureChannel";
            this.MeasureChannel.ReadOnly = true;
            this.MeasureChannel.Size = new System.Drawing.Size(51, 20);
            this.MeasureChannel.TabIndex = 38;
            this.MeasureChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Канал измерения:";
            // 
            // DevNum
            // 
            this.DevNum.BackColor = System.Drawing.SystemColors.Window;
            this.DevNum.Location = new System.Drawing.Point(131, 38);
            this.DevNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DevNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DevNum.Name = "DevNum";
            this.DevNum.ReadOnly = true;
            this.DevNum.Size = new System.Drawing.Size(51, 20);
            this.DevNum.TabIndex = 36;
            this.DevNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DevNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Номер канала:";
            // 
            // GetFilename
            // 
            this.GetFilename.AutoEllipsis = true;
            this.GetFilename.Location = new System.Drawing.Point(131, 6);
            this.GetFilename.Name = "GetFilename";
            this.GetFilename.Size = new System.Drawing.Size(174, 24);
            this.GetFilename.TabIndex = 34;
            this.GetFilename.Text = "Нажмите для выбора файла";
            this.GetFilename.UseVisualStyleBackColor = true;
            this.GetFilename.TextChanged += new System.EventHandler(this.GetFilename_TextChanged);
            this.GetFilename.Click += new System.EventHandler(this.GetFilename_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Файл значений:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonitorTab
            // 
            this.MonitorTab.Controls.Add(this.label1);
            this.MonitorTab.Controls.Add(this.label2);
            this.MonitorTab.Controls.Add(this.SteamPressure);
            this.MonitorTab.Controls.Add(this.ErrorLight);
            this.MonitorTab.Controls.Add(this.label3);
            this.MonitorTab.Controls.Add(this.SULight);
            this.MonitorTab.Controls.Add(this.DateTimeField);
            this.MonitorTab.Controls.Add(this.CRCLight);
            this.MonitorTab.Controls.Add(this.label4);
            this.MonitorTab.Controls.Add(this.StartStop);
            this.MonitorTab.Controls.Add(this.SteamTemp);
            this.MonitorTab.Controls.Add(this.label14);
            this.MonitorTab.Controls.Add(this.label5);
            this.MonitorTab.Controls.Add(this.PressDif);
            this.MonitorTab.Controls.Add(this.label6);
            this.MonitorTab.Controls.Add(this.label11);
            this.MonitorTab.Controls.Add(this.SteamCharge);
            this.MonitorTab.Controls.Add(this.label12);
            this.MonitorTab.Controls.Add(this.label7);
            this.MonitorTab.Controls.Add(this.ThermalCap);
            this.MonitorTab.Controls.Add(this.label10);
            this.MonitorTab.Location = new System.Drawing.Point(4, 22);
            this.MonitorTab.Name = "MonitorTab";
            this.MonitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonitorTab.Size = new System.Drawing.Size(308, 238);
            this.MonitorTab.TabIndex = 1;
            this.MonitorTab.Text = "Мониторинг";
            this.MonitorTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 285);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ИРГА-2 - Монитор значений";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevNum)).EndInit();
            this.MonitorTab.ResumeLayout(false);
            this.MonitorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button StartStop;
		private System.Windows.Forms.OpenFileDialog TrendFileDialog;
		private System.Windows.Forms.Label SteamPressure;
		private System.Windows.Forms.Label DateTimeField;
		private System.Windows.Forms.Label SteamTemp;
		private System.Windows.Forms.Label SteamCharge;
		private System.Windows.Forms.Label ThermalCap;
        private System.Windows.Forms.Label PressDif;
		private System.Windows.Forms.Label CRCLight;
		private System.Windows.Forms.Label SULight;
        private System.Windows.Forms.Label ErrorLight;
        private System.Windows.Forms.Label Version_text;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox RefreshInterval;
        private System.Windows.Forms.NumericUpDown MeasureChannel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown DevNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button GetFilename;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage MonitorTab;
   }
}

