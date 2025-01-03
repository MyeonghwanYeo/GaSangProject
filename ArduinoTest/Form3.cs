using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void simulationButton_Click(object sender, EventArgs e)
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
