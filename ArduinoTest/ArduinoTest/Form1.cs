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
using System.Net.Sockets;
using System.Net;
using System.Reactive;
using System.Messaging;
using System.Diagnostics;

namespace ArduinoTest
{
    public partial class Form1 : Form
    {
        public TcpListener server;
        public NetworkStream stream;
        public bool isRunning = false;
        string message_angle1 = "0";
        string message_angle2 = "0";
        string message_angle3 = "0";
        string message_angle4 = "0";
        string response = "";
        bool cDataProcessed = false; // C_DATA가 처리되었는지 여부를 나타내는 플래그
        private Process unityProcess;
        static double l1 = 10.0; // 첫 번째 링크 길이
        static double l2 = 15.0; // 두 번째 링크 길이
        static double l3 = 2.0; // 세 번째 링크 길이

        SerialPort serialPort1 = new SerialPort();

        int stopNum = 0;

        double r = 0;

        // winform 실행시 서버를 켠다.
        public Form1()
        {
            InitializeComponent();
            server = new TcpListener(IPAddress.Any, 7000);

            maxXBox.Text = (l1 + l2 + l3).ToString();
            maxYBox.Text = (l1 + l2 + l3).ToString();
            maxZBox.Text = (l1 + l2 + l3).ToString();

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

        private void findButton_Click(object sender, EventArgs e)
        {
            if (endXBox.Text != "" && endYBox.Text != "" && endZBox.Text != "")
            {
                double x = double.Parse(endYBox.Text);

                double y = double.Parse(endXBox.Text);

                double z = double.Parse(endZBox.Text);

                r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                double theta1 = Math.Atan2(y, x) * (-180 / Math.PI);

                z = z - l3;

                double cosTheta3 = (Math.Pow(r, 2) + Math.Pow(z, 2) - Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l2);

                double sinTheta3CW = Math.Sqrt(1 - Math.Pow(cosTheta3, 2)) * (-1);

                double theta3CW = Math.Atan2(sinTheta3CW, cosTheta3) * (180 / Math.PI);

                double theta2CW = 90 - (Math.Atan2(z, r) - Math.Atan2(l2 * sinTheta3CW, l1 + l2 * cosTheta3)) * (180 / Math.PI);

                double sinTheta3CCW = Math.Sqrt(1 - Math.Pow(cosTheta3, 2));

                double theta3CCW = Math.Atan2(sinTheta3CCW, cosTheta3) * (180 / Math.PI);

                double theta2CCW = 90 - (Math.Atan2(z, r) - Math.Atan2(l2 * sinTheta3CCW, l1 + l2 * cosTheta3)) * (180 / Math.PI);

                angle1Box.Text = Math.Round(theta1, 3).ToString();
                angle2Box.Text = Math.Round(theta2CW, 3).ToString();
                angle3Box.Text = Math.Round(-theta3CW, 3).ToString();

                double theta4 = 90 - (theta2CW - theta3CW);
                angle4Box.Text = Math.Round(theta4, 3).ToString();

                textBox4.Text = Math.Round(theta1, 3).ToString();
                textBox3.Text = Math.Round(theta2CCW, 3).ToString();
                textBox2.Text = Math.Round(-theta3CCW, 3).ToString();

                theta4 = 90 - (theta2CCW - theta3CCW);
                textBox1.Text = Math.Round(theta4, 3).ToString();

                textBox6.Text = Math.Round((l1 * Math.Sin(theta2CW * Math.PI / 180) + l2 * Math.Sin((theta2CW - theta3CW) * Math.PI / 180)), 3).ToString();
                textBox5.Text = Math.Round((l1 * Math.Cos(theta2CW * Math.PI / 180) + l2 * Math.Cos((theta2CW - theta3CW) * Math.PI / 180) + l3), 3).ToString();
            }
            else
            {
                return;
            }
        }

        private void endXBox_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void endYBox_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void endZBox_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        public void textChanged()
        {
            double maxReach = l1 + l2 + l3;

            double x = double.Parse(endXBox.Text);

            maxYBox.Text = Math.Round((Math.Sqrt(Math.Pow(maxReach, 2) - Math.Pow(x, 2))), 3).ToString();

            double y = 0;

            if (endYBox.Text != "")
            {
                y = double.Parse(endYBox.Text);

                r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                maxZBox.Text = Math.Round((Math.Sqrt(Math.Pow(maxReach, 2) - Math.Pow(r, 2))), 3).ToString();

                textBox7.Text = Math.Round(r, 3).ToString();
            }
            else
            {
                return;
            }
        }

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
            if (isRunning)
            {
                return;
            }

            isRunning = true;

            server.Start();

            // Thread문 활용
            Thread thread = new Thread(update);
            thread.Start();

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

        byte[] buffer = new byte[1024];
        int bytesRead;
        string messageFromClient;

        // 서버가 실행되고 나서 반복 실행이 되게끔.. Thread를 만들고 위에서 버튼 클릭시 무한 작동함.
        void update()
        {
            TcpClient client = server.AcceptTcpClient(); // 클라이언트가 서버로 들어갈때 사용하는 코드
            stream = client.GetStream(); // 서버로 들어온 후 클라이언트가 열은 소통창구인 stream

            while (isRunning)
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length); // 클라이언트와 서버간 소통 내용을 bytesRead에 담음
                messageFromClient = Encoding.UTF8.GetString(buffer, 0, bytesRead); // 서버 언어 -> 클라이언트 언어으로 통역

                if (messageFromClient.Contains("Connect")) // 서버로 들어온 클라이언트 언어가 connect일때 response으로 담음.
                {
                    response = "서버에 잘 연결 되었습니다.";
                }
                else if (messageFromClient.Contains("C_DATA")) // C_DATA가 처음 들어왔을 때만 처리
                {
                    response = $"{ message_angle1},{message_angle2},{message_angle3},{message_angle4}";
                    cDataProcessed = false; // 다음 C_DATA를 위해 플래그를 초기화
                }
                else if (messageFromClient.Contains("Disconnect"))
                {
                    response = "서버가 종료되었습니다.";
                }
                else
                {
                    response = "";
                }

                byte[] responseBytes = new byte[1024]; // 1024개의 바이트를 저장할 수 있는 배열 준비
                responseBytes = Encoding.UTF8.GetBytes(response); // response의 새로운 배열 준비
                stream.Write(responseBytes, 0, responseBytes.Length); // responseBytes의 내용을 stream에 작성함.

            }
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
