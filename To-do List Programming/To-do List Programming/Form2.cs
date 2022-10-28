using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_List_Programming
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
                homepage.textBox1.Text += this.textBox1.Text + "\r\n";
                homepage.Enabled = true;
                this.Close();
            }
        }
    }
}
