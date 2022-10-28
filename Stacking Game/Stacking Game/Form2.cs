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
    public partial class Form2 : Form
    {
        Game game;
        String[] input;
        public Form2(String[] _input)
        {
            InitializeComponent();
            input = _input;
            game = new Game(input);
            take_idiot();
            if (game.stacks[0].Count() == 1)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[0].Count() == 2)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[0].Count() == 3)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[0].Count() == 4)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            if (game.stacks[1].Count() == 1)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[1].Count() == 2)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[1].Count() == 3)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[1].Count() == 4)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            if (game.stacks[2].Count() == 1)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[2].Count() == 2)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[2].Count() == 3)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[2].Count() == 4)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            if (game.stacks[3].Count() == 1)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[3].Count() == 2)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[3].Count() == 3)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[3].Count() == 4)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            for (int i = game.stacks[0].Count() - 1; i >= 0; i--)
            {
                stack1.Text += "\r\n";
                stack1.Text += game.stacks[0][i];
            }
            for (int i = game.stacks[1].Count() - 1; i >= 0; i--)
            {
                stack2.Text += "\r\n";
                stack2.Text += game.stacks[1][i];
            }
            for (int i = game.stacks[2].Count() - 1; i >= 0; i--)
            {
                stack3.Text += "\r\n";
                stack3.Text += game.stacks[2][i];
            }
            for (int i = game.stacks[3].Count() - 1; i >= 0; i--)
            {
                stack4.Text += "\r\n";
                stack4.Text += game.stacks[3][i];
            }
        }

        private void main_Click(object sender, EventArgs e)
        {
            Owner.Visible = true;
            this.Close();
        }
        int choose = -1;

        private void choose1_Click(object sender, EventArgs e)
        {
            if (choose1.Text.Equals("選取"))
            {
                choose = 0;
                choose1.Text = "放置";
                choose2.Text = "放置";
                choose3.Text = "放置";
                choose4.Text = "放置";
                place_idiot();
            }
            else
            {
                game.move(choose, 0);
                new_textpane();
                take_idiot();
                choose1.Text = "選取";
                choose2.Text = "選取";
                choose3.Text = "選取";
                choose4.Text = "選取";
                win_examination();

            }
        }

        private void choose2_Click(object sender, EventArgs e)
        {
            if (choose1.Text.Equals("選取"))
            {
                choose = 1;
                choose1.Text = "放置";
                choose2.Text = "放置";
                choose3.Text = "放置";
                choose4.Text = "放置";
                place_idiot();
            }
            else
            {
                game.move(choose, 1);
                new_textpane();
                take_idiot();
                choose1.Text = "選取";
                choose2.Text = "選取";
                choose3.Text = "選取";
                choose4.Text = "選取";
                win_examination();
            }
        }

        private void choose3_Click(object sender, EventArgs e)
        {
            if (choose1.Text.Equals("選取"))
            {
                choose = 2;
                choose1.Text = "放置";
                choose2.Text = "放置";
                choose3.Text = "放置";
                choose4.Text = "放置";
                place_idiot();
            }
            else
            {
                game.move(choose, 2);
                new_textpane();
                take_idiot();
                choose1.Text = "選取";
                choose2.Text = "選取";
                choose3.Text = "選取";
                choose4.Text = "選取";
                win_examination();
            }
        }

        private void choose4_Click(object sender, EventArgs e)
        {
            if (choose1.Text.Equals("選取"))
            {
                choose = 3;
                choose1.Text = "放置";
                choose2.Text = "放置";
                choose3.Text = "放置";
                choose4.Text = "放置";
                place_idiot();
            }
            else
            {
                game.move(choose, 3);
                new_textpane();
                take_idiot();
                choose1.Text = "選取";
                choose2.Text = "選取";
                choose3.Text = "選取";
                choose4.Text = "選取";
                win_examination();
            }
        }

        private void new_textpane()
        {
            stack1.Text = "";
            stack2.Text = "";
            stack3.Text = "";
            stack4.Text = "";
            if (game.stacks[0].Count() == 1)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[0].Count() == 2)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[0].Count() == 3)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[0].Count() == 4)
            {
                stack1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            if (game.stacks[1].Count() == 1)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[1].Count() == 2)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[1].Count() == 3)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[1].Count() == 4)
            {
                stack2.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            if (game.stacks[2].Count() == 1)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[2].Count() == 2)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[2].Count() == 3)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[2].Count() == 4)
            {
                stack3.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            if (game.stacks[3].Count() == 1)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[3].Count() == 2)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[3].Count() == 3)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }
            else if (game.stacks[3].Count() == 4)
            {
                stack4.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            }

            for (int i = game.stacks[0].Count() - 1; i >= 0; i--)
            {
                stack1.Text += "\r\n";
                stack1.Text += game.stacks[0][i];
            }
            for (int i = game.stacks[1].Count() - 1; i >= 0; i--)
            {
                stack2.Text += "\r\n";
                stack2.Text += game.stacks[1][i];
            }
            for (int i = game.stacks[2].Count() - 1; i >= 0; i--)
            {
                stack3.Text += "\r\n";
                stack3.Text += game.stacks[2][i];
            }
            for (int i = game.stacks[3].Count() - 1; i >= 0; i--)
            {
                stack4.Text += "\r\n";
                stack4.Text += game.stacks[3][i];
            }
        }

        public void place_idiot()
        {
            if (game.canplace(0) == false)
            {
                choose1.Enabled = false;
            }
            else
            {
                choose1.Enabled = true;
            }

            if (game.canplace(1) == false)
            {
                choose2.Enabled = false;
            }
            else
            {
                choose2.Enabled = true;
            }
            if (game.canplace(2) == false)
            {
                choose3.Enabled = false;
            }
            else
            {
                choose3.Enabled = true;
            }
            if (game.canplace(3) == false)
            {
                choose4.Enabled = false;
            }
            else
            {
                choose4.Enabled = true;
            }
        }

        public void take_idiot()
        {
            if (game.cantake(0) == false)
            {
                choose1.Enabled = false;
            }
            else
            {
                choose1.Enabled = true;
            }

            if (game.cantake(1) == false)
            {
                choose2.Enabled = false;
            }
            else
            {
                choose2.Enabled = true;
            }
            if (game.cantake(2) == false)
            {
                choose3.Enabled = false;
            }
            else
            {
                choose3.Enabled = true;
            }
            if (game.cantake(3) == false)
            {
                choose4.Enabled = false;
            }
            else
            {
                choose4.Enabled = true;
            }
        }

        public void win_examination()
        {
            if (game.win())
            {
                choose1.Text = "贏";
                choose2.Text = "贏";
                choose3.Text = "贏";
                choose4.Text = "贏";
                choose1.Enabled = false;
                choose2.Enabled = false;
                choose3.Enabled = false;
                choose4.Enabled = false;
                win_label.Text = "你贏了";
            }
        }
    }
}
