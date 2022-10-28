using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Word
{
    public partial class Form1 : Form
    {
        Button[] btn = new Button[26];
        int x = 0;
        Button bt;
        int appear = 0, wrong = 0, success = 0, num = 0;
        int[] isappear = new int[26];
        string objective, guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objective = textBox1.Text.ToUpper();
            char[] words = objective.ToCharArray();

            foreach (char word in words)
            {
                if (word < 'A' || word > 'Z')
                {
                    textBox1.Clear();
                }
            }
            if (textBox1.Text != "")
            {
                panel2.Visible = true;
                panel1.Visible = false;
                timer1.Enabled = true;
                objective = textBox1.Text.ToUpper();
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    label5.Text += "_ ";
                    guess = label5.Text;
                }
                textBox1.Enabled = false;
                this.KeyPreview = true;
                this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            label3.Text = "時間: " + num.ToString();
            num++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Left = Convert.ToInt16(0.3 * (panel2.Width - label5.Width));
            panel2.Visible = false;
            timer1.Enabled = false;
            for (int i = 0; i < 26; i++)
            {
                btn[i] = new Button();
                panel2.Controls.Add(btn[i]);
                btn[i].Width = 30;
                btn[i].Height = 30;
                if (i >= 0 && i <= 9)
                {
                    btn[i].Top = 30;
                    btn[i].Left = 75 + 35 * (i % 10);
                }
                if (i >= 10 && i <= 19)
                {
                    btn[i].Top = 70;
                    btn[i].Left = 75 + 35 * (i % 10);
                }
                if (i >= 20 && i <= 25)
                {
                    btn[i].Top = 110;
                    btn[i].Left = 145 + 35 * (i % 10);
                }
                btn[i].Visible = true;
                btn[i].Text = Convert.ToChar(i + 'A').ToString();
                btn[i].Click += new EventHandler(btn_Click);
                btn[i].Name = i.ToString();
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
            x = e.KeyChar - 'A';
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (objective[i] == e.KeyChar && isappear[i] == 0)
                {
                    appear = 1;
                    btn[x].BackColor = Color.LightGreen;
                    success += 1;
                    guess = guess.Remove(2 * i, 1);
                    guess = guess.Insert(2 * i, Convert.ToChar(x + 'A').ToString());
                    label5.Text = guess;
                    isappear[i] = 1;
                }
                else if (objective[i] == e.KeyChar)
                {
                    appear = 1;
                }
            }
            if (appear == 0)
            {
                btn[x].Visible = false;
                wrong += 1;
                label4.Text = "猜錯次數: " + wrong + "次";
            }
            DialogResult result;
            appear = 0;
            if (wrong == 6)
            {
                label5.Text = textBox1.Text.ToUpper();
                timer1.Enabled = false;
                result = MessageBox.Show("You Lose!");
                if (result == DialogResult.OK)
                {
                    restart();
                }
            }
            else if (success == textBox1.Text.Length)
            {
                timer1.Enabled = false;
                result = MessageBox.Show("花費時間:" + num.ToString() + "\r\n猜錯" + wrong + "次", "You Win!");
                if (result == DialogResult.OK)
                {
                    restart();
                }
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            bt = (Button)sender;
            x = Convert.ToInt16(bt.Name);
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (objective[i] == x + 'A')
                {
                    appear = 1;
                    btn[x].BackColor = Color.LightGreen;
                    success += 1;
                    guess = guess.Remove(2 * i, 1);
                    guess = guess.Insert(2 * i, Convert.ToChar(x + 'A').ToString());
                    label5.Text = guess;
                }
            }
            if (appear == 0)
            {
                btn[x].Visible = false;
                wrong += 1;
                label4.Text = "猜錯次數: " + wrong + "次";
            }
            DialogResult result;
            appear = 0;
            if (wrong == 6)
            {
                timer1.Enabled = false;
                result = MessageBox.Show("You Lose!");
                if (result == DialogResult.OK)
                {
                    restart();
                }
            }
            else if (success == textBox1.Text.Length)
            {
                timer1.Enabled = false;
                result = MessageBox.Show("花費時間:" + num.ToString() + "\r\n猜錯" + wrong + "次", "You Win!");
                if (result == DialogResult.OK)
                {
                    restart();
                }
            }
        }
        private void restart()
        {
            for (int i = 0; i < 26; i++)
            {
                btn[i].Visible = true;
                btn[i].BackColor = Color.White;
                panel2.Visible = false;
                panel1.Visible = true;
                textBox1.Text = "";
                num = 0;
                wrong = 0;
                success = 0;
                label3.Text = "時間: " + num.ToString();
                label4.Text = "猜錯次數: " + wrong + "次";
                guess = "";
                label5.Text = guess;
                isappear[i] = 0;
            }
            textBox1.Enabled = true;
            this.KeyPreview = false;
            this.KeyPress -= new KeyPressEventHandler(Form1_KeyPress);
        }
    }
}
