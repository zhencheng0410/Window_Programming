using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Reversi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] chess = new string[10, 10];
            int empty = 0, x, y, temp = 0, circle = 0, cross = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    chess[i, j] = "- ";
                    chess[i, 0] = i + " ";
                }
            }
            chess[0, 0] = "  ";
            chess[0, 1] = "A ";
            chess[0, 2] = "B ";
            chess[0, 3] = "C ";
            chess[0, 4] = "D ";
            chess[0, 5] = "E ";
            chess[0, 6] = "F ";
            chess[0, 7] = "G ";
            chess[0, 8] = "H ";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (chess[i, j] == "- ")
                    {
                        empty++;
                    }
                }
            }

            while (empty >= 0)
            {

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(chess[i, j]);
                    }
                    Console.WriteLine();
                }
                if (empty % 2 == 0)
                {
                    Console.WriteLine("輪到玩家O 請輸入要下的位置:");
                    string position = Console.ReadLine();
                    string X = position.Substring(0, 1);
                    x = Convert.ToInt32(X[0]) - 'A' + 1;
                    y = int.Parse(position.Substring(1, 1));
                    if (chess[y, x] == "- ")
                    {
                        chess[y, x] = "O ";
                        empty = empty - 1;
                        for (int i = 1; i < x; i++)
                        {
                            if (chess[y, i] == "O ")
                            {
                                temp = i;
                                for (int j = temp; j < x; j++)
                                {
                                    if (chess[y, j] == "X ")
                                    {
                                        chess[y, j] = "O ";
                                    }
                                }
                            }

                        }
                        for (int i = x + 1; i <= 8; i++)
                        {
                            if (chess[y, i] == "O ")
                            {
                                temp = i;
                                for (int j = x + 1; j < temp; j++)
                                {
                                    if (chess[y, j] == "X ")
                                    {
                                        chess[y, j] = "O ";
                                    }
                                }
                            }

                        }
                        for (int i = 1; i < y; i++)
                        {
                            if (chess[i, x] == "O ")
                            {
                                temp = i;
                                for (int j = temp; j < y; j++)
                                {
                                    if (chess[j, x] == "X ")
                                    {
                                        chess[j, x] = "O ";
                                    }
                                }
                            }

                        }
                        for (int i = y + 1; i <= 8; i++)
                        {
                            if (chess[i, x] == "O ")
                            {
                                temp = i;
                                for (int j = y + 1; j <= temp; j++)
                                {
                                    if (chess[j, x] == "X ")
                                    {
                                        chess[j, x] = "O ";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("此位置已有棋子! 按任意鍵繼續遊戲");
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("輪到玩家X 請輸入要下的位置:");
                    string position = Console.ReadLine();
                    string X = position.Substring(0, 1);
                    x = Convert.ToInt32(X[0]) - 'A' + 1;
                    y = int.Parse(position.Substring(1, 1));
                    if (chess[y, x] == "- ")
                    {
                        chess[y, x] = "X ";
                        empty = empty - 1;
                        for (int i = 1; i < x; i++)
                        {
                            if (chess[y, i] == "X ")
                            {
                                temp = i;
                                for (int j = temp; j < x; j++)
                                {
                                    if (chess[y, j] == "O ")
                                    {
                                        chess[y, j] = "X ";
                                    }
                                }
                            }

                        }
                        for (int i = x + 1; i <= 8; i++)
                        {
                            if (chess[y, i] == "X ")
                            {
                                temp = i;
                                for (int j = x + 1; j < temp; j++)
                                {
                                    if (chess[y, j] == "O ")
                                    {
                                        chess[y, j] = "X ";
                                    }
                                }
                            }

                        }
                        for (int i = 1; i < y; i++)
                        {
                            if (chess[i, x] == "X ")
                            {
                                temp = i;
                                for (int j = temp; j < y; j++)
                                {
                                    if (chess[j, x] == "O ")
                                    {
                                        chess[j, x] = "X ";
                                    }
                                }
                            }

                        }
                        for (int i = y + 1; i <= 8; i++)
                        {
                            if (chess[i, x] == "X ")
                            {
                                temp = i;
                                for (int j = y + 1; j <= temp; j++)
                                {
                                    if (chess[j, x] == "O ")
                                    {
                                        chess[j, x] = "X ";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("此位置已有棋子! 按任意鍵繼續遊戲");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                if (empty == 0)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        for (int j = 1; j <= 8; j++)
                        {
                            if (chess[i, j] == "O ")
                            {
                                circle++;
                            }
                            else
                            {
                                cross++;
                            }
                        }
                    }
                    if (cross > circle)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            for (int j = 0; j < 9; j++)
                            {
                                Console.Write(chess[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("遊戲結束 玩家X獲勝!");
                        Console.ReadLine();
                        break;
                    }
                    else if (cross <= circle)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            for (int j = 0; j < 9; j++)
                            {
                                Console.Write(chess[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("遊戲結束 玩家O獲勝!");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
