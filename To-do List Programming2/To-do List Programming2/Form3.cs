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

namespace To_do_List_Programming2
{
    public partial class Form3 : Form
    {
        public Form1 homepage;
        public Form3()
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
                homepage.textBox2.Text = homepage.textBox1.Text;
                homepage.textBox1.Text = "";
                StringReader sr = new StringReader(homepage.textBox2.Text);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (textBox1.Text == line.Remove(0, 5))
                    {
                        line = " [√] " + line.Remove(0, 5) + "\r\n";
                        homepage.textBox1.Text += line;
                    }
                    else
                        homepage.textBox1.Text += line + "\r\n";
                }
                homepage.Enabled = true;
                this.Close();
            }
        }
    }
}
