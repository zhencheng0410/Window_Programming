using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Easy_Version_of_2_Players_Wargame
{
    class Chess
    {
        public string character;
        public int hp;
        public int mp;
        public int atk;
        public int atkrange;
        public int moverange;
        public virtual void Skill() { }
    }
    class warrior : Chess
    {
        public string character = "戰士";
        public int hp = 100;
        public int mp = 15;
        public int atk = 30;
        public int atkrange = 1;
        public int moverange = 2;
        public void Skill()
        {
            mp -= 10;
            hp += Convert.ToInt16(0.5 * atk);
        }
    }
    class magician : Chess
    {
        public string character = "法師";
        public int hp = 70;
        public int mp = 25;
        public int atk = 20;
        public int atkrange = 2;
        public int moverange = 2;
        public void Skill()
        {
            mp -= 10;
            atk *= 2;
        }
    }
    class ranger : Chess
    {
        public string character = "遊俠";
        public int hp = 90;
        public int mp = 10;
        public int atk = 30;
        public int atkrange = 3;
        public int moverange = 1;
        public void Skill()
        {
            mp -= 10;
            atkrange += 1;
        }
    }
}