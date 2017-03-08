using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Sincretic
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 2;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 1;
            comboBox5.SelectedIndex = 1;

        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.tempLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tempLabel.Text = text;
            }
        }

        private void turnOnBttn_Click(object sender, EventArgs e)
        {

                byte[] data = System.Text.Encoding.UTF8.GetBytes("S");

                uartChannel.Write(data, 0, data.Length);
        }

        private void uartChannel_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            var mv = (((Convert.ToDouble(uartChannel.ReadByte()))) / 1024) * 5000 ;
            var cel = mv / 10;
            var finalTemp = ((cel - 32) * 5) / 9;
            SetText(mv.ToString("##.##") + " mv adica " + finalTemp.ToString("##.##") + " grade");
        }

        private void turnOffBttn_Click(object sender, EventArgs e)
        {
            if (uartChannel.IsOpen)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("s");

                uartChannel.Write(data, 0, data.Length);
            }
        }

        private void connectBttn_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:uartChannel.BaudRate = 4800;break;
                case 1:uartChannel.BaudRate = 9600;break;
            }

            switch(comboBox2.SelectedIndex)
            {
                case 0:uartChannel.DataBits = 5;break;
                case 1:uartChannel.DataBits = 6;break;
                case 2:uartChannel.DataBits = 7;break;
                case 3:uartChannel.DataBits = 8;break;
            }

            switch(comboBox3.SelectedIndex)
            {
                case 0:uartChannel.Parity = System.IO.Ports.Parity.None ;break;
                case 1:uartChannel.Parity = System.IO.Ports.Parity.Odd;break;
                case 2:uartChannel.Parity = System.IO.Ports.Parity.Even;break; 
            }

            switch(comboBox4.SelectedIndex)
            {
                case 0:uartChannel.PortName = "COM1";break;
                case 1:uartChannel.PortName = "COM2";break;
                case 2:uartChannel.PortName = "COM3";break;
                case 3:uartChannel.PortName = "COM4";break;
                case 4: uartChannel.PortName = "COM5"; break;
                case 5: uartChannel.PortName = "COM6"; break;
                case 6: uartChannel.PortName = "COM7"; break;
            }

            switch(comboBox5.SelectedIndex)
            {
                case 0:uartChannel.StopBits = System.IO.Ports.StopBits.One;break;
                case 1:uartChannel.StopBits = System.IO.Ports.StopBits.Two;break;
            }
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "")
            {
                MessageBox.Show("Please fill in all the parameters.");
            }
            else
            {
                try
                {
                    uartChannel.Open();
                    statusText.Text = "Connected";
                    connectBttn.Enabled = false;
                    discBttn.Enabled = true;
                    label7.Text = "Temperatura citita este :";

                    turnOffBttn.Enabled = true;
                    turnOnBttn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
        }

        private void discBttn_Click(object sender, EventArgs e)
        {
            uartChannel.Close();
            connectBttn.Enabled = true;
            discBttn.Enabled = false;
            statusText.Text = "Disconnected";
            turnOffBttn.Enabled = false;
            turnOnBttn.Enabled = false;
            label7.Text = " ";
            tempLabel.Text = " ";
        }
    }
}
