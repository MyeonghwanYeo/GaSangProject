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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series61 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series62 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series63 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series64 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series65 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series66 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series67 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series68 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series69 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series70 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series71 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series72 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.powerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Motor1 = new System.Windows.Forms.Label();
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.rpmA = new System.Windows.Forms.TextBox();
            this.endX = new System.Windows.Forms.Label();
            this.endY = new System.Windows.Forms.Label();
            this.endZ = new System.Windows.Forms.Label();
            this.endXBox = new System.Windows.Forms.TextBox();
            this.endYBox = new System.Windows.Forms.TextBox();
            this.endZBox = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.simulationButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monitoringButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maxZBox = new System.Windows.Forms.TextBox();
            this.maxYBox = new System.Windows.Forms.TextBox();
            this.maxXBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.motorDBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.rpmD = new System.Windows.Forms.TextBox();
            this.motorCBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.rpmC = new System.Windows.Forms.TextBox();
            this.motorBBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rpmB = new System.Windows.Forms.TextBox();
            this.motorABar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.angle4Box = new System.Windows.Forms.TextBox();
            this.angle3Box = new System.Windows.Forms.TextBox();
            this.angle2Box = new System.Windows.Forms.TextBox();
            this.angle1Box = new System.Windows.Forms.TextBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorDBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorCBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorABar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // tempChart
            // 
            this.tempChart.BackColor = System.Drawing.Color.Transparent;
            chartArea16.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea16.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea16.AxisX.MajorGrid.Enabled = false;
            chartArea16.AxisX.Title = "Time Step [sec]";
            chartArea16.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea16.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea16.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea16.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea16.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea16.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea16.Name = "TempArea";
            this.tempChart.ChartAreas.Add(chartArea16);
            resources.ApplyResources(this.tempChart, "tempChart");
            legend16.BackColor = System.Drawing.Color.Transparent;
            legend16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend16.IsTextAutoFit = false;
            legend16.Name = "Legend1";
            this.tempChart.Legends.Add(legend16);
            this.tempChart.Name = "tempChart";
            this.tempChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series61.BorderWidth = 2;
            series61.ChartArea = "TempArea";
            series61.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series61.Font = new System.Drawing.Font("Segoe UI", 10F);
            series61.Legend = "Legend1";
            series61.MarkerSize = 0;
            series61.Name = "Motor A";
            series62.BorderWidth = 2;
            series62.ChartArea = "TempArea";
            series62.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series62.LabelBackColor = System.Drawing.Color.Yellow;
            series62.Legend = "Legend1";
            series62.MarkerSize = 0;
            series62.Name = "Motor B";
            series63.BorderWidth = 2;
            series63.ChartArea = "TempArea";
            series63.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series63.LabelBackColor = System.Drawing.Color.Yellow;
            series63.Legend = "Legend1";
            series63.MarkerSize = 0;
            series63.Name = "Motor C";
            series64.BorderWidth = 2;
            series64.ChartArea = "TempArea";
            series64.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series64.LabelBackColor = System.Drawing.Color.Yellow;
            series64.Legend = "Legend1";
            series64.MarkerSize = 0;
            series64.Name = "Motor D";
            this.tempChart.Series.Add(series61);
            this.tempChart.Series.Add(series62);
            this.tempChart.Series.Add(series63);
            this.tempChart.Series.Add(series64);
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
            chartArea17.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea17.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea17.AxisX.MajorGrid.Enabled = false;
            chartArea17.AxisX.Title = "Time Step [sec]";
            chartArea17.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea17.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea17.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea17.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea17.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea17.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea17.Name = "PowerArea";
            this.powerChart.ChartAreas.Add(chartArea17);
            resources.ApplyResources(this.powerChart, "powerChart");
            legend17.BackColor = System.Drawing.Color.Transparent;
            legend17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend17.IsTextAutoFit = false;
            legend17.Name = "Legend1";
            this.powerChart.Legends.Add(legend17);
            this.powerChart.Name = "powerChart";
            this.powerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series65.BorderWidth = 2;
            series65.ChartArea = "PowerArea";
            series65.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series65.Legend = "Legend1";
            series65.Name = "Motor A";
            series66.BorderWidth = 2;
            series66.ChartArea = "PowerArea";
            series66.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series66.Legend = "Legend1";
            series66.Name = "Motor B";
            series67.BorderWidth = 2;
            series67.ChartArea = "PowerArea";
            series67.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series67.Legend = "Legend1";
            series67.Name = "Motor C";
            series68.BorderWidth = 2;
            series68.ChartArea = "PowerArea";
            series68.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series68.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            series68.Legend = "Legend1";
            series68.Name = "Motor D";
            this.powerChart.Series.Add(series65);
            this.powerChart.Series.Add(series66);
            this.powerChart.Series.Add(series67);
            this.powerChart.Series.Add(series68);
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
            chartArea18.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea18.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea18.AxisX.MajorGrid.Enabled = false;
            chartArea18.AxisX.Title = "Time Step [sec]";
            chartArea18.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea18.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea18.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea18.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea18.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea18.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea18.Name = "LoadArea";
            this.loadChart.ChartAreas.Add(chartArea18);
            resources.ApplyResources(this.loadChart, "loadChart");
            legend18.BackColor = System.Drawing.Color.Transparent;
            legend18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend18.IsTextAutoFit = false;
            legend18.Name = "Legend1";
            this.loadChart.Legends.Add(legend18);
            this.loadChart.Name = "loadChart";
            this.loadChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series69.BorderWidth = 2;
            series69.ChartArea = "LoadArea";
            series69.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series69.Legend = "Legend1";
            series69.Name = "Motor A";
            series70.BorderWidth = 2;
            series70.ChartArea = "LoadArea";
            series70.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series70.Legend = "Legend1";
            series70.Name = "Motor B";
            series71.BorderWidth = 2;
            series71.ChartArea = "LoadArea";
            series71.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series71.Legend = "Legend1";
            series71.Name = "Motor C";
            series72.BorderWidth = 2;
            series72.ChartArea = "LoadArea";
            series72.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series72.Legend = "Legend1";
            series72.Name = "Motor D";
            this.loadChart.Series.Add(series69);
            this.loadChart.Series.Add(series70);
            this.loadChart.Series.Add(series71);
            this.loadChart.Series.Add(series72);
            title18.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title18.Name = "Title1";
            title18.Text = "Relative Load";
            this.loadChart.Titles.Add(title18);
            // 
            // Motor1
            // 
            resources.ApplyResources(this.Motor1, "Motor1");
            this.Motor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.Motor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.Motor1.Name = "Motor1";
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
            // rpmA
            // 
            this.rpmA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rpmA.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.rpmA, "rpmA");
            this.rpmA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.rpmA.Name = "rpmA";
            // 
            // endX
            // 
            resources.ApplyResources(this.endX, "endX");
            this.endX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.endX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endX.Name = "endX";
            // 
            // endY
            // 
            resources.ApplyResources(this.endY, "endY");
            this.endY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.endY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.endY.Name = "endY";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.maxZBox);
            this.panel1.Controls.Add(this.maxYBox);
            this.panel1.Controls.Add(this.maxXBox);
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.motorDBar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rpmD);
            this.panel1.Controls.Add(this.motorCBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rpmC);
            this.panel1.Controls.Add(this.motorBBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rpmB);
            this.panel1.Controls.Add(this.motorABar);
            this.panel1.Controls.Add(this.endZBox);
            this.panel1.Controls.Add(this.endYBox);
            this.panel1.Controls.Add(this.Motor1);
            this.panel1.Controls.Add(this.endXBox);
            this.panel1.Controls.Add(this.rpmA);
            this.panel1.Controls.Add(this.endZ);
            this.panel1.Controls.Add(this.offButton);
            this.panel1.Controls.Add(this.endY);
            this.panel1.Controls.Add(this.onButton);
            this.panel1.Controls.Add(this.endX);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            // maxYBox
            // 
            this.maxYBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.maxYBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxYBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.maxYBox, "maxYBox");
            this.maxYBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.maxYBox.Name = "maxYBox";
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
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label6.Name = "label6";
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label5.Name = "label5";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.ShortcutsEnabled = false;
            // 
            // motorDBar
            // 
            resources.ApplyResources(this.motorDBar, "motorDBar");
            this.motorDBar.Maximum = 90;
            this.motorDBar.Name = "motorDBar";
            this.motorDBar.TickFrequency = 5;
            this.motorDBar.Value = 30;
            this.motorDBar.Scroll += new System.EventHandler(this.motorDBar_Scroll);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label4.Name = "label4";
            // 
            // rpmD
            // 
            this.rpmD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rpmD.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.rpmD, "rpmD");
            this.rpmD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.rpmD.Name = "rpmD";
            // 
            // motorCBar
            // 
            resources.ApplyResources(this.motorCBar, "motorCBar");
            this.motorCBar.Maximum = 90;
            this.motorCBar.Name = "motorCBar";
            this.motorCBar.TickFrequency = 5;
            this.motorCBar.Value = 30;
            this.motorCBar.Scroll += new System.EventHandler(this.motorCBar_Scroll);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label3.Name = "label3";
            // 
            // rpmC
            // 
            this.rpmC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rpmC.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.rpmC, "rpmC");
            this.rpmC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.rpmC.Name = "rpmC";
            // 
            // motorBBar
            // 
            resources.ApplyResources(this.motorBBar, "motorBBar");
            this.motorBBar.Maximum = 90;
            this.motorBBar.Name = "motorBBar";
            this.motorBBar.TickFrequency = 5;
            this.motorBBar.Value = 30;
            this.motorBBar.Scroll += new System.EventHandler(this.motorBBar_Scroll);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(144)))), ((int)(((byte)(195)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.label2.Name = "label2";
            // 
            // rpmB
            // 
            this.rpmB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rpmB.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.rpmB, "rpmB");
            this.rpmB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.rpmB.Name = "rpmB";
            // 
            // motorABar
            // 
            resources.ApplyResources(this.motorABar, "motorABar");
            this.motorABar.Maximum = 90;
            this.motorABar.Name = "motorABar";
            this.motorABar.TickFrequency = 5;
            this.motorABar.Value = 30;
            this.motorABar.Scroll += new System.EventHandler(this.motorABar_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.panel3.Controls.Add(this.webView);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.angle4Box);
            this.panel3.Controls.Add(this.angle3Box);
            this.panel3.Controls.Add(this.angle2Box);
            this.panel3.Controls.Add(this.angle1Box);
            this.panel3.Controls.Add(this.tempChart);
            this.panel3.Controls.Add(this.powerChart);
            this.panel3.Controls.Add(this.loadChart);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox7.Name = "textBox7";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox6.Name = "textBox6";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox4.Name = "textBox4";
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
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.webView, "webView");
            this.webView.Name = "webView";
            this.webView.Source = new System.Uri("http://192.168.0.160:6302/", System.UriKind.Absolute);
            this.webView.ZoomFactor = 1D;
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
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorDBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorCBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorABar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart powerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart loadChart;
        private System.Windows.Forms.Label Motor1;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox baudRateBox;
        private System.Windows.Forms.TextBox rpmA;
        private System.Windows.Forms.Label endX;
        private System.Windows.Forms.Label endY;
        private System.Windows.Forms.Label endZ;
        private System.Windows.Forms.TextBox endXBox;
        private System.Windows.Forms.TextBox endYBox;
        private System.Windows.Forms.TextBox endZBox;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar motorABar;
        private System.Windows.Forms.TrackBar motorCBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rpmC;
        private System.Windows.Forms.TrackBar motorBBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rpmB;
        private System.Windows.Forms.TrackBar motorDBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rpmD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Panel panel3;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button monitoringButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox angle4Box;
        private System.Windows.Forms.TextBox angle3Box;
        private System.Windows.Forms.TextBox angle2Box;
        private System.Windows.Forms.TextBox angle1Box;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox maxZBox;
        private System.Windows.Forms.TextBox maxYBox;
        private System.Windows.Forms.TextBox maxXBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

