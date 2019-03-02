namespace Yangin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 19;
            this.label1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 200);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 95);
            this.listBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bağlantı Durumu";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "Kopar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(290, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fire Alarm (DG Room 1)";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fire Alarm (DG Room 2)";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(290, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Engine Room Fan (Stop)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(290, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fresh Water Tank Level (Low)";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(290, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bilge Water Alarm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(254, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 29);
            this.label8.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(254, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 29);
            this.label10.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(254, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 29);
            this.label11.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(254, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 29);
            this.label12.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(254, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 29);
            this.label13.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(212, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 623);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alarm List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control Panel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(461, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Emg. Pump Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(262, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 29);
            this.label9.TabIndex = 36;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Emg. Pump Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(298, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(286, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "Emg. Fire Pump";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(262, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 29);
            this.label15.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(298, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(286, 29);
            this.label16.TabIndex = 28;
            this.label16.Text = "Emg. Bilge Pump";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(298, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(286, 29);
            this.label20.TabIndex = 30;
            this.label20.Text = "Engine Room Fan";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.LightGray;
            this.label21.Location = new System.Drawing.Point(262, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 29);
            this.label21.TabIndex = 32;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(857, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Diagram";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Lime;
            this.label23.Location = new System.Drawing.Point(704, 493);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 29);
            this.label23.TabIndex = 40;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Lime;
            this.label22.Location = new System.Drawing.Point(704, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 29);
            this.label22.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(184, 507);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 15);
            this.label19.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(331, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 12);
            this.label18.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(237, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 12);
            this.label17.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1172, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cancel ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(1277, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.CharacterCount = 2;
            this.digitalGauge1.DisplayRecordIndex = 0;
            this.digitalGauge1.Location = new System.Drawing.Point(1172, 12);
            this.digitalGauge1.MaximumSize = new System.Drawing.Size(500, 180);
            this.digitalGauge1.MinimumSize = new System.Drawing.Size(90, 90);
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Size = new System.Drawing.Size(180, 90);
            this.digitalGauge1.TabIndex = 24;
            this.digitalGauge1.Value = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(346, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(472, 42);
            this.label24.TabIndex = 25;
            this.label24.Text = "YANIYOSUN FUAT ABİİİ!!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.digitalGauge1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
    }
}

