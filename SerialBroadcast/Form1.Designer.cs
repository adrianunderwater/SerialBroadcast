namespace SerialBroadcast
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxSerialSettings = new System.Windows.Forms.GroupBox();
            this.listBoxSerialPorts = new System.Windows.Forms.ListBox();
            this.label55 = new System.Windows.Forms.Label();
            this.labelSerialStatus = new System.Windows.Forms.Label();
            this.comboBoxSerialBaudRate = new System.Windows.Forms.ComboBox();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSerialSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBoxSerialSettings);
            this.tabPage1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSerialSettings
            // 
            this.groupBoxSerialSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSerialSettings.BackColor = System.Drawing.Color.Salmon;
            this.groupBoxSerialSettings.Controls.Add(this.listBoxSerialPorts);
            this.groupBoxSerialSettings.Controls.Add(this.label55);
            this.groupBoxSerialSettings.Controls.Add(this.labelSerialStatus);
            this.groupBoxSerialSettings.Controls.Add(this.comboBoxSerialBaudRate);
            this.groupBoxSerialSettings.Controls.Add(this.labelSerialPort);
            this.groupBoxSerialSettings.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSerialSettings.Location = new System.Drawing.Point(6, 7);
            this.groupBoxSerialSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSerialSettings.Name = "groupBoxSerialSettings";
            this.groupBoxSerialSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSerialSettings.Size = new System.Drawing.Size(200, 313);
            this.groupBoxSerialSettings.TabIndex = 2;
            this.groupBoxSerialSettings.TabStop = false;
            this.groupBoxSerialSettings.Text = "Serial Communications";
            // 
            // listBoxSerialPorts
            // 
            this.listBoxSerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSerialPorts.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSerialPorts.FormattingEnabled = true;
            this.listBoxSerialPorts.ItemHeight = 11;
            this.listBoxSerialPorts.Location = new System.Drawing.Point(11, 47);
            this.listBoxSerialPorts.Name = "listBoxSerialPorts";
            this.listBoxSerialPorts.ScrollAlwaysVisible = true;
            this.listBoxSerialPorts.Size = new System.Drawing.Size(183, 202);
            this.listBoxSerialPorts.Sorted = true;
            this.listBoxSerialPorts.TabIndex = 11;
            this.listBoxSerialPorts.SelectedIndexChanged += new System.EventHandler(this.listBoxSerialPorts_SelectedIndexChanged);
            // 
            // label55
            // 
            this.label55.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(7, 261);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(68, 11);
            this.label55.TabIndex = 7;
            this.label55.Text = "Baud rate";
            // 
            // labelSerialStatus
            // 
            this.labelSerialStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSerialStatus.AutoSize = true;
            this.labelSerialStatus.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialStatus.Location = new System.Drawing.Point(6, 289);
            this.labelSerialStatus.Name = "labelSerialStatus";
            this.labelSerialStatus.Size = new System.Drawing.Size(138, 11);
            this.labelSerialStatus.TabIndex = 6;
            this.labelSerialStatus.Text = "No serial port open";
            // 
            // comboBoxSerialBaudRate
            // 
            this.comboBoxSerialBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSerialBaudRate.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSerialBaudRate.FormattingEnabled = true;
            this.comboBoxSerialBaudRate.Items.AddRange(new object[] {
            "1200",
            "9600",
            "38400",
            "115200"});
            this.comboBoxSerialBaudRate.Location = new System.Drawing.Point(109, 259);
            this.comboBoxSerialBaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSerialBaudRate.Name = "comboBoxSerialBaudRate";
            this.comboBoxSerialBaudRate.Size = new System.Drawing.Size(85, 19);
            this.comboBoxSerialBaudRate.TabIndex = 5;
            this.comboBoxSerialBaudRate.Text = "38400";
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialPort.Location = new System.Drawing.Point(6, 22);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(82, 11);
            this.labelSerialPort.TabIndex = 1;
            this.labelSerialPort.Text = "Serial Port";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(213, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(484, 313);
            this.textBox1.TabIndex = 3;
            this.textBox1.WordWrap = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 331);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 15);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "UDP Broadcast";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(213, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 401);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Serial Broadcast";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxSerialSettings.ResumeLayout(false);
            this.groupBoxSerialSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxSerialSettings;
        private System.Windows.Forms.ListBox listBoxSerialPorts;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label labelSerialStatus;
        private System.Windows.Forms.ComboBox comboBoxSerialBaudRate;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}

