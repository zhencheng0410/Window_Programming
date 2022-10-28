using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacking_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void start_Click(object sender, EventArgs e)
        {
            int one = 0, two = 0, three = 0;
            Boolean status = true;
            String[] input = new String[4];
            input[0] = stack1.Text;
            input[1] = stack2.Text;
            input[2] = stack3.Text;
            input[3] = stack4.Text;

            for (int i = 0; i < 4; i++)
            {
                if (input[i].Length >= 8)
                {
                    status = false;
                }
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][input[i].Length - 1] == 32)
                    {
                        status = false;
                    }
                    if (j % 2 == 0)
                    {
                        if (input[i][j] < '1' || input[i][j] > '3')
                        {
                            status = false;
                        }
                        else if (input[i][j] == '1')
                        {
                            one++;
                        }
                        else if (input[i][j] == '2')
                        {
                            two++;
                        }
                        else if (input[i][j] == '3')
                        {
                            three++;
                        }

                        if (one > 3 || two > 3 || three > 3)
                        {
                            status = false;
                        }
                    }
                    else if (j % 2 == 1)
                    {
                        if (input[i][j] != ' ')
                        {
                            status = false;
                        }
                    }
                }
            }

            if (one != 3 || two != 3 || three != 3)
            {
                status = false;
            }

            if (status == true)
            {
                Form2 form2 = new Form2(input);
                this.Visible = false;
                form2.Visible = true;
                form2.Owner = this;
                stack1.Text = "";
                stack2.Text = "";
                stack3.Text = "";
                stack4.Text = "";
                title.Text = "請輸入測資";
            }
            else
            {
                title.Text = "測資錯誤";
            }
        }
    }
}
