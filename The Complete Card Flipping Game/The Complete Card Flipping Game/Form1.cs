using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Complete_Card_Flipping_Game
{
    public partial class Form1 : Form
    {
        int score = 100;
        Button[] btn = new Button[16];
        Image image_back = Image.FromFile(Application.StartupPath + "\\card.jpg");
        bool[] solve = new bool[16];
        Random rnd = new Random();
        Image[] image_list = new Image[8];
        Image[] image_temp = new Image[16];
        int[] btn_image = new int[16];
        Image img;
        int temp_btn_image;
        Button bt;
        int x;
        int pair = 0;
        int last_card = 0;
        int success = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "分數:";
            label2.Text = score.ToString();
            label3.Text = "名稱:";
            button1.Text = "開始遊戲";
            button2.Text = "繼續";
            button3.Text = "重新開始";
            button4.Text = "離開遊戲";
            button2.Enabled = false;
            tabPage1.Text = "遊玩區";
            tabPage2.Text = "歷史紀錄區";
            for (int i = 0; i < 16; i++)
            {
                btn[i] = new Button();
                tabPage1.Controls.Add(btn[i]);
                btn[i].Width = 80;
                btn[i].Height = 110;
                btn[i].Visible = false;
                btn[i].Top = 60 + (i / 4) * 120;
                btn[i].Left = 20 + (i % 4) * 100;
                btn[i].BackgroundImage = image_back;
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].Click += new EventHandler(btn_Click);
                btn[i].Name = i.ToString();
                btn[i].Enabled = false;
                solve[i] = false;
            }
            image_list[0] = Image.FromFile(Application.StartupPath + "\\01.jpg");
            image_list[1] = Image.FromFile(Application.StartupPath + "\\02.jpg");
            image_list[2] = Image.FromFile(Application.StartupPath + "\\03.jpg");
            image_list[3] = Image.FromFile(Application.StartupPath + "\\04.jpg");
            image_list[4] = Image.FromFile(Application.StartupPath + "\\05.jpg");
            image_list[5] = Image.FromFile(Application.StartupPath + "\\06.jpg");
            image_list[6] = Image.FromFile(Application.StartupPath + "\\07.jpg");
            image_list[7] = Image.FromFile(Application.StartupPath + "\\08.jpg");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            bt = (Button)sender;
            x = Convert.ToInt16(bt.Name);
            if (!solve[x])
            {
                bt.Enabled = false;
                bt.BackgroundImage = image_list[btn_image[x]];
                pair++;
                if (pair == 2)
                {
                    if (check_2_cards(x, last_card) == true)
                    {
                        btn[x].Image = btn[x].BackgroundImage;
                        btn[x].Enabled = false;
                        btn[last_card].Image = btn[last_card].BackgroundImage;
                        btn[last_card].Enabled = false;
                        solve[x] = true;
                        solve[last_card] = true;
                        success++;
                        score += 10;
                        label2.Text = score.ToString();
                        if (success == 8)
                        {
                            DialogResult result;
                            result = MessageBox.Show("分數:" + score, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                            textBox2.Text += textBox1.Text + "得分為:" + score + "\r\n\r\n";
                            if (result == DialogResult.Retry)
                            {
                                restart();
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            btn[i].Enabled = false;
                        }
                        button2.Enabled = true;
                        score -= 5;
                        label2.Text = score.ToString();
                    }
                    pair = 0;
                }
                else
                {
                    last_card = x;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (textBox1.Text.Length < 3 || textBox1.Text.Length > 10)
            {
                MessageBox.Show("名稱不合格式(>=3&&<=10)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                button1.Enabled = false;
                int[] imark = { 2, 2, 2, 2, 2, 2, 2, 2 };
                for (int i = 0; i < 16; i++)
                {
                    int s;
                    do { s = rnd.Next(0, 8); } while (imark[s] == 0);
                    image_temp[i] = image_list[s];
                    btn_image[i] = s;
                    btn[i].Enabled = true;
                    btn[i].Visible = true;
                    imark[s]--;
                }
                for (int i = 0; i < 20; i++)
                {
                    int t = rnd.Next(0, 16);
                    int u = rnd.Next(0, 16);
                    img = image_temp[t];
                    image_temp[t] = image_temp[u];
                    image_temp[u] = img;
                    temp_btn_image = btn_image[t];
                    btn_image[t] = btn_image[u];
                    btn_image[u] = temp_btn_image;
                }
            }
        }
        bool check_2_cards(int x, int y)
        {
            if (btn_image[x] == btn_image[y])
                return true;
            else
                return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("確定要離開遊戲嗎？", "離開遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn[x].BackgroundImage = image_back;
            btn[last_card].BackgroundImage = image_back;
            for (int i = 0; i < 16; i++)
            {
                if (solve[i] == false)
                {
                    btn[i].Enabled = true;
                }
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            restart();
        }
        private void restart()
        {
            button1.Enabled = true;
            textBox1.Text = "";
            score = 100;
            label2.Text = score.ToString();
            success = 0;
            pair = 0;
            for (int i = 0; i < 16; i++)
            {
                btn[i].Image = null;
                btn[i].Visible = false;
                btn[i].BackgroundImage = image_back;
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].Name = i.ToString();
                solve[i] = false;
            }
        }
    }
}
