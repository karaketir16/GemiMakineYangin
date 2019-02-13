using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace Data_Okuma
{
    public partial class Form1 : Form
    {
        int degree = 90;
        string[] ports = SerialPort.GetPortNames();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }            
            comboBox2.Items.Add("2400");
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("115200");
            comboBox2.SelectedIndex = 2;
            //AÇILIŞTA BAĞLANTININ KAPALI OLDUĞUNU BELİRT.
            label3.Text = "Bağlantı Kapalı";
            ListBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
            // Form kapandığında SerialPort1 portu kapat.
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                if (label1.Enabled) label1.Enabled = false;
                else label1.Enabled = true;
          
                //if (serialPort1.BytesToRead <= 0) return;
                //string sonuc = serialPort1.ReadLine();//Serial.print(sicaklik); ile gelen sıcaklık değerini alıyoruz.

                    //int x;
                    //while(!Int32.TryParse(sonuc, out x)) sonuc = label1.Text;
                    //Int32.TryParse(sonuc, out x);
                    //label1.Text = sonuc + "";                  //Labele yazdırıyoruz.
                    //aGauge1.Value = x;
                    //label4.Text = serialPort1.BytesToRead + "";
                    //string a = serialPort1.ReadExisting();
                    //listBox1.Items.Add(a);
                    //serialPort1.Write(a);
                    //label1.Text =  serialPort1.ReadChar() + 0 + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Yaniyosun Fuat Abi");
            label1.Visible = true;
            //Form2 aa = 
            timer1.Start();
            if (serialPort1.IsOpen == false)
            {
                if (comboBox1.Text == "")
                    return;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt16(comboBox2.Text);
                try
                {
                    serialPort1.Open();
                    label3.ForeColor = Color.Green;
                    label3.Text = "Bağlantı Açık";


                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata:" + hata.Message);
                }
            }
            else
            {
                label3.Text = "Bağlantı kurulu !!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BAĞLANTIYI KES BUTONU
            timer1.Stop();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                label3.ForeColor = Color.Red;
                label3.Text = "Bağlantı Kapalı";
            }
        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                string a = serialPort1.ReadExisting();
                //listBox1.Items.Add(a);
                //serialPort1.Write(a);
                int x;
                Int32.TryParse(a, out x);

                MessageBox.Show("Yaniyosun Fuat Abi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
  
