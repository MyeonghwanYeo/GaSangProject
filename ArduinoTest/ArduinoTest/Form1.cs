using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Reactive;
using System.Diagnostics;
using System.Timers;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using static ArduinoTest.Form1;

namespace ArduinoTest
{
    public partial class Form1 : Form
    {
        public Process myProcess;
        private TaskCompletionSource<bool> eventHandled;

        public TcpListener server;
        public NetworkStream stream;

        SerialPort serialPort1 = new SerialPort();

        public bool isRunning = false;
        string message_angle1 = "0";
        string message_angle2 = "0";
        string message_angle3 = "0";
        string message_angle4 = "0";
        string response = "";
        bool cDataProcessed = false; // C_DATA가 처리되었는지 여부를 나타내는 플래그
        private Process unityProcess;

        // 링크 킬이 정의
        static double l1 = 150.0;
        static double l2 = 81.0;
        static double l3 = 34.0;

        int modeNum = 0;
        int stopNum = 0;
        double r = 0;

        Crud_temperature crud_temperature = new Crud_temperature();
        Crud_voltage crud_voltage = new Crud_voltage();
        Crud_relativeLoad crud_relativeLoad = new Crud_relativeLoad();
        Crud_Robotaxis robotAxis;

        public string data;
        string dir = "";

        // 윈폼 실행시 서버 오픈
        public Form1()
        {
            InitializeComponent();
            server = new TcpListener(IPAddress.Any, 7000);

            writeButton.Checked = true;

            maxXBox.Text = (l1 + l2).ToString();
            maxYBox.Text = (l1 + l2).ToString();
            maxZBox.Text = (l1 + l2 - l3).ToString();

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
            powerChart.ChartAreas[0].AxisY.Minimum = 0;
            powerChart.ChartAreas[0].AxisY.Maximum = 12;
            powerChart.Series[0].Points.Add();
            powerChart.Series[1].Points.Add();
            powerChart.Series[2].Points.Add();
            powerChart.Series[3].Points.Add();

            loadChart.ChartAreas[0].AxisX.Minimum = 0;
            loadChart.ChartAreas[0].AxisX.Maximum = 300;
            loadChart.ChartAreas[0].AxisY.Minimum = 0;
            loadChart.ChartAreas[0].AxisY.Maximum = 1500;
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
            public string Axis1Value { get; set; }
            public string Axis2Value { get; set; }
            public string Axis3Value { get; set; }
            public string Axis4Value { get; set; }
        }


        // Firebase 1. 온도 데이터 트리 세팅
        class Crud_temperature
        {
            connection conn = new connection();

            // C# (Windows Forms) => Firebase
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

