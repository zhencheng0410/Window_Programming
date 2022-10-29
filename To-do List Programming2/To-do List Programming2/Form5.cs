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
    public partial class Form5 : Form
    {
        public Form1 homepage;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage.textBox1.Visible = true;
            homepage.textBox2.Visible = false;
            homepage.menuStrip1.Enabled = true;
            homepage.button1.Visible = true;
            homepage.button2.Visible = true;
            homepage.button3.Visible = false;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("請輸入事項");
            else
            {
                StringReader sr = new StringReader(homepage.textBox1.Text);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(textBox1.Text))
                    {
                        homepage.textBox2.Text += line + "\r\n";
                    }
                }
                this.Close();
            }
        }
    }
}
