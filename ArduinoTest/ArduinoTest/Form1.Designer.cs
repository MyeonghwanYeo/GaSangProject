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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Time Step [sec]";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea1.Name = "TempArea";
            this.tempChart.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.tempChart, "tempChart");
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.tempChart.Legends.Add(legend1);
            this.tempChart.Name = "tempChart";
            this.tempChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 2;
            series1.ChartArea = "TempArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Segoe UI", 10F);
            series1.Legend = "Legend1";
            series1.MarkerSize = 0;
            series1.Name = "Motor A";
            series2.BorderWidth = 2;
            series2.ChartArea = "TempArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBackColor = System.Drawing.Color.Yellow;
            series2.Legend = "Legend1";
            series2.MarkerSize = 0;
            series2.Name = "Motor B";
            series3.BorderWidth = 2;
            series3.ChartArea = "TempArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelBackColor = System.Drawing.Color.Yellow;
            series3.Legend = "Legend1";
            series3.MarkerSize = 0;
            series3.Name = "Motor C";
            series4.BorderWidth = 2;
            series4.ChartArea = "TempArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.LabelBackColor = System.Drawing.Color.Yellow;
            series4.Legend = "Legend1";
            series4.MarkerSize = 0;
            series4.Name = "Motor D";
            this.tempChart.Series.Add(series1);
            this.tempChart.Series.Add(series2);
            this.tempChart.Series.Add(series3);
            this.tempChart.Series.Add(series4);
            this.tempChart.TabStop = false;
            title1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title1.Name = "Title1";
            title1.Text = "Temperature [°C]";
            this.tempChart.Titles.Add(title1);
            // 
            // powerChart
            // 
            this.powerChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Time Step [sec]";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea2.Name = "PowerArea";
            this.powerChart.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.powerChart, "powerChart");
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.powerChart.Legends.Add(legend2);
            this.powerChart.Name = "powerChart";
            this.powerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.BorderWidth = 2;
            series5.ChartArea = "PowerArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Motor A";
            series6.BorderWidth = 2;
            series6.ChartArea = "PowerArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Motor B";
            series7.BorderWidth = 2;
            series7.ChartArea = "PowerArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Motor C";
            series8.BorderWidth = 2;
            series8.ChartArea = "PowerArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            series8.Legend = "Legend1";
            series8.Name = "Motor D";
            this.powerChart.Series.Add(series5);
            this.powerChart.Series.Add(series6);
            this.powerChart.Series.Add(series7);
            this.powerChart.Series.Add(series8);
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            title2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title2.Name = "Title1";
            title2.Text = "Power [W]";
            this.powerChart.Titles.Add(title2);
            // 
            // loadChart
            // 
            this.loadChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Time Step [sec]";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea3.Name = "LoadArea";
            this.loadChart.ChartAreas.Add(chartArea3);
            resources.ApplyResources(this.loadChart, "loadChart");
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.loadChart.Legends.Add(legend3);
            this.loadChart.Name = "loadChart";
            this.loadChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.BorderWidth = 2;
            series9.ChartArea = "LoadArea";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Motor A";
            series10.BorderWidth = 2;
            series10.ChartArea = "LoadArea";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Motor B";
            series11.BorderWidth = 2;
            series11.ChartArea = "LoadArea";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Motor C";
            series12.BorderWidth = 2;
            series12.ChartArea = "LoadArea";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Motor D";
            this.loadChart.Series.Add(series9);
            this.loadChart.Series.Add(series10);
            this.loadChart.Series.Add(series11);
            this.loadChart.Series.Add(series12);
            title3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title3.Name = "Title1";
            title3.Text = "Relative Load";
            this.loadChart.Titles.Add(title3);
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
            this.panel3.Controls.Add(this.webView);
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