            // C# (Windows Forms) <= Firebase
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
                    return null;
                }
            }
        }

        // Firebase 2. 전압 데이터 트리 세팅
        class Crud_voltage
        {
            connection conn = new connection();

            // C# (Windows Forms) => Firebase
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

            // C# (Windows Forms) <= Firebase
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
                    return null;
                }
            }
        }

        // Firebase 3. 상대하중 데이터 트리 세팅
        class Crud_relativeLoad
        {
            connection conn = new connection();

            // C# (Windows Forms) => Firebase
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

            // C# (Windows Forms) <= Firebase
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
                    return null;
                }
            }
        }

        // Firebase 4. 4축 로봇 각도 데이터 트리 세팅
        class Crud_Robotaxis
        {
            connection conn = new connection();

            // C# (Windows Forms) => Firebase
            public async Task SetData(string axis1, string axis2, string axis3, string axis4)
            {
                try
                {
                    Data data = new Data()
                    {
                        Axis1Value = axis1,
                        Axis2Value = axis2,
                        Axis3Value = axis3,
                        Axis4Value = axis4
                    };

                    var SetData = conn.client.Set("Arduino/Crud_Robotaxis/", data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public Data data_Firebase_temperature { get; set; }
        public Data data_Firebase_voltage { get; set; }
        public Data data_Firebase_relativeLoad { get; set; }
        public Data data_Firebase_robotaxis { get; set; }

        private async void findButton_Click(object sender, EventArgs e)
        {
            findButton.Enabled = false;

            await PrintPython();

            // 4축로봇 각도 C# => Firebase에 데이터 업로드 코드1(1~4)
            message_angle1 = angle1Box.Text.ToString();
            message_angle2 = angle2Box.Text.ToString();
            message_angle3 = angle3Box.Text.ToString();
            message_angle4 = angle4Box.Text.ToString();

            // 4축로봇 각도 C# => Firebase에 데이터 업로드 코드1
            // Firebase에 데이터 전송
            try
            {
                Crud_Robotaxis robotAxis = new Crud_Robotaxis();
                await robotAxis.SetData(
                    message_angle1,
                    message_angle2,
                    message_angle3,
                    message_angle4
                );
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private async Task PrintPython()
        {
            eventHandled = new TaskCompletionSource<bool>();

            using (myProcess = new Process())
            {
                try
                {
                    myProcess.StartInfo.FileName = dir + @"\PythonEXE\winformtest.exe";
                    myProcess.StartInfo.RedirectStandardInput = true;
                    myProcess.StartInfo.RedirectStandardOutput = true;
                    myProcess.StartInfo.RedirectStandardError = true;
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.StartInfo.WorkingDirectory = dir + @"\LinkGraph";
                    myProcess.EnableRaisingEvents = true;
                    myProcess.Exited += new EventHandler(myProcess_Exited);

                    myProcess.Start();

                    myProcess.StandardInput.WriteLine(endXBox.Text);
                    myProcess.StandardInput.WriteLine(endYBox.Text);
                    myProcess.StandardInput.WriteLine(endZBox.Text);
                    myProcess.StandardInput.Close();

                    angle2Box.Text = Math.Round(double.Parse(myProcess.StandardOutput.ReadLine()), 3).ToString();
                    angle3Box.Text = Math.Round(double.Parse(myProcess.StandardOutput.ReadLine()), 3).ToString();
                    angle4Box.Text = Math.Round(180 - double.Parse(myProcess.StandardOutput.ReadLine()), 3).ToString();

                    myProcess.WaitForExit();
                }
                catch (Exception ex)
                {
                    return;
                }

                await Task.WhenAny(eventHandled.Task, Task.Delay(30000));

                findButton.Enabled = true;

                try
                {
                    linkPictureBox.Load(dir + @"\LinkGraph\linkfigure_" + endXBox.Text + '_' + endYBox.Text + '_' + endZBox.Text + ".png");
                }
                catch (Exception ex)
                {
                    angle2Box.Text = "Error";
                    angle3Box.Text = "Error";
                    angle4Box.Text = "Error";

                    linkPictureBox.Load(dir + @"\LinkGraph\linkfigure_base.png");

                    return;
                }
            }
        }

        private void myProcess_Exited(object sender, System.EventArgs e)
        {
            eventHandled.TrySetResult(true);
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
            double maxReach = l1 + l2;

            double x = 0;
            if (double.TryParse(endXBox.Text, out x))
            {
                x = double.Parse(endXBox.Text);
            }
            else
            {
                return;
            }

            maxYBox.Text = Math.Round((Math.Sqrt(Math.Pow(maxReach, 2) - Math.Pow(x, 2))), 3).ToString();

            double y = 0;

            if (endYBox.Text != "")
            {
                if (double.TryParse(endYBox.Text, out y))
                {
                    y = double.Parse(endYBox.Text);
                }
                else
                {
                    return;
                }

                double zAxisAngle = Math.Atan2(y, x) * 180 / Math.PI - 90;

                angle1Box.Text = Math.Round(zAxisAngle, 3).ToString();

                r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                currentAngle.Text = Math.Round(zAxisAngle, 1).ToString() + "°";

                if (x < 0)
                {
                    zAxisChart.Series["CurrentAngle"].Points[0].SetValueY(360 - Math.Abs(zAxisAngle));
                    zAxisChart.Series["CurrentAngle"].Points[1].SetValueY(Math.Abs(zAxisAngle));
                    zAxisChart.Series["CurrentAngle"].Points[2].SetValueY(0);
                    zAxisChart.Invalidate();
                }
                else
                {
                    zAxisChart.Series["CurrentAngle"].Points[0].SetValueY(0);
                    zAxisChart.Series["CurrentAngle"].Points[1].SetValueY(Math.Abs(zAxisAngle));
                    zAxisChart.Series["CurrentAngle"].Points[2].SetValueY(360 - Math.Abs(zAxisAngle));
                    zAxisChart.Invalidate();
                }

                maxZBox.Text = Math.Round((Math.Sqrt(Math.Pow(maxReach, 2) - Math.Pow(r, 2))) - l3, 3).ToString();
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

            findButton.Enabled = false;
            onButton.Enabled = false;
            offButton.Enabled = true;

            stopNum = 0;
            while (stopNum == 0)
            {
                if (modeNum == 0)
                {
                    // 각도 정보 "Arduino IDE"에 전달
                    string combineddata = $"{angle1Box.Text},{angle2Box.Text},{angle3Box.Text},{angle4Box.Text}\n";

                    serialPort1.Write(combineddata);
                }
                else if (modeNum == 1)
                {
                    serialPort1.Write("Read");
                }

                List<int> tempList = new List<int>();
                List<float> voltList = new List<float>();
                List<int> loadList = new List<int>();

                // 별도의 스레드 실행을 통한 아두이노 IDE 데이터 수신
                // Thread readThread = new Thread(() =>
                // {
                //     while (true)
                //     {
                //         try
                //         {
                //             // 읽을 데이터가 있을 때까지 대기
                //             if (serialPort1.BytesToRead > 0)
                //             {
                //                 string receivedData = serialPort1.ReadLine();
                //                 string[] result = receivedData.Split(',');
                // 
                //                 List<string> dataList = new List<string>(result);
                //                 if (modeNum == 1)
                //                 {
                //                     angle1Box.Text = result[0];
                //                     angle2Box.Text = result[1];
                //                     angle3Box.Text = result[2];
                //                     angle4Box.Text = result[3];
                // 
                //                     dataList.RemoveRange(0, 4);
                //                 }
                // 
                //                 for (int i = 0; i < 5; i++)
                //                 {
                //                     tempList.Add(int.Parse(dataList[3 * i]));
                //                     voltList.Add(float.Parse(dataList[3 * i + 1]) / 10.0f);
                //                     loadList.Add(int.Parse(dataList[3 * i + 2]));
                // 
                //                     tempChart.Series[i].Points.Add(tempList[i]);
                //                     powerChart.Series[i].Points.Add(voltList[i]);
                //                     loadChart.Series[i].Points.Add(loadList[i]);
                //                 }
                //             }
                //             // 약간의 지연 
                //             Thread.Sleep(100);
                // 
                //         }
                //         catch (TimeoutException) { }
                //     }
                // });
                // 
                // readThread.IsBackground = true;
                // readThread.Start();

                //// 현재 날짜 및 시간 "yyyy-MM-dd HH:mm:ss"로 읽기
                //string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //
                //// Firebase 1. 온도 데이터 저장
                //data_Firebase_temperature = new Data
                //{
                //    Timestamp = currentDateTime,
                //    Category = "temperature",
                //    Value = tempList[0]
                //
                //};
                //// 온도 데이터 전송
                //crud_temperature.SetData("temperature", tempList[0], currentDateTime);
                //
                //// Firebase 2. 전압 데이터 저장
                //data_Firebase_voltage = new Data
                //{
                //    Timestamp = currentDateTime,
                //    Category = "voltage",
                //    Value = voltList[0]
                //
                //};
                //// 전압 데이터 전송
                //crud_voltage.SetData("voltage", voltList[0], currentDateTime);
                //
                //// Firebase 3. 하중 데이터 저장
                //data_Firebase_relativeLoad = new Data
                //{
                //    Timestamp = currentDateTime,
                //    Category = "relativeLoad ",
                //    Value = loadList[0]
                //
                //};
                //// 하중 데이터 전송
                //crud_relativeLoad.SetData("relativeLoad", loadList[0], currentDateTime);
            }
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;

            serialPort1.Write("Off\n");

            stopNum = 1;

            findButton.Enabled = true;
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

            // "Thread"구문 활용
            Thread thread = new Thread(update);
            thread.Start();

            if (portBox.Text == "") return;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("0");
                    serialPort1.Close();
                }
                else
                {
                    serialPort1.PortName = portBox.SelectedItem.ToString();

                    int baudRate = 115200;
                    if (int.TryParse(baudRateBox.SelectedItem.ToString(), out baudRate))
                    {
                        serialPort1.BaudRate = baudRate;
                    }
                    else
                    {
                        return;
                    }

                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;                      // "StopBits": 정지비트의 수를 나타내는 열거형
                    serialPort1.Parity = Parity.None;                         // "Parity Bit": 데이터 전송 중 오류를 감지하는데 활용
                    serialPort1.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("연결에러", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button3.Text = serialPort1.IsOpen ? "DISCONNECT" : "CONNECT";
            portBox.Enabled = !serialPort1.IsOpen;
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
                    response = $"{message_angle1},{message_angle2},{message_angle3},{message_angle4}";
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
                // 데이터 수집을 위한 "StringBuilder"
                var csvData = new StringBuilder();
                csvData.AppendLine("Timestamp,Category,Value"); // CSV 헤더

                Crud_temperature crud_temperature = new Crud_temperature();
                Crud_voltage crud_voltage = new Crud_voltage();
                Crud_relativeLoad crud_relativeLoad = new Crud_relativeLoad();

                // "Firebase"에서 데이터 가져오기
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

                // "SaveFileDialog"를 사용하여 파일 저장 위치 선택
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

        private void portBox_Click(object sender, EventArgs e)
        {
            portBox.Items.Clear();

            foreach (var item in SerialPort.GetPortNames())
            {
                portBox.Items.Add(item);
            }
        }

        private void baudRateBox_Click(object sender, EventArgs e)
        {
            baudRateBox.Items.Clear();

            baudRateBox.Items.Add("2400");
            baudRateBox.Items.Add("4800");
            baudRateBox.Items.Add("9600");
            baudRateBox.Items.Add("14400");
            baudRateBox.Items.Add("19200");
            baudRateBox.Items.Add("28800");
            baudRateBox.Items.Add("38400");
            baudRateBox.Items.Add("57600");
            baudRateBox.Items.Add("76800");
            baudRateBox.Items.Add("115200");
            baudRateBox.Items.Add("230400");
            baudRateBox.Items.Add("250000");
            baudRateBox.Items.Add("500000");
            baudRateBox.Items.Add("1000000");
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
            panel3.Visible = false;
            panel5.Visible = true;
            webView.Visible = true;

            monitoringButton.Enabled = true;
            monitoringButton.Visible = true;

            simulationButton.Enabled = false;
            simulationButton.Visible = false;
        }

        private void monitoringButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel5.Visible = false;
            webView.Visible = false;

            simulationButton.Enabled = true;
            simulationButton.Visible = true;

            monitoringButton.Enabled = false;
            monitoringButton.Visible = false;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (writeButton.Checked)
            {
                modeNum = 0;

                endXBox.Enabled = true;
                endYBox.Enabled = true;
                endZBox.Enabled = true;
                findButton.Enabled = true;
            }
            else if (readButton.Checked)
            {
                modeNum = 1;

                endXBox.Enabled = false;
                endYBox.Enabled = false;
                endZBox.Enabled = false;
                findButton.Enabled = false;
            }
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dir = folderBrowserDialog.SelectedPath;
                pathButton.Text = dir;
            }
        }
    }
}
