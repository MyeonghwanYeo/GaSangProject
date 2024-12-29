using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTest
{
    public partial class Form2 : Form
    {
        int password = 123456;

        public Form2()
        {
            InitializeComponent();

            passwordBox.Focus();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            // 로그인 화면에서 비밀번호 입력에 따른 메뉴창 또는 메세지박스 띄우기 
            if (passwordBox.Text == password.ToString())
            {
                panel2.Visible = false;
                monitoringIcon.Visible = true;
                simulationIcon.Visible = true;
                logOutIcon.Visible = true;

                // 기존 입력한 비밀번호 지운 후 비밀번호 창 비활성화
                passwordBox.Text = "";
                passwordBox.Enabled = false;
            }
            else if (passwordBox.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("It is not a registered password", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                passwordBox.Text = "";
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            // 로그인 창에서 엔터키를 누르면 "Log In" 버튼과 동인한 작업 수행
            if (e.KeyCode == Keys.Enter && panel2.Visible == true)
            {
                if (passwordBox.Text == password.ToString())
                {
                    e.SuppressKeyPress = true;
                }

                this.logInButton_Click(sender, e);
            }
        }

        private void logOutIcon_Click(object sender, EventArgs e)
        {
            // 로그아웃 버튼 클릭 시, 다시 로그인 창으로 전환
            monitoringIcon.Visible = false;
            simulationIcon.Visible = false;
            logOutIcon.Visible = false;
            panel2.Visible = true;

            // 비밀번호 입력창 활성화
            passwordBox.Enabled = true;
            passwordBox.Focus();
        }

        private void monitoringIcon_Click(object sender, EventArgs e)
        {

        }

        private void monitoringIcon_MouseEnter(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            monitoringIcon.Image = Image.FromFile(path + @"\Resources\Monitoring_Icon_Mouse.png");
        }

        private void monitoringIcon_MouseLeave(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            monitoringIcon.Image = Image.FromFile(path + @"\Resources\Monitoring_Icon.png");
        }
        private void SimulationIcon_MouseEnter(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            simulationIcon.Image = Image.FromFile(path + @"\Resources\Simulation_Icon_Mouse.png");
        }

        private void SimulationIcon_MouseLeave(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            simulationIcon.Image = Image.FromFile(path + @"\Resources\Simulation_Icon.png");
        }

        private void logOutIcon_MouseEnter(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            logOutIcon.Image = Image.FromFile(path + @"\Resources\LogOut_Icon_Mouse.png");
        }

        private void logOutIcon_MouseLeave(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            logOutIcon.Image = Image.FromFile(path + @"\Resources\LogOut_Icon.png");
        }
    }
}
