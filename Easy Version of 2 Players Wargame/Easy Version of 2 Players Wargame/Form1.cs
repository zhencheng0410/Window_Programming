using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Version_of_2_Players_Wargame
{
    public partial class Form1 : Form
    {
        int num = 10, whatchess, x, location, type = 0;
        Button[] btn = new Button[42];
        Button bt;
        warrior bluewarrior = new warrior();
        warrior pinkwarrior = new warrior();
        magician bluemagician = new magician();
        magician pinkmagician = new magician();
        ranger blueranger = new ranger();
        ranger pinkranger = new ranger();
        int[] die = new int[7];
        int[] putchess = new int[42];
        int[] canattack = new int[42];
        int times = 0, blue = 0, pink = 0;
        bool isattack = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "開始遊戲";
            panel1.Visible = false;
            for (int i = 0; i < 42; i++)
            {
                btn[i] = new Button();
                panel1.Controls.Add(btn[i]);
                btn[i].Width = 50;
                btn[i].Height = 50;
                btn[i].Top = 60 + 50 * (i / 6);
                btn[i].Left = 130 + 50 * (i % 6);
                btn[i].Visible = true;
                btn[i].Name = i.ToString();
                btn[i].Click += new EventHandler(btn_Click);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            panel1.Visible = true;
            timer1.Enabled = true;
            label2.Text = num.ToString();
            label3.Text = "P1";
            label4.Text = "P2";
            button2.Text = "戰士:1顆";
            button3.Text = "法師:1顆";
            button4.Text = "遊俠:1顆";
            button5.Text = "戰士:1顆";
            button6.Text = "法師:1顆";
            button7.Text = "遊俠:1顆";
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            whatchess = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            whatchess = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            whatchess = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            whatchess = 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            type = 2;
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            switch (whatchess)
            {
                case 1:
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                    }
                    break;
                case 2:
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                        }
                    }
                    break;
                case 3:
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                            if (location % 6 <= 2)
                            {
                                canattack[location + 3] = 1;
                            }
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                            if (location % 6 >= 3)
                            {
                                canattack[location - 3] = 1;
                            }
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                            if (location / 6 >= 3)
                            {
                                canattack[location - 18] = 1;
                            }
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                            if (location / 6 <= 3)
                            {
                                canattack[location + 18] = 1;
                            }
                        }
                    }
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            switch (whatchess)
            {
                case 1:
                    for (int i = 0; i < 42; i++)
                    {
                        btn[i].Enabled = false;
                    }
                    if (location % 6 <= 4)
                    {
                        if (putchess[location + 1] == 0)
                        {
                            btn[location + 1].Enabled = true;
                        }
                    }
                    if (location % 6 <= 3)
                    {
                        if (putchess[location + 2] == 0)
                        {
                            btn[location + 2].Enabled = true;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        if (putchess[location - 1] == 0)
                        {
                            btn[location - 1].Enabled = true;
                        }
                    }
                    if (location % 6 >= 2)
                    {
                        if (putchess[location - 2] == 0)
                        {
                            btn[location - 2].Enabled = true;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        if (putchess[location - 6] == 0)
                        {
                            btn[location - 6].Enabled = true;
                        }
                    }
                    if (location / 6 >= 2)
                    {
                        if (putchess[location - 12] == 0)
                        {
                            btn[location - 12].Enabled = true;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        if (putchess[location + 6] == 0)
                        {
                            btn[location + 6].Enabled = true;
                        }
                    }
                    if (location / 6 <= 4)
                    {
                        if (putchess[location + 12] == 0)
                        {
                            btn[location + 12].Enabled = true;
                        }
                    }
                    type = 1;
                    break;
                case 2:
                    for (int i = 0; i < 42; i++)
                    {
                        btn[i].Enabled = false;
                    }
                    if (location % 6 <= 4)
                    {
                        if (putchess[location + 1] == 0)
                        {
                            btn[location + 1].Enabled = true;
                        }
                    }
                    if (location % 6 <= 3)
                    {
                        if (putchess[location + 2] == 0)
                        {
                            btn[location + 2].Enabled = true;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        if (putchess[location - 1] == 0)
                        {
                            btn[location - 1].Enabled = true;
                        }
                    }
                    if (location % 6 >= 2)
                    {
                        if (putchess[location - 2] == 0)
                        {
                            btn[location - 2].Enabled = true;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        if (putchess[location - 6] == 0)
                        {
                            btn[location - 6].Enabled = true;
                        }
                    }
                    if (location / 6 >= 2)
                    {
                        if (putchess[location - 12] == 0)
                        {
                            btn[location - 12].Enabled = true;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        if (putchess[location + 6] == 0)
                        {
                            btn[location + 6].Enabled = true;
                        }
                    }
                    if (location / 6 <= 4)
                    {
                        if (putchess[location + 12] == 0)
                        {
                            btn[location + 12].Enabled = true;
                        }
                    }
                    type = 1;
                    break;
                case 3:
                    for (int i = 0; i < 42; i++)
                    {
                        btn[i].Enabled = false;
                    }
                    if (location % 6 <= 4)
                    {
                        if (putchess[location + 1] == 0)
                        {
                            btn[location + 1].Enabled = true;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        if (putchess[location - 1] == 0)
                        {
                            btn[location - 1].Enabled = true;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        if (putchess[location - 6] == 0)
                        {
                            btn[location - 6].Enabled = true;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        if (putchess[location + 6] == 0)
                        {
                            btn[location + 6].Enabled = true;
                        }
                    }
                    type = 1;
                    break;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            type = 2;
            switch (whatchess)
            {
                case 1:
                    if (bluewarrior.mp >= 10)
                    {
                        bluewarrior.Skill();
                    }
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                    }
                    label5.Text = bluewarrior.character + "\nHP:" + bluewarrior.hp.ToString() + "\nMP:" + bluewarrior.mp.ToString() + "\nATK:" + bluewarrior.atk.ToString() + "\nATK Range:" + bluewarrior.atkrange.ToString() + "\nMOVE Range:" + bluewarrior.moverange.ToString();
                    break;
                case 2:
                    if (bluemagician.mp >= 10)
                    {
                        bluemagician.Skill();
                    }
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                        }
                    }
                    label5.Text = bluemagician.character + "\nHP:" + bluemagician.hp.ToString() + "\nMP:" + bluemagician.mp.ToString() + "\nATK:" + bluemagician.atk.ToString() + "\nATK Range:" + bluemagician.atkrange.ToString() + "\nMOVE Range:" + bluemagician.moverange.ToString();
                    break;
                case 3:
                    if (blueranger.mp >= 10)
                    {
                        blueranger.Skill();
                        if (location % 6 <= 1)
                        {
                            canattack[location + 4] = 1;
                        }
                        if (location % 6 >= 4)
                        {
                            canattack[location - 4] = 1;
                        }
                        if (location / 6 >= 4)
                        {
                            canattack[location - 24] = 1;
                        }
                        if (location / 6 <= 1)
                        {
                            canattack[location + 24] = 1;
                        }
                    }
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                            if (location % 6 <= 2)
                            {
                                canattack[location + 3] = 1;
                            }
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                            if (location % 6 >= 3)
                            {
                                canattack[location - 3] = 1;
                            }
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                            if (location / 6 >= 3)
                            {
                                canattack[location - 18] = 1;
                            }
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                            if (location / 6 <= 3)
                            {
                                canattack[location + 18] = 1;
                            }
                        }
                    }
                    label5.Text = blueranger.character + "\nHP:" + blueranger.hp.ToString() + "\nMP:" + blueranger.mp.ToString() + "\nATK:" + blueranger.atk.ToString() + "\nATK Range:" + blueranger.atkrange.ToString() + "\nMOVE Range:" + blueranger.moverange.ToString();
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            switch (whatchess)
            {
                case 4:
                    for (int i = 0; i < 42; i++)
                    {
                        btn[i].Enabled = false;
                    }
                    if (location % 6 <= 4)
                    {
                        if (putchess[location + 1] == 0)
                        {
                            btn[location + 1].Enabled = true;
                        }
                    }
                    if (location % 6 <= 3)
                    {
                        if (putchess[location + 2] == 0)
                        {
                            btn[location + 2].Enabled = true;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        if (putchess[location - 1] == 0)
                        {
                            btn[location - 1].Enabled = true;
                        }
                    }
                    if (location % 6 >= 2)
                    {
                        if (putchess[location - 2] == 0)
                        {
                            btn[location - 2].Enabled = true;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        if (putchess[location - 6] == 0)
                        {
                            btn[location - 6].Enabled = true;
                        }
                    }
                    if (location / 6 >= 2)
                    {
                        if (putchess[location - 12] == 0)
                        {
                            btn[location - 12].Enabled = true;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        if (putchess[location + 6] == 0)
                        {
                            btn[location + 6].Enabled = true;
                        }
                    }
                    if (location / 6 <= 4)
                    {
                        if (putchess[location + 12] == 0)
                        {
                            btn[location + 12].Enabled = true;
                        }
                    }
                    type = 1;
                    break;
                case 5:
                    for (int i = 0; i < 42; i++)
                    {
                        btn[i].Enabled = false;
                    }
                    if (location % 6 <= 4)
                    {
                        if (putchess[location + 1] == 0)
                        {
                            btn[location + 1].Enabled = true;
                        }
                    }
                    if (location % 6 <= 3)
                    {
                        if (putchess[location + 2] == 0)
                        {
                            btn[location + 2].Enabled = true;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        if (putchess[location - 1] == 0)
                        {
                            btn[location - 1].Enabled = true;
                        }
                    }
                    if (location % 6 >= 2)
                    {
                        if (putchess[location - 2] == 0)
                        {
                            btn[location - 2].Enabled = true;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        if (putchess[location - 6] == 0)
                        {
                            btn[location - 6].Enabled = true;
                        }
                    }
                    if (location / 6 >= 2)
                    {
                        if (putchess[location - 12] == 0)
                        {
                            btn[location - 12].Enabled = true;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        if (putchess[location + 6] == 0)
                        {
                            btn[location + 6].Enabled = true;
                        }
                    }
                    if (location / 6 <= 4)
                    {
                        if (putchess[location + 12] == 0)
                        {
                            btn[location + 12].Enabled = true;
                        }
                    }
                    type = 1;
                    break;
                case 6:
                    for (int i = 0; i < 42; i++)
                    {
                        btn[i].Enabled = false;
                    }
                    if (location % 6 <= 4)
                    {
                        if (putchess[location + 1] == 0)
                        {
                            btn[location + 1].Enabled = true;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        if (putchess[location - 1] == 0)
                        {
                            btn[location - 1].Enabled = true;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        if (putchess[location - 6] == 0)
                        {
                            btn[location - 6].Enabled = true;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        if (putchess[location + 6] == 0)
                        {
                            btn[location + 6].Enabled = true;
                        }
                    }
                    type = 1;
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            type = 2;
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            switch (whatchess)
            {
                case 4:
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                    }
                    break;
                case 5:
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                        }
                    }
                    break;
                case 6:
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                            if (location % 6 <= 2)
                            {
                                canattack[location + 3] = 1;
                            }
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                            if (location % 6 >= 3)
                            {
                                canattack[location - 3] = 1;
                            }
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                            if (location / 6 >= 3)
                            {
                                canattack[location - 18] = 1;
                            }
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                            if (location / 6 <= 3)
                            {
                                canattack[location + 18] = 1;
                            }
                        }
                    }
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            type = 2;
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
            switch (whatchess)
            {
                case 4:
                    if (pinkwarrior.mp >= 10)
                    {
                        pinkwarrior.Skill();
                    }
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                    }
                    label6.Text = pinkwarrior.character + "\nHP:" + pinkwarrior.hp.ToString() + "\nMP:" + pinkwarrior.mp.ToString() + "\nATK:" + pinkwarrior.atk.ToString() + "\nATK Range:" + pinkwarrior.atkrange.ToString() + "\nMOVE Range:" + pinkwarrior.moverange.ToString();
                    break;
                case 5:
                    if (pinkmagician.mp >= 10)
                    {
                        pinkmagician.Skill();
                    }
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                        }
                    }
                    label6.Text = pinkmagician.character + "\nHP:" + pinkmagician.hp.ToString() + "\nMP:" + pinkmagician.mp.ToString() + "\nATK:" + pinkmagician.atk.ToString() + "\nATK Range:" + pinkmagician.atkrange.ToString() + "\nMOVE Range:" + pinkmagician.moverange.ToString();
                    break;
                case 6:
                    if (pinkranger.mp >= 10)
                    {
                        pinkranger.Skill();
                        if (location % 6 <= 1)
                        {
                            canattack[location + 4] = 1;
                        }
                        if (location % 6 >= 4)
                        {
                            canattack[location - 4] = 1;
                        }
                        if (location / 6 >= 4)
                        {
                            canattack[location - 24] = 1;
                        }
                        if (location / 6 <= 1)
                        {
                            canattack[location + 24] = 1;
                        }
                    }
                    if (location % 6 <= 4)
                    {
                        canattack[location + 1] = 1;
                        if (location % 6 <= 3)
                        {
                            canattack[location + 2] = 1;
                            if (location % 6 <= 2)
                            {
                                canattack[location + 3] = 1;
                            }
                        }
                    }
                    if (location % 6 >= 1)
                    {
                        canattack[location - 1] = 1;
                        if (location % 6 >= 2)
                        {
                            canattack[location - 2] = 1;
                            if (location % 6 >= 3)
                            {
                                canattack[location - 3] = 1;
                            }
                        }
                    }
                    if (location / 6 >= 1)
                    {
                        canattack[location - 6] = 1;
                        if (location / 6 >= 2)
                        {
                            canattack[location - 12] = 1;
                            if (location / 6 >= 3)
                            {
                                canattack[location - 18] = 1;
                            }
                        }
                    }
                    if (location / 6 <= 5)
                    {
                        canattack[location + 6] = 1;
                        if (location / 6 <= 4)
                        {
                            canattack[location + 12] = 1;
                            if (location / 6 <= 3)
                            {
                                canattack[location + 18] = 1;
                            }
                        }
                    }
                    label6.Text = pinkranger.character + "\nHP:" + pinkranger.hp.ToString() + "\nMP:" + pinkranger.mp.ToString() + "\nATK:" + pinkranger.atk.ToString() + "\nATK Range:" + pinkranger.atkrange.ToString() + "\nMOVE Range:" + pinkranger.moverange.ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            whatchess += 1;
            if (whatchess > 6)
            {
                whatchess = 1;
            }
            while (die[whatchess] == 1)
            {
                whatchess++;
                if (whatchess > 6)
                {
                    whatchess = 1;
                }
            }

            if (whatchess <= 3)
            {
                label1.Text = "P1 Turn";
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
                label5.Text = bluewarrior.character + "\nHP:" + bluewarrior.hp.ToString() + "\nMP:" + bluewarrior.mp.ToString() + "\nATK:" + bluewarrior.atk.ToString() + "\nATK Range:" + bluewarrior.atkrange.ToString() + "\nMOVE Range:" + bluewarrior.moverange.ToString();
            }
            else
            {
                label1.Text = "P2 Turn";
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = true;
                button15.Enabled = true;
                button14.Enabled = true;
                button13.Enabled = true;
            }
            switch (whatchess)
            {
                case 1:
                    label5.Text = bluewarrior.character + "\nHP:" + bluewarrior.hp.ToString() + "\nMP:" + bluewarrior.mp.ToString() + "\nATK:" + bluewarrior.atk.ToString() + "\nATK Range:" + bluewarrior.atkrange.ToString() + "\nMOVE Range:" + bluewarrior.moverange.ToString();
                    break;
                case 2:
                    label5.Text = bluemagician.character + "\nHP:" + bluemagician.hp.ToString() + "\nMP:" + bluemagician.mp.ToString() + "\nATK:" + bluemagician.atk.ToString() + "\nATK Range:" + bluemagician.atkrange.ToString() + "\nMOVE Range:" + bluemagician.moverange.ToString();
                    break;
                case 3:
                    label5.Text = blueranger.character + "\nHP:" + blueranger.hp.ToString() + "\nMP:" + blueranger.mp.ToString() + "\nATK:" + blueranger.atk.ToString() + "\nATK Range:" + blueranger.atkrange.ToString() + "\nMOVE Range:" + blueranger.moverange.ToString();
                    break;
                case 4:
                    label6.Text = pinkwarrior.character + "\nHP:" + pinkwarrior.hp.ToString() + "\nMP:" + pinkwarrior.mp.ToString() + "\nATK:" + pinkwarrior.atk.ToString() + "\nATK Range:" + pinkwarrior.atkrange.ToString() + "\nMOVE Range:" + pinkwarrior.moverange.ToString();
                    break;
                case 5:
                    label6.Text = pinkmagician.character + "\nHP:" + pinkmagician.hp.ToString() + "\nMP:" + pinkmagician.mp.ToString() + "\nATK:" + pinkmagician.atk.ToString() + "\nATK Range:" + pinkmagician.atkrange.ToString() + "\nMOVE Range:" + pinkmagician.moverange.ToString();
                    break;
                case 6:
                    label6.Text = pinkranger.character + "\nHP:" + pinkranger.hp.ToString() + "\nMP:" + pinkranger.mp.ToString() + "\nATK:" + pinkranger.atk.ToString() + "\nATK Range:" + pinkranger.atkrange.ToString() + "\nMOVE Range:" + pinkranger.moverange.ToString();
                    break;
            }
            for (int i = 0; i < 42; i++)
            {
                if (putchess[i] == whatchess)
                {
                    location = i;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            whatchess += 1;
            while (die[whatchess] == 1)
            {
                whatchess++;
                if (whatchess > 6)
                {
                    whatchess = 1;
                }
            }
            if (whatchess <= 3)
            {
                label1.Text = "P1 Turn";
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = false;
                button15.Enabled = false;
                button14.Enabled = false;
                button13.Enabled = false;
            }
            else
            {
                label1.Text = "P2 Turn";
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = true;
                button15.Enabled = true;
                button14.Enabled = true;
                button13.Enabled = true;
            }
            switch (whatchess)
            {
                case 1:
                    label5.Text = bluewarrior.character + "\nHP:" + bluewarrior.hp.ToString() + "\nMP:" + bluewarrior.mp.ToString() + "\nATK:" + bluewarrior.atk.ToString() + "\nATK Range:" + bluewarrior.atkrange.ToString() + "\nMOVE Range:" + bluewarrior.moverange.ToString();
                    break;
                case 2:
                    label5.Text = bluemagician.character + "\nHP:" + bluemagician.hp.ToString() + "\nMP:" + bluemagician.mp.ToString() + "\nATK:" + bluemagician.atk.ToString() + "\nATK Range:" + bluemagician.atkrange.ToString() + "\nMOVE Range:" + bluemagician.moverange.ToString();
                    break;
                case 3:
                    label5.Text = blueranger.character + "\nHP:" + blueranger.hp.ToString() + "\nMP:" + blueranger.mp.ToString() + "\nATK:" + blueranger.atk.ToString() + "\nATK Range:" + blueranger.atkrange.ToString() + "\nMOVE Range:" + blueranger.moverange.ToString();
                    break;
                case 4:
                    label6.Text = pinkwarrior.character + "\nHP:" + pinkwarrior.hp.ToString() + "\nMP:" + pinkwarrior.mp.ToString() + "\nATK:" + pinkwarrior.atk.ToString() + "\nATK Range:" + pinkwarrior.atkrange.ToString() + "\nMOVE Range:" + pinkwarrior.moverange.ToString();
                    break;
                case 5:
                    label6.Text = pinkmagician.character + "\nHP:" + pinkmagician.hp.ToString() + "\nMP:" + pinkmagician.mp.ToString() + "\nATK:" + pinkmagician.atk.ToString() + "\nATK Range:" + pinkmagician.atkrange.ToString() + "\nMOVE Range:" + pinkmagician.moverange.ToString();
                    break;
                case 6:
                    label6.Text = pinkranger.character + "\nHP:" + pinkranger.hp.ToString() + "\nMP:" + pinkranger.mp.ToString() + "\nATK:" + pinkranger.atk.ToString() + "\nATK Range:" + pinkranger.atkrange.ToString() + "\nMOVE Range:" + pinkranger.moverange.ToString();
                    break;
            }
            for (int i = 0; i < 42; i++)
            {
                if (putchess[i] == whatchess)
                {
                    location = i;
                }
            }
            for (int i = 0; i < 42; i++)
            {
                btn[i].Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            whatchess = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            whatchess = 6;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (num == 10 && times == 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                for (int i = 0; i < 42; i++)
                {
                    if (i % 6 <= 2 && putchess[i] == 0)
                    {
                        btn[i].Enabled = true;
                    }
                    else
                    {
                        btn[i].Enabled = false;
                    }
                }
            }
            else if (num == 10 && times == 1)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                for (int i = 0; i < 42; i++)
                {
                    if (i % 6 <= 2)
                    {
                        btn[i].Enabled = false;
                    }
                    else
                    {
                        btn[i].Enabled = true;
                    }
                }
            }
            if (num > 0)
            {
                num--;
            }
            label2.Text = num.ToString();
            if (num == 0)
            {
                if (button2.Enabled == true)
                {
                    for (int i = 0; i < 42; i += 6)
                    {
                        if (putchess[i] == 0)
                        {
                            btn[i].BackColor = Color.LightBlue;
                            btn[i].Text = "戰士";
                            btn[i].Enabled = false;
                            button2.Text = "戰士:0顆";
                            putchess[i] = 1;
                            button2.Enabled = false;
                            blue++;
                            whatchess = 0;
                            break;
                        }
                    }
                }
                if (button3.Enabled == true)
                {
                    for (int i = 0; i < 42; i += 6)
                    {
                        if (putchess[i] == 0)
                        {
                            btn[i].BackColor = Color.LightBlue;
                            btn[i].Text = "法師";
                            button3.Text = "法師:0顆";
                            putchess[i] = 2;
                            button3.Enabled = false;
                            whatchess = 0;
                            break;
                        }
                    }
                }
                if (button4.Enabled == true)
                {
                    for (int i = 0; i < 42; i += 6)
                    {
                        if (putchess[i] == 0)
                        {
                            btn[i].BackColor = Color.LightBlue;
                            btn[i].Text = "遊俠";
                            button4.Text = "遊俠:0顆";
                            putchess[i] = 3;
                            button4.Enabled = false;
                            whatchess = 0;
                            break;
                        }
                    }
                }
                if (button5.Enabled == true)
                {
                    for (int i = 5; i < 42; i += 6)
                    {
                        if (putchess[i] == 0)
                        {
                            btn[i].BackColor = Color.LightPink;
                            btn[i].Text = "戰士";
                            button5.Text = "戰士:0顆";
                            putchess[i] = 4;
                            button5.Enabled = false;
                            pink++;
                            whatchess = 0;
                            break;
                        }
                    }
                }
                if (button6.Enabled == true)
                {
                    for (int i = 5; i < 42; i += 6)
                    {
                        if (putchess[i] == 0)
                        {
                            btn[i].BackColor = Color.LightPink;
                            btn[i].Text = "法師";
                            button6.Text = "法師:0顆";
                            putchess[i] = 5;
                            button6.Enabled = false;
                            whatchess = 0;
                            break;
                        }
                    }
                }
                if (button7.Enabled == true)
                {
                    for (int i = 5; i < 42; i += 6)
                    {
                        if (putchess[i] == 0)
                        {
                            btn[i].BackColor = Color.LightPink;
                            btn[i].Text = "遊俠";
                            button5.Text = "遊俠:0顆";
                            putchess[i] = 6;
                            button7.Enabled = false;
                            whatchess = 0;
                            break;
                        }
                    }
                }
                if (times == 0)
                {
                    num = 10;
                    times++;
                }
                else if (times == 1)
                {
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = true;
                    panel5.Visible = true;
                    label2.Visible = false;
                    for (int i = 0; i < 42; i++)
                    {
                        btn[i].Enabled = true;
                    }
                    whatchess = 1;
                    label1.Text = "P1 Turn";
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = false;
                    button17.Enabled = false;
                    button16.Enabled = false;
                    button15.Enabled = false;
                    button14.Enabled = false;
                    button13.Enabled = false;
                    label5.Text = bluewarrior.character + "\nHP:" + bluewarrior.hp.ToString() + "\nMP:" + bluewarrior.mp.ToString() + "\nATK:" + bluewarrior.atk.ToString() + "\nATK Range:" + bluewarrior.atkrange.ToString() + "\nMOVE Range:" + bluewarrior.moverange.ToString();
                    label6.Text = pinkwarrior.character + "\nHP:" + pinkwarrior.hp.ToString() + "\nMP:" + pinkwarrior.mp.ToString() + "\nATK:" + pinkwarrior.atk.ToString() + "\nATK Range:" + pinkwarrior.atkrange.ToString() + "\nMOVE Range:" + pinkwarrior.moverange.ToString();
                    for (int i = 0; i < 42; i++)
                    {
                        if (putchess[i] == whatchess)
                        {
                            location = i;
                        }
                    }
                    blue = 3;
                    pink = 3;
                    times++;
                }
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            bt = (Button)sender;
            x = Convert.ToInt16(bt.Name);
            if (label2.Visible == true)
            {
                switch (whatchess)
                {
                    case 1:
                        btn[x].BackColor = Color.LightBlue;
                        btn[x].Text = "戰士";
                        btn[x].Enabled = false;
                        button2.Text = "戰士:0顆";
                        button2.Enabled = false;
                        putchess[x] = 1;
                        whatchess = 0;
                        blue++;
                        break;
                    case 2:
                        btn[x].BackColor = Color.LightBlue;
                        btn[x].Text = "法師";
                        btn[x].Enabled = false;
                        button3.Text = "法師:0顆";
                        button3.Enabled = false;
                        putchess[x] = 2;
                        whatchess = 0;
                        break;
                    case 3:
                        btn[x].BackColor = Color.LightBlue;
                        btn[x].Text = "遊俠";
                        btn[x].Enabled = false;
                        button4.Text = "遊俠:0顆";
                        button4.Enabled = false;
                        putchess[x] = 3;
                        whatchess = 0;
                        break;
                    case 4:
                        btn[x].BackColor = Color.LightPink;
                        btn[x].Text = "戰士";
                        btn[x].Enabled = false;
                        button5.Text = "戰士:0顆";
                        button5.Enabled = false;
                        putchess[x] = 4;
                        whatchess = 0;
                        pink++;
                        break;
                    case 5:
                        btn[x].BackColor = Color.LightPink;
                        btn[x].Text = "法師";
                        btn[x].Enabled = false;
                        button6.Text = "法師:0顆";
                        button6.Enabled = false;
                        putchess[x] = 5;
                        whatchess = 0;
                        break;
                    case 6:
                        btn[x].BackColor = Color.LightPink;
                        btn[x].Text = "遊俠";
                        btn[x].Enabled = false;
                        button7.Text = "遊俠:0顆";
                        button7.Enabled = false;
                        putchess[x] = 6;
                        whatchess = 0;
                        break;
                    default:
                        if (times == 0 && blue == 0)
                        {
                            btn[x].BackColor = Color.LightBlue;
                            btn[x].Text = "戰士";
                            btn[x].Enabled = false;
                            button2.Text = "戰士:0顆";
                            button2.Enabled = false;
                            putchess[x] = 1;
                            blue++;
                        }
                        else if (times == 1 && pink == 0)
                        {
                            btn[x].BackColor = Color.LightPink;
                            btn[x].Text = "戰士";
                            btn[x].Enabled = false;
                            button5.Text = "戰士:0顆";
                            button5.Enabled = false;
                            putchess[x] = 4;
                            pink++;
                        }
                        break;
                }
            }
            else
            {
                if (whatchess == 1 || whatchess == 2 || whatchess == 3)
                {
                    switch (putchess[x])
                    {
                        case 4:
                            label6.Text = pinkwarrior.character + "\nHP:" + pinkwarrior.hp.ToString() + "\nMP:" + pinkwarrior.mp.ToString() + "\nATK:" + pinkwarrior.atk.ToString() + "\nATK Range:" + pinkwarrior.atkrange.ToString() + "\nMOVE Range:" + pinkwarrior.moverange.ToString();
                            break;
                        case 5:
                            label6.Text = pinkmagician.character + "\nHP:" + pinkmagician.hp.ToString() + "\nMP:" + pinkmagician.mp.ToString() + "\nATK:" + pinkmagician.atk.ToString() + "\nATK Range:" + pinkmagician.atkrange.ToString() + "\nMOVE Range:" + pinkmagician.moverange.ToString();
                            break;
                        case 6:
                            label6.Text = pinkranger.character + "\nHP:" + pinkranger.hp.ToString() + "\nMP:" + pinkranger.mp.ToString() + "\nATK:" + pinkranger.atk.ToString() + "\nATK Range:" + pinkranger.atkrange.ToString() + "\nMOVE Range:" + pinkranger.moverange.ToString();
                            break;
                    }
                }
                else if (whatchess == 4 || whatchess == 5 || whatchess == 6)
                {
                    switch (putchess[x])
                    {
                        case 1:
                            label5.Text = bluewarrior.character + "\nHP:" + bluewarrior.hp.ToString() + "\nMP:" + bluewarrior.mp.ToString() + "\nATK:" + bluewarrior.atk.ToString() + "\nATK Range:" + bluewarrior.atkrange.ToString() + "\nMOVE Range:" + bluewarrior.moverange.ToString();
                            break;
                        case 2:
                            label5.Text = bluemagician.character + "\nHP:" + bluemagician.hp.ToString() + "\nMP:" + bluemagician.mp.ToString() + "\nATK:" + bluemagician.atk.ToString() + "\nATK Range:" + bluemagician.atkrange.ToString() + "\nMOVE Range:" + bluemagician.moverange.ToString();
                            break;
                        case 3:
                            label5.Text = blueranger.character + "\nHP:" + blueranger.hp.ToString() + "\nMP:" + blueranger.mp.ToString() + "\nATK:" + blueranger.atk.ToString() + "\nATK Range:" + blueranger.atkrange.ToString() + "\nMOVE Range:" + blueranger.moverange.ToString();
                            break;
                    }
                }

            }
            if (type == 1)
            {
                btn[x].Text = btn[location].Text;
                btn[x].BackColor = btn[location].BackColor;
                putchess[x] = putchess[location];
                btn[location].Text = "";
                btn[location].BackColor = Color.White;
                putchess[location] = 0;
                if (whatchess == 1 || whatchess == 2 || whatchess == 3)
                {
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = true;
                }
                else if (whatchess == 4 || whatchess == 5 || whatchess == 6)
                {
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = true;
                }
            }
            else if (type == 2)
            {
                if (canattack[x] == 0)
                {
                    MessageBox.Show("超出攻擊範圍");
                }
                else
                {
                    switch (whatchess)
                    {
                        case 1:
                        case 2:
                        case 3:
                            if (putchess[x] == 4)
                            {
                                isattack = true;
                                if (whatchess == 1)
                                {
                                    pinkwarrior.hp -= bluewarrior.atk;
                                }
                                else if (whatchess == 2)
                                {
                                    pinkwarrior.hp -= bluemagician.atk;
                                }
                                else if (whatchess == 3)
                                {
                                    pinkwarrior.hp -= blueranger.atk;
                                }
                                if (pinkwarrior.hp <= 0)
                                {
                                    btn[x].Text = "";
                                    btn[x].BackColor = Color.White;
                                    putchess[x] = 0;
                                    die[4] = 1;
                                    pink--;
                                }
                                label6.Text = pinkwarrior.character + "\nHP:" + pinkwarrior.hp.ToString() + "\nMP:" + pinkwarrior.mp.ToString() + "\nATK:" + pinkwarrior.atk.ToString() + "\nATK Range:" + pinkwarrior.atkrange.ToString() + "\nMOVE Range:" + pinkwarrior.moverange.ToString();
                            }
                            else if (putchess[x] == 5)
                            {
                                isattack = true;
                                if (whatchess == 1)
                                {
                                    pinkmagician.hp -= bluewarrior.atk;
                                }
                                else if (whatchess == 2)
                                {
                                    pinkmagician.hp -= bluemagician.atk;
                                }
                                else if (whatchess == 3)
                                {
                                    pinkmagician.hp -= blueranger.atk;
                                }
                                if (pinkmagician.hp <= 0)
                                {
                                    btn[x].Text = "";
                                    btn[x].BackColor = Color.White;
                                    putchess[x] = 0;
                                    die[5] = 1;
                                    pink--;
                                }
                                label6.Text = pinkmagician.character + "\nHP:" + pinkmagician.hp.ToString() + "\nMP:" + pinkmagician.mp.ToString() + "\nATK:" + pinkmagician.atk.ToString() + "\nATK Range:" + pinkmagician.atkrange.ToString() + "\nMOVE Range:" + pinkmagician.moverange.ToString();
                            }
                            else if (putchess[x] == 6)
                            {
                                isattack = true;
                                if (whatchess == 1)
                                {
                                    pinkranger.hp -= bluewarrior.atk;
                                }
                                else if (whatchess == 2)
                                {
                                    pinkranger.hp -= bluemagician.atk;
                                }
                                else if (whatchess == 3)
                                {
                                    pinkranger.hp -= blueranger.atk;
                                }
                                if (pinkranger.hp <= 0)
                                {
                                    btn[x].Text = "";
                                    btn[x].BackColor = Color.White;
                                    putchess[x] = 0;
                                    die[6] = 1;
                                    pink--;
                                }
                                label6.Text = pinkranger.character + "\nHP:" + pinkranger.hp.ToString() + "\nMP:" + pinkranger.mp.ToString() + "\nATK:" + pinkranger.atk.ToString() + "\nATK Range:" + pinkranger.atkrange.ToString() + "\nMOVE Range:" + pinkranger.moverange.ToString();
                            }
                            if (isattack == true)
                            {
                                button8.Enabled = false;
                                button9.Enabled = false;
                                button10.Enabled = false;
                                button11.Enabled = false;
                                button12.Enabled = true;
                                isattack = false;
                            }
                            break;
                        case 4:
                        case 5:
                        case 6:
                            if (putchess[x] == 1)
                            {
                                isattack = true;
                                if (whatchess == 4)
                                {
                                    bluewarrior.hp -= pinkwarrior.atk;
                                }
                                else if (whatchess == 5)
                                {
                                    bluewarrior.hp -= pinkmagician.atk;
                                }
                                else if (whatchess == 6)
                                {
                                    bluewarrior.hp -= pinkranger.atk;
                                }
                                if (bluewarrior.hp <= 0)
                                {
                                    btn[x].Text = "";
                                    btn[x].BackColor = Color.White;
                                    putchess[x] = 0;
                                    blue--;
                                    die[1] = 1;
                                }
                                label5.Text = bluewarrior.character + "\nHP:" + bluewarrior.hp.ToString() + "\nMP:" + bluewarrior.mp.ToString() + "\nATK:" + bluewarrior.atk.ToString() + "\nATK Range:" + bluewarrior.atkrange.ToString() + "\nMOVE Range:" + bluewarrior.moverange.ToString();
                            }
                            else if (putchess[x] == 2)
                            {
                                isattack = true;
                                if (whatchess == 4)
                                {
                                    bluemagician.hp -= pinkwarrior.atk;
                                }
                                else if (whatchess == 5)
                                {
                                    bluemagician.hp -= pinkmagician.atk;
                                }
                                else if (whatchess == 6)
                                {
                                    bluemagician.hp -= pinkranger.atk;
                                }
                                if (bluemagician.hp <= 0)
                                {
                                    btn[x].Text = "";
                                    btn[x].BackColor = Color.White;
                                    putchess[x] = 0;
                                    blue--;
                                    die[2] = 1;
                                }
                                label5.Text = bluemagician.character + "\nHP:" + bluemagician.hp.ToString() + "\nMP:" + bluemagician.mp.ToString() + "\nATK:" + bluemagician.atk.ToString() + "\nATK Range:" + bluemagician.atkrange.ToString() + "\nMOVE Range:" + bluemagician.moverange.ToString();
                            }
                            else if (putchess[x] == 3)
                            {
                                isattack = true;
                                if (whatchess == 4)
                                {
                                    blueranger.hp -= pinkwarrior.atk;
                                }
                                else if (whatchess == 5)
                                {
                                    blueranger.hp -= pinkmagician.atk;
                                }
                                else if (whatchess == 6)
                                {
                                    blueranger.hp -= pinkranger.atk;
                                }
                                if (blueranger.hp <= 0)
                                {
                                    btn[x].Text = "";
                                    btn[x].BackColor = Color.White;
                                    putchess[x] = 0;
                                    blue--;
                                    die[3] = 1;
                                }
                                label6.Text = blueranger.character + "\nHP:" + blueranger.hp.ToString() + "\nMP:" + blueranger.mp.ToString() + "\nATK:" + blueranger.atk.ToString() + "\nATK Range:" + blueranger.atkrange.ToString() + "\nMOVE Range:" + blueranger.moverange.ToString();
                            }
                            if (isattack == true)
                            {
                                button13.Enabled = false;
                                button14.Enabled = false;
                                button15.Enabled = false;
                                button16.Enabled = false;
                                button17.Enabled = true;
                                isattack = false;
                            }
                            break;
                    }


                }
            }
            if (times == 2)
            {
                for (int i = 0; i < 42; i++)
                {
                    canattack[i] = 0;
                    btn[i].Enabled = true;
                }
                type = 0;
                DialogResult result;
                if (pink == 0)
                {
                    result = MessageBox.Show("P1贏了");
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else if (blue == 0)
                {
                    result = MessageBox.Show("P2贏了");
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }

        }
    }
}
