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
    public partial class Form2 : Form
    {
        int password = 123456;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 로그인 화면에서 비밀번호 입력에 따른 메뉴창 또는 메세지박스 띄우기 
            if (textBox1.Text == password.ToString())
            {
                panel2.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

                textBox1.Text = "";
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("It is not a registered password", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Text = "";
            }
        }

        private void TexttextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 로그인 창에서 엔터키를 누르면 "Log In" 버튼과 동인한 작업 수행
            if (e.KeyCode == Keys.Enter && panel2.Visible == true)
            {
                if (textBox1.Text == password.ToString())
                { 
                    e.SuppressKeyPress = true;
                }

                this.button4_Click(sender, e);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // 로그아웃 버튼 클릭 시, 다시 로그인 창으로 전환
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            panel2.Visible = true;

            textBox1.Focus();
        }
    }
}
