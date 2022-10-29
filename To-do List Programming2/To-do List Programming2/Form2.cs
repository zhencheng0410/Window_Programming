using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_List_Programming2
{
    public partial class Form2 : Form
    {
        public Form1 homepage;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage.Enabled = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("請輸入事項");
            else
            {
                if (textBox1.Text[0] == '+')
                {
                    homepage.textBox1.Text += " [√] " + textBox1.Text.Remove(0, 1) + "\r\n";
                }
                else if (textBox1.Text[0] == '-')
                {
                    homepage.textBox1.Text += " [ ] " + textBox1.Text.Remove(0, 1) + "\r\n";
                }
                homepage.Enabled = true;
                this.Close();
            }
        }
    }
}
