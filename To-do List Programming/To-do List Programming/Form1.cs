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

namespace To_do_List_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todo Files|*.todo|Text Files|*.txt|All files|*.*";
            saveFileDialog1.Filter = "Todo Files|*.todo|Text Files|*.txt|All files|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 additem = new Form2();
            additem.homepage = this;
            additem.Owner = this;
            additem.Location = new Point(150, 2000);
            additem.Show();
            this.Enabled = false;
        }

        private void newform_Click(object sender, EventArgs e)
        {
            this.Text = "未命名*-待辦清單";
            textBox1.Text = "";
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                this.Text = openFileDialog1.FileName;
            }
        }

        private void fontsize_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = this.ActiveControl.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savefile_Click(object sender, EventArgs e)
        {
            if (this.Text != "未命名*-待辦清單")
            {
                StreamWriter sw = new StreamWriter(openFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(textBox1.Text);
                    sw.Close();
                    this.Text = saveFileDialog1.FileName;
                }
            }
        }

        private void save_as_new_file_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
                this.Text = saveFileDialog1.FileName;
            }
        }
    }
}
