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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            type1();
            this.Text = "未命名*-待辦清單";
            openFileDialog1.Filter = "Todo Files|*.todo|Text Files|*.txt|All files|*.*";
            saveFileDialog1.Filter = "Todo Files|*.todo|Text Files|*.txt|All files|*.*";
            button3.Visible = false;
        }

        private void fontsize_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = this.ActiveControl.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void newform_Click(object sender, EventArgs e)
        {
            type1();
            this.Text = "未命名*-待辦清單";
            textBox1.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            type1();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog1.FileName;
                string line;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while ((line = sr.ReadLine()) != null)
                {
                    if (line[0] == '+')
                    {
                        textBox1.Text += " [√] " + line.Remove(0, 1) + "\r\n";
                    }
                    else if (line[0] == '-')
                    {
                        textBox1.Text += " [ ] " + line.Remove(0, 1) + "\r\n";
                    }
                }
            }
        }

        private void savefile_Click(object sender, EventArgs e)
        {
            type1();
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
            type1();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type1();
            Form2 additem = new Form2();
            additem.homepage = this;
            additem.Owner = this;
            additem.Show();
            this.Enabled = false;
        }

        private void addtodo_Click(object sender, EventArgs e)
        {
            type1();
            Form2 additem = new Form2();
            additem.homepage = this;
            additem.Show();
            this.Enabled = false;
        }

        private void showfinish_Click(object sender, EventArgs e)
        {
            type2();
            StringReader sr = new StringReader(textBox1.Text);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line[1] == '[' && line[2] == '√' && line[3] == ']')
                {
                    textBox2.Text += line + "\r\n";
                }
            }
        }

        public void type1()
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
        }
        public void type2()
        {
            textBox2.Visible = true;
            textBox1.Visible = false;
            textBox2.Text = "";
        }

        private void hidefinish_Click(object sender, EventArgs e)
        {
            type2();
            StringReader sr = new StringReader(textBox1.Text);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line[1] == '[' && line[2] == ' ' && line[3] == ']')
                {
                    textBox2.Text += line + "\r\n";
                }
            }
        }

        private void tocomplete_Click(object sender, EventArgs e)
        {
            Form3 complete = new Form3();
            complete.homepage = this;
            complete.Show();
            this.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 complete = new Form3();
            complete.homepage = this;
            complete.Show();
            this.Enabled = false;
        }

        private void todelete_Click(object sender, EventArgs e)
        {
            Form4 delete = new Form4();
            delete.homepage = this;
            delete.Show();
            this.Enabled = false;
        }

        private void find_Click(object sender, EventArgs e)
        {
            type2();
            menuStrip1.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            Form5 search = new Form5();
            search.homepage = this;
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type1();
            menuStrip1.Enabled = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
        }
    }
}
