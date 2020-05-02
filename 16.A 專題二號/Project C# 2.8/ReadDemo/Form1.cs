using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;              // for SerialPort class

namespace ReadDemo
{
    public partial class Form1 : Form
    {
        private SerialPort SPort;
        public delegate void AddDataDelegate();

        public Form1()
        {
            InitializeComponent();
        }
        string k, k1 = "00";
        private void Form1_Load(object sender, EventArgs e)
        {         
            string[] serialPorts = SerialPort.GetPortNames();  //偵測有哪些COM執行
            ComboBox1.DataSource = serialPorts;                //在ComboBox中執行
            button1.BackColor = Color.LightGreen;
            button2.BackColor = Color.LightGreen;
            button3.BackColor = Color.LightGreen;
            button4.BackColor = Color.LightGreen;
            button5.BackColor = Color.LightGreen;
            button6.BackColor = Color.LightGreen;
            button7.BackColor = Color.LightGreen;
            button8.BackColor = Color.LightGreen;
            button9.BackColor = Color.LightGreen;
            button10.BackColor = Color.LightGreen;
            button11.BackColor = Color.LightGreen;
            button12.BackColor = Color.LightGreen;
            button13.BackColor = Color.LightGreen;
            button14.BackColor = Color.LightGreen;
            button15.BackColor = Color.LightGreen;
            button16.BackColor = Color.LightGreen;

            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            SPort = new SerialPort(ComboBox1.SelectedItem.ToString(), 
                                   9600, Parity.None, 8, StopBits.One);
            SPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                SPort.Open();     //開啟Com.port
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SPort.Close();
            btnOpen.Enabled = true ;
            btnClose.Enabled = false ;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new AddDataDelegate(AddData));
        }

        private void AddData()
        {
            string data = SPort.ReadLine();
            string NEWDATA = data.Substring(data.Length - 3, 2);  //取尾數
            k1 = NEWDATA;
            if(k != k1){
                k=k1;
            textBox1.AppendText(NEWDATA);
            textBox1.AppendText("\r\n");  
            }
            if (NEWDATA  == "00")
            {
                button1.Enabled = true ;
                button2.Enabled = true;
                button1.BackColor = Color.LightGreen;
                button2.BackColor = Color.LightGreen;
            }
            if (NEWDATA == "01")
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button1.BackColor = Color.LightGreen;
                button2.BackColor = Color.Red;
            }
            if (NEWDATA == "10")
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.LightGreen ;
            }
            if (NEWDATA == "11")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
