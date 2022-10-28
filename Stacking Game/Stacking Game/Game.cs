using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacking_Game
{
    class Game
    {
        public List<int>[] stacks = new List<int>[4];
        public Boolean canplace(int i)
        {
            Boolean status = true;
            if (stacks[i].Count() == 4)
            {
                status = false;
            }
            return status;
        }

        public Boolean cantake(int i)
        {
            Boolean status = true;
            if (stacks[i].Count() == 0)
            {
                status = false;
            }
            return status;
        }

        public void move(int i, int j)
        {
            int num = stacks[i][stacks[i].Count() - 1];
            stacks[j].Add(num);
            stacks[i].RemoveAt(stacks[i].Count() - 1);
        }

        public Boolean win()
        {
            int success = 0;
            Boolean status = false;
            for (int i = 0; i < 4; i++)
            {

                if (stacks[i].Count() == 3)
                {
                    if (stacks[i][0] == stacks[i][1] && stacks[i][1] == stacks[i][2])
                    {
                        success++;
                    }
                }
                if (success == 3)
                {
                    status = true;
                }
            }
            return status;
        }

        public Game(String[] input)
        {
            for (int i = 0; i < 4; i++)
            {
                stacks[i] = new List<int>();
            }
            String[] split1 = input[0].Split(' ');
            String[] split2 = input[1].Split(' ');
            String[] split3 = input[2].Split(' ');
            String[] split4 = input[3].Split(' ');
            for (int i = 0; i < split1.Length; i++)
            {
                if (split1[i].Equals("1") || split1[i].Equals("2") || split1[i].Equals("3") || split1[i].Equals("4"))
                {
                    stacks[0].Add(int.Parse(split1[i]));
                }
            }
            for (int i = 0; i < split2.Length; i++)
            {
                if (split2[i].Equals("1") || split2[i].Equals("2") || split2[i].Equals("3") || split2[i].Equals("4"))
                {
                    stacks[1].Add(int.Parse(split2[i]));
                }
            }
            for (int i = 0; i < split3.Length; i++)
            {
                if (split3[i].Equals("1") || split3[i].Equals("2") || split3[i].Equals("3") || split3[i].Equals("4"))
                {
                    stacks[2].Add(int.Parse(split3[i]));
                }
            }
            for (int i = 0; i < split4.Length; i++)
            {
                if (split4[i].Equals("1") || split4[i].Equals("2") || split4[i].Equals("3") || split4[i].Equals("4"))
                {
                    stacks[3].Add(int.Parse(split4[i]));
                }
            }
        }
    }
}