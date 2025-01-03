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
using System.Timers;

namespace ArduinoTest
{

    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        List<int> tempData = new List<int>();
        List<float> voltData = new List<float>();
        int stopNum = 0;

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

        public Form1()
        {
            InitializeComponent();

            tempChart.ChartAreas[0].AxisX.Minimum = 0;
            tempChart.ChartAreas[0].AxisX.Maximum = 300;
            tempChart.ChartAreas[0].AxisY.Minimum = 0;
            tempChart.ChartAreas[0].AxisY.Maximum = 100;
            tempChart.Series[0].Points.Add();
            tempChart.Series[1].Points.Add();
            tempChart.Series[2].Points.Add();
            tempChart.Series[3].Points.Add();

            powerChart.ChartAreas[0].AxisX.Minimum = 0;
            powerChart.ChartAreas[0].AxisX.Maximum = 300;
            powerChart.ChartAreas[0].AxisY.Minimum = 11;
            powerChart.ChartAreas[0].AxisY.Maximum = 12;
            powerChart.Series[0].Points.Add();
            powerChart.Series[1].Points.Add();
            powerChart.Series[2].Points.Add();
            powerChart.Series[3].Points.Add();

            loadChart.ChartAreas[0].AxisX.Minimum = 0;
            loadChart.ChartAreas[0].AxisX.Maximum = 300;
            loadChart.ChartAreas[0].AxisY.Minimum = 0;
            loadChart.ChartAreas[0].AxisY.Maximum = 200;
            loadChart.Series[0].Points.Add();
            loadChart.Series[1].Points.Add();
            loadChart.Series[2].Points.Add();
            loadChart.Series[3].Points.Add();
        }

        string data;
        private void onButton_Click(object sender, EventArgs e)
        {
            offButton.Focus();
            if (!serialPort1.IsOpen) return;
            serialPort1.Write("240");
            //serialPort1.Write(rpmA.Text);
            //serialPort1.Write(rpmB.Text);
            //serialPort1.Write(rpmC.Text);
            //serialPort1.Write(rpmD.Text);

            stopNum = 0;

            onButton.Enabled = false;
            offButton.Enabled = true;

            DateTime dateTimeNow = DateTime.Now;
            while (stopNum == 0)
            {
                data = serialPort1.ReadLine();
                int tempValue1 = int.Parse(data);

                data = serialPort1.ReadLine();
                float voltValue1 = float.Parse(data)/10.0f;

                data = serialPort1.ReadLine();
                int loadValue1 = int.Parse(data);

                tempChart.Series[0].Points.Add(tempValue1);
                //chart1.Series[1].Points.Add(tempValue2);
                powerChart.Series[0].Points.Add(voltValue1);
                //chart2.Series[1].Points.Add(voltValue2);
                loadChart.Series[0].Points.Add(loadValue1);
                //chart3.Series[1].Points.Add(loadValue2);

                TimeSpan duration = new TimeSpan(0, 0, 0, 0, 1000);
                DateTime dateTimeAdd = dateTimeNow.Add(duration);

                while (dateTimeAdd >= dateTimeNow)
                {
                    System.Windows.Forms.Application.DoEvents();
                    dateTimeNow = DateTime.Now;
                }
            }
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;

            stopNum = 1;

            onButton.Enabled = true;
            offButton.Enabled = false;
        }

        private void connectButton_Click(object sender, EventArgs e)
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

            button3.Text = serialPort1.IsOpen ? "DISCONNECT" : "CONNECT";
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

        private void mainButton_Click(object sender, EventArgs e)
        {
            // 현재 창 "Form1"를 닫고, 모니터링 창 "Form2" 열기
            this.Visible = false;

            Form2 showForm2 = new Form2();

            showForm2.MainPanelVisibility();
            showForm2.ShowDialog();

            Application.Exit();
        }

        private void simulationButton_Click(object sender, EventArgs e)
        {
            webView.Visible = true;

            monitoringButton.Enabled = true;
            monitoringButton.Visible = true;

            simulationButton.Enabled = false;
            simulationButton.Visible = false;
        }

        private void monitoringButton_Click(object sender, EventArgs e)
        {
            webView.Visible = false;

            simulationButton.Enabled = true;
            simulationButton.Visible = true;

            monitoringButton.Enabled = false;
            monitoringButton.Visible = false;
        }
    }
}
