using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Phone
{
    public partial class Form1 : Form
    {
        FileInfo[] Sound1 = new FileInfo[4];
        FileInfo[] Sound2 = new FileInfo[3];
        SoundPlayer player1 = new SoundPlayer();
        SoundPlayer player2 = new SoundPlayer();
        Button[] btn = new Button[15];
        Image[] image_list = new Image[16];
        Boolean one = true;
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Telephone";
            tabPage2.Text = "Log";
            label1.Text = "Telephone";
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            for (int i = 0; i < 15; i++)
            {
                btn[i] = new Button();
                btn[i].Width = 50;
                btn[i].Height = 50;
                btn[i].Left = 250 + 60 * (i % 3);
                btn[i].Top = 70 + 60 * (i / 3);
                tabPage1.Controls.Add(btn[i]);
                btn[i].Name = i.ToString();
                btn[i].Click += new EventHandler(btn_click);
                btn[i].Font = new Font("新細明體", 20F, FontStyle.Bold);
                if (i >= 0 && i <= 8)
                    btn[i].Text = (i + 1).ToString();
                else if (i == 9)
                    btn[i].Text = "*";
                else if (i == 10)
                    btn[i].Text = "0";
                else if (i == 11)
                    btn[i].Text = "#";
                else if (i == 12)
                    btn[i].Text = "❌";
                else if (i == 13)
                    btn[i].Text = "📱";
                else if (i == 14)
                    btn[i].Text = "⬅";
            }
            Sound1[0] = new FileInfo("../../audio/697.wav");
            Sound1[1] = new FileInfo("../../audio/770.wav");
            Sound1[2] = new FileInfo("../../audio/852.wav");
            Sound1[3] = new FileInfo("../../audio/941.wav");

            Sound2[0] = new FileInfo("../../audio/1209.wav");
            Sound2[1] = new FileInfo("../../audio/1336.wav");
            Sound2[2] = new FileInfo("../../audio/1477.wav");
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            one = true;
            player1.Stop();
            player2.Stop();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (label1.Text == "Telephone")
                label1.Text = "";

            if (e.Shift)
            {
                if (e.KeyCode == Keys.D3)
                {
                    if (one)
                    {
                        label1.Text += "#";
                        index = 11;
                    }
                    one = false;
                }
                else if (e.KeyCode == Keys.D8)
                {
                    if (one)
                    {
                        label1.Text += "*";
                        index = 9;
                    }
                    one = false;
                }
                PlaySound(index);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (one)
                {
                    if (btn[0].Enabled)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13)
                            {
                                btn[i].Enabled = false;
                            }
                        }
                        btn[13].Text = "📵";
                    }
                    else if (!btn[0].Enabled)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13)
                            {
                                btn[i].Enabled = true;
                            }
                        }
                        textBox1.Text += label1.Text += "\r\n";
                        label1.Text = "Telephone";
                        btn[13].Text = "📱";
                    }
                }
                one = false;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (one)
                    label1.Text = label1.Text.Substring(0, Math.Max(0, label1.Text.Length - 1));
                one = false;
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (one)
                {
                    label1.Text += e.KeyCode.ToString()[1];
                    index = Convert.ToInt16(e.KeyCode.ToString()[1]) - Convert.ToInt16('0');
                    if (index >= 1 && index <= 9)
                    {
                        index -= 1;
                    }
                    else if (index == 0)
                    {
                        index = 10;
                    }
                }
                PlaySound(index);
                one = false;
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int index = Convert.ToInt16(bt.Name);
            if (label1.Text == "Telephone")
                label1.Text = "";
            switch (index)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    label1.Text += (index + 1).ToString();
                    break;
                case 9:
                    label1.Text += "*";
                    break;
                case 10:
                    label1.Text += "0";
                    break;
                case 11:
                    label1.Text += "#";
                    break;
                case 12:
                    label1.Text = "";
                    break;
                case 13:
                    if (btn[0].Enabled)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13)
                            {
                                btn[i].Enabled = false;
                            }
                        }
                        btn[13].Text = "📵";
                    }
                    else if (!btn[0].Enabled)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13)
                            {
                                btn[i].Enabled = true;
                            }
                        }
                        textBox1.Text += label1.Text += "\r\n";
                        label1.Text = "Telephone";
                        btn[13].Text = "📱";
                    }
                    break;
                case 14:
                    label1.Text = label1.Text.Substring(0, Math.Max(0, label1.Text.Length - 1));
                    break;
            }
            if (index >= 0 && index <= 11)
            {
                PlaySound(index);
            }
        }
        private void PlaySound(int index)
        {
            player1.SoundLocation = Sound1[index / 3].ToString();
            player1.Play();
            player2.SoundLocation = Sound2[index % 3].ToString();
            player2.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Empty String");
            }
            else if (!File.Exists(textBox2.Text))
            {
                MessageBox.Show("Directory Not Found");
            }
            else
            {
                StreamWriter sw = new StreamWriter(textBox2.Text);
                sw.Write(textBox1.Text);
                sw.Close();
                FileInfo fi = new FileInfo(textBox2.Text);
                MessageBox.Show("Done\n" + textBox2.Text);
            }
        }
    }
}
