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
using System.IO;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ArduinoTest
{

    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        List<int> tempData = new List<int>();
        List<float> voltData = new List<float>();
        int stopNum = 0;

        //public void Delay(int ms)
        //{
        //    DateTime dateTimeNow = DateTime.Now;
        //    TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
        //    DateTime dateTimeAdd = dateTimeNow.Add(duration);
        //
        //    while (dateTimeAdd >= dateTimeNow)
        //    {
        //        System.Windows.Forms.Application.DoEvents();
        //        dateTimeNow = DateTime.Now;
        //    }
        //
        //    return;
        //}

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

        // Firebase 클라이언트 세팅
        class connection
        {
            public IFirebaseConfig fc = new FirebaseConfig()
            {
                AuthSecret = "E09Dva4dBklDbRCYPQi9TGPkvCU8Ut0vn9Iji737",
                BasePath = "https://arduinoconnectex-default-rtdb.firebaseio.com/"
            };

            public IFirebaseClient client;
            //Code to warn console if class cannot connect when called.
            public connection()
            {
                try
                {
                    client = new FireSharp.FirebaseClient(fc);
                }
                catch (Exception)
                {
                    Console.WriteLine("오류가 발생했습니다.");
                }
            }
        }

        // 데이터 정보 세팅
        public class Data
        {
            public string Timestamp { get; set; }
            public string Category { get; set; }
            public float Value { get; set; }
        }

        SerialPort port = new SerialPort();
        Crud_temperature crud_temperature = new Crud_temperature();
        Crud_voltage crud_voltage = new Crud_voltage();
        Crud_relativeLoad crud_relativeLoad = new Crud_relativeLoad();

        // Firebase 1.온도 데이터 트리 세팅 ________________________________________________
        class Crud_temperature
        {
            connection conn = new connection();

            //C#(windowform) -> Firebase
            public async Task SetData(string Category, int Value, string Timestamp)
            {
                try
                {
                    Data data = new Data()
                    {
                        Timestamp = Timestamp,
                        Category = Category,
                        Value = Value
                    };
                    var SetData = conn.client.Set("Arduino/Crud_temperature/" + Timestamp, data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }

            //C#(windowform) <- Firebase
            public Dictionary<string, Data> LoadData()
            {
                try
                {
                    FirebaseResponse al = conn.client.Get("Arduino/Crud_temperature/");
                    Dictionary<string, Data> ListData = JsonConvert.DeserializeObject<Dictionary<string, Data>>(al.Body.ToString());

                    return ListData;

                }
                catch (Exception ex)
                {
                    // 예외 처리
                    Console.WriteLine("데이터를 가져오는 중 오류가 발생했습니다: " + ex.Message);
                    return null; // 오류 발생 시 null 반환
                }
            }
        }

        // Firebase 2.전압 데이터 트리 세팅 ________________________________________________
        class Crud_voltage
        {
            connection conn = new connection();

            //C#(windowform) -> Firebase
            public async Task SetData(string Category, float Value, string Timestamp)
            {
                try
                {
                    Data data = new Data()
                    {
                        Timestamp = Timestamp,
                        Category = Category,
                        Value = Value
                    };
                    var SetData = conn.client.Set("Arduino/Crud_voltage/" + Timestamp, data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }

            //C#(windowform) <- Firebase
            public Dictionary<string, Data> LoadData()
            {
                try
                {
                    FirebaseResponse al = conn.client.Get("Arduino/Crud_voltage/");
                    Dictionary<string, Data> ListData = JsonConvert.DeserializeObject<Dictionary<string, Data>>(al.Body.ToString());

                    return ListData;
                }
                catch (Exception ex)
                {
                    // 예외 처리
                    Console.WriteLine("데이터를 가져오는 중 오류가 발생했습니다: " + ex.Message);
                    return null; // 오류 발생 시 null 반환
                }
            }
        }

        // Firebase 3.상대하중 데이터 트리 세팅 ________________________________________________
        class Crud_relativeLoad
        {
            connection conn = new connection();

            //C#(windowform) -> Firebase
            public async Task SetData(string Category, int Value, string Timestamp)
            {
                try
                {
                    Data data = new Data()
                    {
                        Timestamp = Timestamp,
                        Category = Category,
                        Value = Value
                    };
                    var SetData = conn.client.Set("Arduino/Crud_relativeLoad/" + Timestamp, data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }

            //C#(windowform) <- Firebase
            public Dictionary<string, Data> LoadData()
            {
                try
                {
                    FirebaseResponse al = conn.client.Get("Arduino/Crud_relativeLoad/");
                    Dictionary<string, Data> ListData = JsonConvert.DeserializeObject<Dictionary<string, Data>>(al.Body.ToString());

                    return ListData;
                }
                catch (Exception ex)
                {
                    // 예외 처리
                    Console.WriteLine("데이터를 가져오는 중 오류가 발생했습니다: " + ex.Message);
                    return null; // 오류 발생 시 null 반환
                }
            }
        }

        string data;
        public Data data_Firebase_temperature { get; private set; }
        public Data data_Firebase_voltage { get; private set; }
        public Data data_Firebase_relativeLoad { get; private set; }

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

                // 현재 날짜와 시간을 가져옴
                string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                //-------------------------------------------------------------------------------------------------------
                // Firebase 1.온도에 데이터 저장
                 data_Firebase_temperature = new Data
                {
                    Timestamp = currentDateTime,
                    Category = "temperature",
                    Value = tempValue1

                };
                // 데이터 전송
                crud_temperature.SetData("temperature", tempValue1, currentDateTime);

                //-------------------------------------------------------------------------------------------------------
                // Firebase 2.전압에 데이터 저장
                data_Firebase_voltage = new Data
                {
                    Timestamp = currentDateTime,
                    Category = "voltage",
                    Value = voltValue1

                };
                // 데이터 전송
                crud_voltage.SetData("voltage", voltValue1, currentDateTime);


                while (dateTimeAdd >= dateTimeNow)
                {
                    System.Windows.Forms.Application.DoEvents();
                    dateTimeNow = DateTime.Now;
                }

                //-------------------------------------------------------------------------------------------------------
                // Firebase 3.상대하중에 데이터 저장
                data_Firebase_relativeLoad = new Data
                {
                    Timestamp = currentDateTime,
                    Category = "relativeLoad",
                    Value = loadValue1

                };

                // 데이터 전송
                crud_relativeLoad.SetData("relativeLoad", loadValue1, currentDateTime);


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

        private async void exportButton_Click(object sender, EventArgs e)
        {
            if (stopNum == 0)
            {
                MessageBox.Show("데이터 송신을 멈추고 진행해주세요");
                return; // 조기 반환
            }

            try
            {
                // 데이터 수집을 위한 StringBuilder
                var csvData = new StringBuilder();
                csvData.AppendLine("Timestamp,Category,Value"); // CSV 헤더

                Crud_temperature crud_temperature = new Crud_temperature();
                Crud_voltage crud_voltage = new Crud_voltage();
                Crud_relativeLoad crud_relativeLoad = new Crud_relativeLoad();

                // Firebase에서 데이터 가져오기
                foreach (var item in crud_temperature.LoadData())
                {
                    Console.WriteLine("Timestamp :" + item.Value.Timestamp);
                    Console.WriteLine("Category :" + item.Value.Category);
                    Console.WriteLine("Value :" + item.Value.Value);
                    csvData.AppendLine($"{item.Value.Timestamp},{item.Value.Category},{item.Value.Value}");
                }

                foreach (var item in crud_voltage.LoadData())
                {
                    Console.WriteLine("Timestamp :" + item.Value.Timestamp);
                    Console.WriteLine("Category :" + item.Value.Category);
                    Console.WriteLine("Value :" + item.Value.Value);
                    csvData.AppendLine($"{item.Value.Timestamp},{item.Value.Category},{item.Value.Value}");
                }
                foreach (var item in crud_relativeLoad.LoadData())
                {
                    Console.WriteLine("Timestamp :" + item.Value.Timestamp);
                    Console.WriteLine("Category :" + item.Value.Category);
                    Console.WriteLine("Value :" + item.Value.Value);
                    csvData.AppendLine($"{item.Value.Timestamp},{item.Value.Category},{item.Value.Value}");
                }

                // SaveFileDialog를 사용하여 파일 저장 위치 선택
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.Title = "CSV 파일 저장 위치 선택";
                    saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_data.csv"; // 기본 파일명 설정

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 파일에 데이터 쓰기
                        File.WriteAllText(saveFileDialog.FileName, csvData.ToString());
                        MessageBox.Show("데이터가 성공적으로 저장되었습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
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
