using System.Windows.Forms.DataVisualization.Charting;

namespace ArduinoTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series81 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series82 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series83 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series84 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series85 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series86 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series87 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series88 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series89 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series90 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series91 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series92 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series93 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series94 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series95 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series96 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 330D);
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.powerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.simulationButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pathButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monitoringButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.angle4Box = new System.Windows.Forms.TextBox();
            this.angle3Box = new System.Windows.Forms.TextBox();
            this.angle2Box = new System.Windows.Forms.TextBox();
            this.angle1Box = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.currentAngle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.zAxisChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkPictureBox = new System.Windows.Forms.PictureBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.endX = new System.Windows.Forms.Label();
            this.onButton = new System.Windows.Forms.Button();
            this.endY = new System.Windows.Forms.Label();
            this.offButton = new System.Windows.Forms.Button();
            this.endZ = new System.Windows.Forms.Label();
            this.endXBox = new System.Windows.Forms.TextBox();
            this.endYBox = new System.Windows.Forms.TextBox();
            this.endZBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.maxXBox = new System.Windows.Forms.TextBox();
            this.maxYBox = new System.Windows.Forms.TextBox();
            this.maxZBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.RadioButton();
            this.readButton = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAxisChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempChart
            // 
            this.tempChart.BackColor = System.Drawing.Color.Transparent;
            chartArea21.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea21.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea21.AxisX.MajorGrid.Enabled = false;
            chartArea21.AxisX.Title = "Time Step [sec]";
            chartArea21.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea21.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea21.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea21.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea21.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea21.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea21.Name = "TempArea";
            this.tempChart.ChartAreas.Add(chartArea21);
            resources.ApplyResources(this.tempChart, "tempChart");
            legend16.BackColor = System.Drawing.Color.Transparent;
            legend16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend16.IsTextAutoFit = false;
            legend16.Name = "Legend1";
            this.tempChart.Legends.Add(legend16);
            this.tempChart.Name = "tempChart";
            this.tempChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series81.BorderWidth = 2;
            series81.ChartArea = "TempArea";
            series81.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series81.Font = new System.Drawing.Font("Segoe UI", 10F);
            series81.Legend = "Legend1";
            series81.MarkerSize = 0;
            series81.Name = "Motor A";
            series82.BorderWidth = 2;
            series82.ChartArea = "TempArea";
            series82.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series82.LabelBackColor = System.Drawing.Color.Yellow;
            series82.Legend = "Legend1";
            series82.MarkerSize = 0;
            series82.Name = "Motor B-L";
            series83.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series83.BorderWidth = 2;
            series83.ChartArea = "TempArea";
            series83.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series83.Legend = "Legend1";
            series83.Name = "Motor B-R";
            series84.BorderWidth = 2;
            series84.ChartArea = "TempArea";
            series84.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series84.LabelBackColor = System.Drawing.Color.Yellow;
            series84.Legend = "Legend1";
            series84.MarkerSize = 0;
            series84.Name = "Motor C";
            series85.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series85.BorderWidth = 2;
            series85.ChartArea = "TempArea";
            series85.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series85.LabelBackColor = System.Drawing.Color.Yellow;
            series85.Legend = "Legend1";
            series85.MarkerSize = 0;
            series85.Name = "Motor D";
            this.tempChart.Series.Add(series81);
            this.tempChart.Series.Add(series82);
            this.tempChart.Series.Add(series83);
            this.tempChart.Series.Add(series84);
            this.tempChart.Series.Add(series85);
            this.tempChart.TabStop = false;
            title16.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title16.Name = "Title1";
            title16.Text = "Temperature [°C]";
            this.tempChart.Titles.Add(title16);
            // 
            // powerChart
            // 
            this.powerChart.BackColor = System.Drawing.Color.Transparent;
            chartArea22.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea22.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea22.AxisX.MajorGrid.Enabled = false;
            chartArea22.AxisX.Title = "Time Step [sec]";
            chartArea22.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea22.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea22.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea22.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea22.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea22.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea22.Name = "PowerArea";
            this.powerChart.ChartAreas.Add(chartArea22);
            resources.ApplyResources(this.powerChart, "powerChart");
            legend17.BackColor = System.Drawing.Color.Transparent;
            legend17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend17.IsTextAutoFit = false;
            legend17.Name = "Legend1";
            this.powerChart.Legends.Add(legend17);
            this.powerChart.Name = "powerChart";
            this.powerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series86.BorderWidth = 2;
            series86.ChartArea = "PowerArea";
            series86.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series86.Legend = "Legend1";
            series86.Name = "Motor A";
            series87.BorderWidth = 2;
            series87.ChartArea = "PowerArea";
            series87.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series87.Legend = "Legend1";
            series87.Name = "Motor B-L";
            series88.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series88.BorderWidth = 2;
            series88.ChartArea = "PowerArea";
            series88.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series88.Legend = "Legend1";
            series88.Name = "Motor B-R";
            series89.BorderWidth = 2;
            series89.ChartArea = "PowerArea";
            series89.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series89.Legend = "Legend1";
            series89.Name = "Motor C";
            series90.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series90.BorderWidth = 2;
            series90.ChartArea = "PowerArea";
            series90.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series90.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            series90.Legend = "Legend1";
            series90.Name = "Motor D";
            this.powerChart.Series.Add(series86);
            this.powerChart.Series.Add(series87);
            this.powerChart.Series.Add(series88);
            this.powerChart.Series.Add(series89);
            this.powerChart.Series.Add(series90);
            title17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            title17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title17.Name = "Title1";
            title17.Text = "Power [W]";
            this.powerChart.Titles.Add(title17);
            // 
            // loadChart
            // 
            this.loadChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea23.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea23.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea23.AxisX.MajorGrid.Enabled = false;
            chartArea23.AxisX.Title = "Time Step [sec]";
            chartArea23.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea23.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea23.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea23.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea23.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea23.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea23.Name = "LoadArea";
            this.loadChart.ChartAreas.Add(chartArea23);
            resources.ApplyResources(this.loadChart, "loadChart");
            legend18.BackColor = System.Drawing.Color.Transparent;
            legend18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend18.IsTextAutoFit = false;
            legend18.Name = "Legend1";
            this.loadChart.Legends.Add(legend18);
            this.loadChart.Name = "loadChart";
            this.loadChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series91.BorderWidth = 2;
            series91.ChartArea = "LoadArea";
            series91.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series91.Legend = "Legend1";
            series91.Name = "Motor A";
            series92.BorderWidth = 2;
            series92.ChartArea = "LoadArea";
            series92.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series92.Legend = "Legend1";
            series92.Name = "Motor B-L";
            series93.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series93.BorderWidth = 2;
            series93.ChartArea = "LoadArea";
            series93.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series93.Legend = "Legend1";
            series93.Name = "Motor B-R";
            series94.BorderWidth = 2;
            series94.ChartArea = "LoadArea";
            series94.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series94.Legend = "Legend1";
            series94.Name = "Motor C";
            series95.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series95.BorderWidth = 2;
            series95.ChartArea = "LoadArea";
            series95.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series95.Legend = "Legend1";
            series95.Name = "Motor D";
            this.loadChart.Series.Add(series91);
            this.loadChart.Series.Add(series92);
            this.loadChart.Series.Add(series93);
            this.loadChart.Series.Add(series94);
            this.loadChart.Series.Add(series95);
            title18.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title18.Name = "Title1";
            title18.Text = "Relative Load";
            this.loadChart.Titles.Add(title18);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // baudRateBox
            // 
            this.baudRateBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baudRateBox.DropDownHeight = 108;
            this.baudRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.baudRateBox, "baudRateBox");
            this.baudRateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Click += new System.EventHandler(this.baudRateBox_Click);
            // 
            // portBox
            // 
            this.portBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.portBox, "portBox");
            this.portBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.portBox.FormattingEnabled = true;
            this.portBox.Name = "portBox";
            this.portBox.Click += new System.EventHandler(this.portBox_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.mainButton, "mainButton");
            this.mainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.mainButton.Name = "mainButton";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // simulationButton
            // 
            this.simulationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.simulationButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.simulationButton, "simulationButton");
            this.simulationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.simulationButton.Name = "simulationButton";
            this.simulationButton.UseVisualStyleBackColor = false;
            this.simulationButton.Click += new System.EventHandler(this.simulationButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.panel2.Controls.Add(this.pathButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.monitoringButton);
            this.panel2.Controls.Add(this.simulationButton);
            this.panel2.Controls.Add(this.portBox);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.baudRateBox);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pathButton
            // 
            this.pathButton.BackColor = System.Drawing.Color.White;
            this.pathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pathButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.pathButton, "pathButton");
            this.pathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.pathButton.Name = "pathButton";
            this.pathButton.UseVisualStyleBackColor = false;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label1.Name = "label1";
            // 
            // monitoringButton
            // 
            this.monitoringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.monitoringButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.monitoringButton, "monitoringButton");
            this.monitoringButton.FlatAppearance.BorderSize = 0;
            this.monitoringButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.monitoringButton.Name = "monitoringButton";
            this.monitoringButton.UseVisualStyleBackColor = false;
            this.monitoringButton.Click += new System.EventHandler(this.monitoringButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.panel3.Controls.Add(this.angle4Box);
            this.panel3.Controls.Add(this.angle3Box);
            this.panel3.Controls.Add(this.angle2Box);
            this.panel3.Controls.Add(this.angle1Box);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.currentAngle);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.zAxisChart);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.linkPictureBox);
            this.panel3.Controls.Add(this.powerChart);
            this.panel3.Controls.Add(this.loadChart);
            this.panel3.Controls.Add(this.tempChart);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // angle4Box
            // 
            this.angle4Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.angle4Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.angle4Box.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.angle4Box, "angle4Box");
            this.angle4Box.ForeColor = System.Drawing.Color.DarkMagenta;
            this.angle4Box.Name = "angle4Box";
            // 
            // angle3Box
            // 
            this.angle3Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.angle3Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.angle3Box.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.angle3Box, "angle3Box");
            this.angle3Box.ForeColor = System.Drawing.Color.DarkMagenta;
            this.angle3Box.Name = "angle3Box";
            // 
            // angle2Box
            // 
            this.angle2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.angle2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.angle2Box.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.angle2Box, "angle2Box");
            this.angle2Box.ForeColor = System.Drawing.Color.DarkMagenta;
            this.angle2Box.Name = "angle2Box";
            // 
            // angle1Box
            // 
            this.angle1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.angle1Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.angle1Box.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.angle1Box, "angle1Box");
            this.angle1Box.ForeColor = System.Drawing.Color.DarkMagenta;
            this.angle1Box.Name = "angle1Box";
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // currentAngle
            // 
            this.currentAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.currentAngle.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.currentAngle, "currentAngle");
            this.currentAngle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.currentAngle.Name = "currentAngle";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // zAxisChart
            // 
            this.zAxisChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea24.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea24.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea24.AxisX.MajorGrid.LineColor = System.Drawing.Color.Empty;
            chartArea24.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea24.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea24.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea24.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea24.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea24.AxisY.MajorGrid.Enabled = false;
            chartArea24.AxisY.MajorGrid.Interval = 20D;
            chartArea24.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            chartArea24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea24.Name = "AngleArea";
            this.zAxisChart.ChartAreas.Add(chartArea24);
            resources.ApplyResources(this.zAxisChart, "zAxisChart");
            this.zAxisChart.Name = "zAxisChart";
            this.zAxisChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series96.BorderWidth = 2;
            series96.ChartArea = "AngleArea";
            series96.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series96.CustomProperties = "PieStartAngle=270, PieLineColor=Transparent, CollectedColor=White";
            series96.Name = "CurrentAngle";
            series96.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            dataPoint16.AxisLabel = "Remainder1";
            dataPoint16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            dataPoint16.IsValueShownAsLabel = false;
            dataPoint16.LabelForeColor = System.Drawing.Color.Transparent;
            dataPoint17.AxisLabel = "Value";
            dataPoint17.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            dataPoint17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataPoint17.CustomProperties = "LabelsHorizontalLineSize=0, PieLineColor=Transparent, LabelsRadialLineSize=0";
            dataPoint17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            dataPoint17.IsValueShownAsLabel = false;
            dataPoint17.IsVisibleInLegend = false;
            dataPoint17.LabelBorderWidth = 1;
            dataPoint17.LabelForeColor = System.Drawing.Color.Transparent;
            dataPoint18.AxisLabel = "Remainder2";
            dataPoint18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            dataPoint18.LabelForeColor = System.Drawing.Color.Transparent;
            series96.Points.Add(dataPoint16);
            series96.Points.Add(dataPoint17);
            series96.Points.Add(dataPoint18);
            this.zAxisChart.Series.Add(series96);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // linkPictureBox
            // 
            resources.ApplyResources(this.linkPictureBox, "linkPictureBox");
            this.linkPictureBox.Name = "linkPictureBox";
            this.linkPictureBox.TabStop = false;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.webView, "webView");
            this.webView.Name = "webView";
            this.webView.Source = new System.Uri("http://192.168.0.160/receiver/index.html", System.UriKind.Absolute);
            this.webView.ZoomFactor = 1D;
            // 
            // endX
            // 
            resources.ApplyResources(this.endX, "endX");
            this.endX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.endX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endX.Name = "endX";
            // 
            // onButton
            // 
            this.onButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.onButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.onButton, "onButton");
            this.onButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.onButton.Name = "onButton";
            this.onButton.UseVisualStyleBackColor = false;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // endY
            // 
            resources.ApplyResources(this.endY, "endY");
            this.endY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.endY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endY.Name = "endY";
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.offButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.offButton, "offButton");
            this.offButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.offButton.Name = "offButton";
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // endZ
            // 
            resources.ApplyResources(this.endZ, "endZ");
            this.endZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.endZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endZ.Name = "endZ";
            // 
            // endXBox
            // 
            this.endXBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.endXBox, "endXBox");
            this.endXBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endXBox.Name = "endXBox";
            this.endXBox.TextChanged += new System.EventHandler(this.endXBox_TextChanged);
            // 
            // endYBox
            // 
            this.endYBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.endYBox, "endYBox");
            this.endYBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endYBox.Name = "endYBox";
            this.endYBox.TextChanged += new System.EventHandler(this.endYBox_TextChanged);
            // 
            // endZBox
            // 
            this.endZBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.endZBox, "endZBox");
            this.endZBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endZBox.Name = "endZBox";
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.ShortcutsEnabled = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label6.Name = "label6";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.findButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.findButton, "findButton");
            this.findButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.findButton.Name = "findButton";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // maxXBox
            // 
            this.maxXBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.maxXBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxXBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.maxXBox, "maxXBox");
            this.maxXBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.maxXBox.Name = "maxXBox";
            // 
            // maxYBox
            // 
            this.maxYBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.maxYBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxYBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.maxYBox, "maxYBox");
            this.maxYBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.maxYBox.Name = "maxYBox";
            // 
            // maxZBox
            // 
            this.maxZBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.maxZBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxZBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.maxZBox, "maxZBox");
            this.maxZBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.maxZBox.Name = "maxZBox";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.writeButton);
            this.panel1.Controls.Add(this.readButton);
            this.panel1.Controls.Add(this.maxZBox);
            this.panel1.Controls.Add(this.maxYBox);
            this.panel1.Controls.Add(this.maxXBox);
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.endZBox);
            this.panel1.Controls.Add(this.endYBox);
            this.panel1.Controls.Add(this.endXBox);
            this.panel1.Controls.Add(this.endZ);
            this.panel1.Controls.Add(this.offButton);
            this.panel1.Controls.Add(this.endY);
            this.panel1.Controls.Add(this.onButton);
            this.panel1.Controls.Add(this.endX);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label3.Name = "label3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            // 
            // writeButton
            // 
            resources.ApplyResources(this.writeButton, "writeButton");
            this.writeButton.Name = "writeButton";
            this.writeButton.TabStop = true;
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // readButton
            // 
            resources.ApplyResources(this.readButton, "readButton");
            this.readButton.Name = "readButton";
            this.readButton.TabStop = true;
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.panel5.Controls.Add(this.webView);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAxisChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart powerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart loadChart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox baudRateBox;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Panel panel3;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button monitoringButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox angle4Box;
        private System.Windows.Forms.TextBox angle3Box;
        private System.Windows.Forms.TextBox angle2Box;
        private System.Windows.Forms.TextBox angle1Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox currentAngle;
        private System.Windows.Forms.Label label8;
        private Chart zAxisChart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox linkPictureBox;
        private System.Windows.Forms.Label endX;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Label endY;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Label endZ;
        private System.Windows.Forms.TextBox endXBox;
        private System.Windows.Forms.TextBox endYBox;
        private System.Windows.Forms.TextBox endZBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox maxXBox;
        private System.Windows.Forms.TextBox maxYBox;
        private System.Windows.Forms.TextBox maxZBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton writeButton;
        private System.Windows.Forms.RadioButton readButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel5;
    }
}

