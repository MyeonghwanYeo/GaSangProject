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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.powerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Motor1 = new System.Windows.Forms.Label();
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rpmA = new System.Windows.Forms.TextBox();
            this.endX = new System.Windows.Forms.Label();
            this.endY = new System.Windows.Forms.Label();
            this.endZ = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.simulationButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monitoringButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.rpmD = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.rpmC = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rpmB = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // tempChart
            // 
            this.tempChart.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Title = "Time Step [sec]";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea4.Name = "TempArea";
            this.tempChart.ChartAreas.Add(chartArea4);
            resources.ApplyResources(this.tempChart, "tempChart");
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.tempChart.Legends.Add(legend4);
            this.tempChart.Name = "tempChart";
            this.tempChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series13.BorderWidth = 2;
            series13.ChartArea = "TempArea";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Font = new System.Drawing.Font("Segoe UI", 10F);
            series13.Legend = "Legend1";
            series13.MarkerSize = 0;
            series13.Name = "Motor A";
            series14.BorderWidth = 2;
            series14.ChartArea = "TempArea";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.LabelBackColor = System.Drawing.Color.Yellow;
            series14.Legend = "Legend1";
            series14.MarkerSize = 0;
            series14.Name = "Motor B";
            series15.BorderWidth = 2;
            series15.ChartArea = "TempArea";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.LabelBackColor = System.Drawing.Color.Yellow;
            series15.Legend = "Legend1";
            series15.MarkerSize = 0;
            series15.Name = "Motor C";
            series16.BorderWidth = 2;
            series16.ChartArea = "TempArea";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.LabelBackColor = System.Drawing.Color.Yellow;
            series16.Legend = "Legend1";
            series16.MarkerSize = 0;
            series16.Name = "Motor D";
            this.tempChart.Series.Add(series13);
            this.tempChart.Series.Add(series14);
            this.tempChart.Series.Add(series15);
            this.tempChart.Series.Add(series16);
            this.tempChart.TabStop = false;
            title4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title4.Name = "Title1";
            title4.Text = "Temperature [°C]";
            this.tempChart.Titles.Add(title4);
            // 
            // powerChart
            // 
            this.powerChart.BackColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.Title = "Time Step [sec]";
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea5.Name = "PowerArea";
            this.powerChart.ChartAreas.Add(chartArea5);
            resources.ApplyResources(this.powerChart, "powerChart");
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.powerChart.Legends.Add(legend5);
            this.powerChart.Name = "powerChart";
            this.powerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series17.BorderWidth = 2;
            series17.ChartArea = "PowerArea";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "Motor A";
            series18.BorderWidth = 2;
            series18.ChartArea = "PowerArea";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "Motor B";
            series19.BorderWidth = 2;
            series19.ChartArea = "PowerArea";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "Motor C";
            series20.BorderWidth = 2;
            series20.ChartArea = "PowerArea";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            series20.Legend = "Legend1";
            series20.Name = "Motor D";
            this.powerChart.Series.Add(series17);
            this.powerChart.Series.Add(series18);
            this.powerChart.Series.Add(series19);
            this.powerChart.Series.Add(series20);
            title5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            title5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title5.Name = "Title1";
            title5.Text = "Power [W]";
            this.powerChart.Titles.Add(title5);
            // 
            // loadChart
            // 
            this.loadChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.Title = "Time Step [sec]";
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            chartArea6.Name = "LoadArea";
            this.loadChart.ChartAreas.Add(chartArea6);
            resources.ApplyResources(this.loadChart, "loadChart");
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            legend6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.loadChart.Legends.Add(legend6);
            this.loadChart.Name = "loadChart";
            this.loadChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series21.BorderWidth = 2;
            series21.ChartArea = "LoadArea";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Motor A";
            series22.BorderWidth = 2;
            series22.ChartArea = "LoadArea";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "Motor B";
            series23.BorderWidth = 2;
            series23.ChartArea = "LoadArea";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Motor C";
            series24.BorderWidth = 2;
            series24.ChartArea = "LoadArea";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "Motor D";
            this.loadChart.Series.Add(series21);
            this.loadChart.Series.Add(series22);
            this.loadChart.Series.Add(series23);
            this.loadChart.Series.Add(series24);
            title6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            title6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            title6.Name = "Title1";
            title6.Text = "Relative Load";
            this.loadChart.Titles.Add(title6);
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
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
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
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.textBox6.Name = "textBox6";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(85)))));
            this.textBox7.Name = "textBox7";
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
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.monitoringButton);
            this.panel2.Controls.Add(this.simulationButton);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.comboBox2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.trackBar4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rpmD);
            this.panel1.Controls.Add(this.trackBar3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rpmC);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rpmB);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.Motor1);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.rpmA);
            this.panel1.Controls.Add(this.endZ);
            this.panel1.Controls.Add(this.offButton);
            this.panel1.Controls.Add(this.endY);
            this.panel1.Controls.Add(this.onButton);
            this.panel1.Controls.Add(this.endX);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            // trackBar4
            // 
            resources.ApplyResources(this.trackBar4, "trackBar4");
            this.trackBar4.Maximum = 90;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.TickFrequency = 5;
            this.trackBar4.Value = 30;
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
            // trackBar3
            // 
            resources.ApplyResources(this.trackBar3, "trackBar3");
            this.trackBar3.Maximum = 90;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.Value = 30;
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
            // trackBar2
            // 
            resources.ApplyResources(this.trackBar2, "trackBar2");
            this.trackBar2.Maximum = 90;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Value = 30;
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
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 90;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(145)))));
            this.panel3.Controls.Add(this.webView);
            this.panel3.Controls.Add(this.tempChart);
            this.panel3.Controls.Add(this.powerChart);
            this.panel3.Controls.Add(this.loadChart);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.webView, "webView");
            this.webView.Name = "webView";
            this.webView.Source = new System.Uri("http://192.168.0.160:99/", System.UriKind.Absolute);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox rpmA;
        private System.Windows.Forms.Label endX;
        private System.Windows.Forms.Label endY;
        private System.Windows.Forms.Label endZ;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rpmC;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rpmB;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rpmD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button monitoringButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

