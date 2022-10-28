using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Administrator
{
    public partial class Form1 : Form
    {
        List<string> link = new List<string>();
        List<string> user = new List<string>();
        List<string> password = new List<string>();
        int repeat = 0, time = 0, delete = 0, isdelete;
        int[] print = new int[100];
        public Form1()
        {
            InitializeComponent();
            lblShow.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            for (int i = 0; i < link.Count; i++)
            {
                if (link[i].Contains(textBox1.Text))
                {
                    print[i] = 1;
                }
            }
            for (int i = 0; i < link.Count; i++)
            {
                if (print[i] == 1 && link[i] != "")
                {
                    textBox5.Text = textBox5.Text + "連結:" + link[i] + "\r\n" + "使用者:" + user[i] + "\r\n" + "密碼:" + password[i] + "\r\n" + "=========================================================" + "\r\n";
                    print[i] = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblShow.Text = "我是狀態列";
            if (button3.Text == "新增或刪除")
            {
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                label3.Visible = false;
                lblShow.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                textBox5.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button3.Text = "回主畫面";
            }
            else if (button3.Text == "回主畫面")
            {
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                label3.Visible = true;
                lblShow.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox5.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button3.Text = "新增或刪除";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < link.Count; i++)
            {
                if (textBox2.Text == link[i])
                {
                    repeat = 1;
                }
            }
            if (repeat == 0)
            {
                link.Add(textBox2.Text);
                user.Add(textBox3.Text);
                password.Add(textBox4.Text);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                lblShow.Text = "新增完成";
            }
            else
            {
                lblShow.Text = "帳號已存在";
                repeat = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblShow.Text = "我是狀態列";
            for (int i = 0; i < user.Count; i++)
            {
                if (textBox2.Text == link[i] && textBox3.Text == user[i] && textBox4.Text == password[i])
                {
                    delete = 1;
                    isdelete = i;
                }
                if (delete == 1)
                {
                    lblShow.Text = "刪除完成";
                    link[isdelete] = "";
                    user[isdelete] = "";
                    password[isdelete] = "";
                }
                else
                {
                    lblShow.Text = "帳號不存在或密碼錯誤";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            for (int i = 0; i < password.Count; i++)
            {
                for (int j = i + 1; j < password.Count; j++)
                {
                    if (password[i] == password[j])
                    {
                        print[i] = 1;
                        print[j] = 1;
                    }
                }
            }
            for (int i = 0; i < link.Count; i++)
            {
                if (print[i] == 1 && link[i] != "")
                {
                    textBox5.Text = textBox5.Text + "連結:" + link[i] + "\r\n" + "使用者:" + user[i] + "\r\n" + "密碼:" + password[i] + "\r\n" + "=========================================================" + "\r\n";
                    print[i] = 0;
                    time++;
                }
            }
        }
    }
}
