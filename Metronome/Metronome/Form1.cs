using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Metronome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer ding = new SoundPlayer();
        SoundPlayer dong = new SoundPlayer();
        SoundPlayer doo = new SoundPlayer();
        Button[] btn = new Button[12];

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            trackBar1.Maximum = 180;
            trackBar1.Minimum = 60;
            trackBar1.Value = 120;
            panel2.Visible = false;
            panel1.Visible = true;
            for (int i = 0; i < 4; i++)
            {
                btn[i] = new Button();
                btn[i].Width = 40;
                btn[i].Height = 40;
                btn[i].Left = 10 + 120 * i;
                panel1.Controls.Add(btn[i]);
                btn[i].Name = i.ToString();
            }
            for (int i = 4; i < 12; i++)
            {
                btn[i] = new Button();
                btn[i].Width = 40;
                btn[i].Height = 40;
                btn[i].Left = 10 + 50 * (i - 4);
                panel2.Controls.Add(btn[i]);
                btn[i].Name = i.ToString();
            }
            radioButton1.Checked = true;
            comboBox1.Text = "4";
            ding.SoundLocation = Application.StartupPath + "\\ding.wav";
            ding.Load();
            dong.SoundLocation = Application.StartupPath + "\\dong.wav";
            dong.Load();
            doo.SoundLocation = Application.StartupPath + "\\doo.wav";
            doo.Load();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString() + "BPM";
            if (radioButton1.Checked == true)
                timer1.Interval = 60000 / trackBar1.Value;
            else if (radioButton2.Checked == true)
                timer1.Interval = 30000 / trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Start";
                timer1.Enabled = false; ;
                x = 0;
                for (int i = 0; i < 12; i++) btn[i].BackColor = Color.White;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 60000 / trackBar1.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 30000 / trackBar1.Value;
        }

        int x = 0, y = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "4")
            {
                if (radioButton2.Checked)
                {
                    if (y % 2 == 0)
                    {
                        if (x != 0)
                            btn[x - 1].BackColor = Color.White;
                        else
                            btn[3].BackColor = Color.White;
                        btn[x].BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    if (x != 0)
                        btn[x - 1].BackColor = Color.White;
                    else
                        btn[3].BackColor = Color.White;
                    btn[x].BackColor = Color.LightGreen;
                }
            }
            else if (comboBox1.Text == "8")
            {
                if (radioButton2.Checked)
                {
                    if (y % 2 == 0)
                    {
                        if (x != 0)
                            btn[x + 3].BackColor = Color.White;
                        else
                            btn[11].BackColor = Color.White;
                        btn[x + 4].BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    if (x != 0)
                        btn[x + 3].BackColor = Color.White;
                    else
                        btn[11].BackColor = Color.White;
                    btn[x + 4].BackColor = Color.LightGreen;
                }
            }
            if (x == 0)
            {
                if (radioButton2.Checked)
                {
                    if (y % 2 == 0)
                    {
                        ding.Load();
                        ding.Play();
                    }
                    else
                    {
                        doo.Load();
                        doo.Play();
                    }
                }
                else
                {
                    ding.Load();
                    ding.Play();
                }
            }
            else if (x != 0)
            {
                if (radioButton2.Checked)
                {
                    if (y % 2 == 0)
                    {
                        dong.Load();
                        dong.Play();
                    }
                    else
                    {
                        doo.Load();
                        doo.Play();
                    }
                }
                else
                {
                    dong.Load();
                    dong.Play();
                }
            }
            y++;
            if (radioButton2.Checked)
            {
                if (y % 2 == 0)
                {
                    x++;
                }
            }
            else x++;
            if (x == Convert.ToInt16(comboBox1.Text)) x = 0;
            if (y == Convert.ToInt16(comboBox1.Text)) y = 0;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "4")
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else if (comboBox1.Text == "8")
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }
    }
}
