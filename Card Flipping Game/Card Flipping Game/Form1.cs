using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flipping_Game
{
    public partial class Form1 : Form
    {
        Button[] btn = new Button[16];
        Image image_back = Image.FromFile(Application.StartupPath + "\\card.jpg");
        Image[] image_list = new Image[8];
        Image[] image_temp = new Image[16];
        Image img;
        bool[] solve = new bool[16];
        int x;
        Button bt;
        int pair = 0;
        int[] btn_image = new int[16];
        int temp_pb_image;
        int last_card = 0;
        int success = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            for (int i = 0; i < 16; i++)
            {
                btn[i] = new Button();
                btn[i].Width = 80;
                btn[i].Height = 110;
                btn[i].Visible = true;
                btn[i].BackgroundImage = image_back;
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn[i].Top = 40 + (i / 4) * 120;
                btn[i].Left = 20 + (i % 4) * 100;
                btn[i].Click += new EventHandler(btn_Click);
                btn[i].Name = i.ToString();
                btn[i].Enabled = false;
                this.Controls.Add(btn[i]);
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
        private void button1_Click(object sender, EventArgs e)
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
                imark[s]--;
            }
            for (int i = 0; i < 20; i++)
            {
                int t = rnd.Next(0, 16);
                int u = rnd.Next(0, 16);
                img = image_temp[t];
                image_temp[t] = image_temp[u];
                image_temp[u] = img;
                temp_pb_image = btn_image[t];
                btn_image[t] = btn_image[u];
                btn_image[u] = temp_pb_image;
            }
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
                        pair = 0;
                        success++;
                        if (success == 8)
                        {
                            MessageBox.Show("你贏了!");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            btn[i].Enabled = false;
                        }
                        button2.Enabled = true;
                        pair = 0;
                    }
                }
                else
                    last_card = x;
            }
        }
        bool check_2_cards(int x, int y)
        {
            if (btn_image[x] == btn_image[y])
                return true;
            else
                return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
