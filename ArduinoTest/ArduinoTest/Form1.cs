using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArduinoTest
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        List<int> tempData = new List<int>();
        List<float> voltData = new List<float>();

        int stopNum = 0;

        public Form1()
        {
            InitializeComponent();

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;

            chart2.ChartAreas[0].AxisY.Minimum = 11;
            chart2.ChartAreas[0].AxisY.Maximum = 12;
        }

        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);

            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Focus();
            if (!serialPort1.IsOpen) return;
            //serialPort1.Write(textBox1.Text);

            // 데이터 읽기
            stopNum = 0;
            while (stopNum == 0)
            {
                int tempValue = serialPort1.ReadByte();
                float voltValue = serialPort1.ReadByte()/10.0f;
                //float angleValue = serialPort1.ReadByte();

                chart1.Series[0].Points.Add(tempValue);
                chart2.Series[0].Points.Add(voltValue);
                //tempData.Add(tempValue);

                Delay(10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;

            stopNum = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("0");
                    serialPort1.Close();
                }
                else
                {
                    serialPort1.PortName = comboBox1.SelectedItem.ToString();
                    serialPort1.BaudRate = 115200;                              
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;                      // "StopBits": 정지비트의 수를 나타내는 열거형
                    serialPort1.Parity = Parity.None;                         // "Parity Bit": 데이터 전송 중 오류를 감지하는데 활용
                    serialPort1.Open();                                       // 직렬 포트 활성화 > 읽기/쓰기 작업 수행
                }
            }
            catch (Exception)
            {
                MessageBox.Show("연결에러", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button3.Text = serialPort1.IsOpen ? "Disconnect" : "Connect";
            comboBox1.Enabled = !serialPort1.IsOpen;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            // 현재 창 "Form1"를 닫고, 모니터링 창 "Form2" 열기
            this.Visible = false;

            Form2 showForm2 = new Form2();

            showForm2.MainPanelVisibility();
            showForm2.ShowDialog();

            Application.Exit();
        }
    }
}
