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
        Label FA1, FA2, TankLevel, EngineRoomFanStop, BilgeWater,
                FirePump, BilgePump, EngineRoomFan;
        string[] ports = SerialPort.GetPortNames();
        Timer timer;
        int cnt = 15;
        int count = 15;
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
            FA1 = label8;
            FA2 = label10;
            TankLevel = label11;
            EngineRoomFanStop = label12;
            BilgeWater = label13;
            FirePump = label21;
            BilgePump = label9;
            EngineRoomFan = label15;
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
        void resetle()
        {
            timer.Stop();
            count = cnt;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = false;
            //digitalGauge1.Visible = false;
            digitalGauge1.Value = "00";
            FA1.BackColor = Color.LightGray;
            FA2.BackColor = Color.LightGray;
            TankLevel.BackColor = Color.LightGray;
            EngineRoomFanStop.BackColor = Color.LightGray;
            BilgeWater.BackColor = Color.LightGray;
            FirePump.BackColor = Color.LightGray;
            BilgePump.BackColor = Color.LightGray;
            EngineRoomFan.BackColor = Color.Lime;
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
                switch (x)
                {
                    case 0: //yangin yok
                        break;
                    case 1: //yangin1
                        Fire();
                        FA1.BackColor = Color.Red;
                        listBox1.Items.Add("yangin1");
                        button5.Enabled = false;
                        button6.Enabled = false;
                        break;
                    case 2: //fanrun
                        EngineRoomFanStop.BackColor = Color.LightGray;
                        EngineRoomFan.BackColor = Color.Lime;
                        break;
                    case 3: //fanstop
                        EngineRoomFanStop.BackColor = Color.Red;
                        EngineRoomFan.BackColor = Color.LightGray;
                        break;
                    case 4: //pomprun
                        FirePump.BackColor = Color.Lime;

                        break;
                    case 5: //pompstop
                        FirePump.BackColor = Color.LightGray;
                        break;
                    case 6: //count down
                        //inside fire
                        break;
                    case 7: //yangin2
                        Fire();
                        FA2.BackColor = Color.Red;
                        listBox1.Items.Add("yangin2");
                        button5.Enabled = false;
                        button6.Enabled = false;
                        break;
                    case 8: //reset
                        resetle();
                        break;
                    case 9: //tahliyerun
                        BilgeWater.BackColor = Color.Red;
                        BilgePump.BackColor = Color.Lime;
                        break;
                    case 10: //tahliyestop
                        BilgeWater.BackColor = Color.LightGray;
                        BilgePump.BackColor = Color.LightGray;
                        break;

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            FirePump.BackColor = Color.LightGray;
            serialPort1.Write("pumpstop");
            button6.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("pumpstart");
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
            resetle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("reset");
            resetle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            FirePump.BackColor = Color.Lime;
            serialPort1.Write("pumpstart");
            button5.Enabled = false;

        }
        void Fire()
        {
            
            timer = new Timer(1000);
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            //digitalGauge1.Value = count.ToString();
            timer.Start();
            digitalGauge1.Visible = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            count--;
            digitalGauge1.Value = count.ToString();
            if (count == 0)
            {
                timer.Stop();
                button3.Enabled = false;
            }
        }
    }
}
