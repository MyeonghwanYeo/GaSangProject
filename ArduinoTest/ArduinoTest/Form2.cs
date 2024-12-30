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
        string password = "123456";

        public Form2()
        {
            InitializeComponent();

            passwordBox.Focus();

            presentPWBox.Enabled = false;
            newPWBox.Enabled = false;
            newPWCheckBox.Enabled = false;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            // 로그인 창에서 비밀번호 입력에 따른 메뉴창 또는 메세지박스 띄우기 
            if (passwordBox.Text == password)
            {
                MainPanelVisibility();
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

        private void changeButton_Click(object sender, EventArgs e)
        {
            passwordBox.Text = "";

            passwordBox.Enabled = false;
            presentPWBox.Enabled = true;
            newPWBox.Enabled = true;
            newPWCheckBox.Enabled = true;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            presentPWBox.Text = "";
            newPWBox.Text = "";
            newPWCheckBox.Text = "";

            presentPWBox.Enabled = false;
            newPWBox.Enabled = false;
            newPWCheckBox.Enabled = false;
            passwordBox.Enabled = true;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void changePWButton_Click(object sender, EventArgs e)
        {
            if (presentPWBox.Text == password)
            {
                if (newPWBox.Text == newPWCheckBox.Text)
                {
                    password = newPWBox.Text;

                    MessageBox.Show("Your password is changed.", "Password change message", MessageBoxButtons.OK);

                    cancelButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("New passwords are not match.", "Password change error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The present password is incorrect.", "Password change error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // 현재 창 "Form2"를 닫고, 모니터링 창 "Form1" 열기
            this.Visible = false;

            Form1 showForm1 = new Form1();
            showForm1.ShowDialog();

            Application.Exit();
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

        public void MainPanelVisibility()
        {
            panel2.Visible = false;
            monitoringIcon.Visible = true;
            simulationIcon.Visible = true;
            logOutIcon.Visible = true;

            passwordBox.Text = "";
            passwordBox.Enabled = false;
        }
    }
}
