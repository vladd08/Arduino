namespace Proiect_Sincretic
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
            this.components = new System.ComponentModel.Container();
            this.turnOnBttn = new System.Windows.Forms.Button();
            this.uartChannel = new System.IO.Ports.SerialPort(this.components);
            this.turnOffBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.connectBttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discBttn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startOptions = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.startOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnOnBttn
            // 
            this.turnOnBttn.Enabled = false;
            this.turnOnBttn.Location = new System.Drawing.Point(6, 34);
            this.turnOnBttn.Name = "turnOnBttn";
            this.turnOnBttn.Size = new System.Drawing.Size(92, 44);
            this.turnOnBttn.TabIndex = 0;
            this.turnOnBttn.Text = "Turn On";
            this.turnOnBttn.UseVisualStyleBackColor = true;
            this.turnOnBttn.Click += new System.EventHandler(this.turnOnBttn_Click);
            // 
            // uartChannel
            // 
            this.uartChannel.PortName = "COM4";
            this.uartChannel.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.uartChannel_DataReceived);
            // 
            // turnOffBttn
            // 
            this.turnOffBttn.Enabled = false;
            this.turnOffBttn.Location = new System.Drawing.Point(104, 34);
            this.turnOffBttn.Name = "turnOffBttn";
            this.turnOffBttn.Size = new System.Drawing.Size(90, 44);
            this.turnOffBttn.TabIndex = 1;
            this.turnOffBttn.Text = "Turn Off";
            this.turnOffBttn.UseVisualStyleBackColor = true;
            this.turnOffBttn.Click += new System.EventHandler(this.turnOffBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status :";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(55, 25);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(73, 13);
            this.statusText.TabIndex = 3;
            this.statusText.Text = "Disconnected";
            // 
            // connectBttn
            // 
            this.connectBttn.Location = new System.Drawing.Point(23, 59);
            this.connectBttn.Name = "connectBttn";
            this.connectBttn.Size = new System.Drawing.Size(75, 23);
            this.connectBttn.TabIndex = 4;
            this.connectBttn.Text = "Connect ";
            this.connectBttn.UseVisualStyleBackColor = true;
            this.connectBttn.Click += new System.EventHandler(this.connectBttn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discBttn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectBttn);
            this.groupBox1.Controls.Add(this.statusText);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // discBttn
            // 
            this.discBttn.Enabled = false;
            this.discBttn.Location = new System.Drawing.Point(104, 59);
            this.discBttn.Name = "discBttn";
            this.discBttn.Size = new System.Drawing.Size(75, 23);
            this.discBttn.TabIndex = 5;
            this.discBttn.Text = "Disconnect";
            this.discBttn.UseVisualStyleBackColor = true;
            this.discBttn.Click += new System.EventHandler(this.discBttn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.turnOnBttn);
            this.groupBox2.Controls.Add(this.turnOffBttn);
            this.groupBox2.Location = new System.Drawing.Point(9, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Led";
            // 
            // startOptions
            // 
            this.startOptions.Controls.Add(this.comboBox5);
            this.startOptions.Controls.Add(this.comboBox4);
            this.startOptions.Controls.Add(this.comboBox3);
            this.startOptions.Controls.Add(this.comboBox2);
            this.startOptions.Controls.Add(this.comboBox1);
            this.startOptions.Controls.Add(this.label6);
            this.startOptions.Controls.Add(this.label5);
            this.startOptions.Controls.Add(this.label4);
            this.startOptions.Controls.Add(this.label3);
            this.startOptions.Controls.Add(this.label2);
            this.startOptions.Location = new System.Drawing.Point(238, 12);
            this.startOptions.Name = "startOptions";
            this.startOptions.Size = new System.Drawing.Size(200, 195);
            this.startOptions.TabIndex = 7;
            this.startOptions.TabStop = false;
            this.startOptions.Text = "Parametrii";
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox5.Location = new System.Drawing.Point(73, 154);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.comboBox4.Location = new System.Drawing.Point(73, 121);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox3.Location = new System.Drawing.Point(73, 87);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(73, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4800",
            "9600"});
            this.comboBox1.Location = new System.Drawing.Point(73, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stop Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Port Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = " ";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(352, 216);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(10, 13);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 343);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Panou de control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.startOptions.ResumeLayout(false);
            this.startOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnOnBttn;
        private System.IO.Ports.SerialPort uartChannel;
        private System.Windows.Forms.Button turnOffBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Button connectBttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button discBttn;
        private System.Windows.Forms.GroupBox startOptions;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tempLabel;
    }
}

