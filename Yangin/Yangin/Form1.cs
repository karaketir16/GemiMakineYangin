using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Yangin
{
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        Timer timer;
        int count = 30;
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
            // Form kapandığında SerialPort1 portu kapat.
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Tick");
                if (!label1.Visible) label1.Visible = true;
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Yaniyosun Fuat Abi");

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
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                label3.ForeColor = Color.Red;
                label3.Text = "Bağlantı Kapalı";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //timer1.Start();
            try
            {
                string a = serialPort1.ReadExisting();
                //listBox1.Items.Add(a);
                //serialPort1.Write(a);
                int x;
                Int32.TryParse(a, out x);
                
                //MessageBox.Show("Yaniyosun Fuat Abi");
                listBox1.Items.Add(a);
                if (x == 1)
                {
                    //listBox1.Items.Add("test");


                    Fire();
                    //label1.Visible = true;
                    listBox1.Items.Add("ddd");
                }
                if(x == 0)
                {
                    //listBox1.Items.Add("deneme");
                }
                if(x == 8)
                {
                    timer.Stop();
                    count = 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void diagram1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("cancel");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("reset");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        void Fire()
        {
            timer = new Timer(1000);
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            digitalGauge1.Value = count.ToString();
            timer.Start();

        }
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            count--;
            digitalGauge1.Value = count.ToString();
            if (count == 0) timer.Stop();
        }
    }
}
