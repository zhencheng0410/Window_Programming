using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Schedule_Assistant
{
    class Program
    {
        static void Main(string[] args)
        {
            int type = 0, success = 0, credit = 0, isdelete = 0;
            string[,] str = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    str[i, j] = "      ";
                }
            }
            while (type != 5)
            {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式");
                Console.Write("請輸入數字選擇功能：");
                type = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
                        string course = Console.ReadLine();
                        string[] information = course.Split(' ');
                        string coursename = information[0];
                        int day = int.Parse(information[1]);
                        if (day == 7)
                        {
                            day = 1;
                        }
                        else
                        {
                            day += 1;
                        }
                        int start = int.Parse(information[2]);
                        int end = int.Parse(information[3]);
                        for (int i = start; i <= end; i++)
                        {
                            if (str[i, day] != "      ")
                            {
                                success = 1;
                            }
                        }
                        for (int i = 1; i <= 8; i++)
                        {
                            for (int j = 1; j <= 7; j++)
                            {
                                if (str[i, j].Equals(coursename) == true)
                                {
                                    success = 2;
                                }
                            }
                        }
                        if (success == 1)
                        {
                            Console.WriteLine("課程衝堂!");
                            success = 0;
                        }
                        else if (success == 2)
                        {
                            Console.WriteLine("課程重複!");
                            success = 0;
                        }
                        else if (success == 0)
                        {
                            Console.WriteLine("成功加入課程!");
                            for (int i = start; i <= end; i++)
                            {
                                str[i, day] = string.Copy(coursename);
                            }
                        }
                        break;
                    case 2:
                        Console.Write("請輸入要刪除的課程代碼:");
                        string delete = Console.ReadLine();
                        for (int i = 1; i <= 8; i++)
                        {
                            for (int j = 1; j <= 7; j++)
                            {
                                if (delete.Equals(str[i, j]) == true)
                                {
                                    str[i, j] = "      ";
                                    isdelete = 1;
                                }
                            }
                        }
                        if (isdelete == 1)
                        {
                            Console.WriteLine("成功刪除課程: " + delete);
                            isdelete = 0;
                        }
                        else
                        {
                            Console.WriteLine("課程 {0} 不在課表中", delete);
                        }
                        break;
                    case 3:
                        str[0, 0] = "      ";
                        str[0, 1] = "Sun   ";
                        str[0, 2] = "Mon   ";
                        str[0, 3] = "Tue   ";
                        str[0, 4] = "Wed   ";
                        str[0, 5] = "Thu   ";
                        str[0, 6] = "Fri   ";
                        str[0, 7] = "Sat   ";
                        str[1, 0] = "1     ";
                        str[2, 0] = "2     ";
                        str[3, 0] = "3     ";
                        str[4, 0] = "4     ";
                        str[5, 0] = "5     ";
                        str[6, 0] = "6     ";
                        str[7, 0] = "7     ";
                        str[8, 0] = "8     ";
                        for (int j = 0; j <= 9; j++)
                        {
                            for (int i = 0; i <= 8; i++)
                            {
                                Console.Write(String.Format("{0,-6}", str[j, i]));
                                if (i == 8)
                                {
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 4:
                        for (int i = 1; i <= 8; i++)
                        {
                            for (int j = 1; j <= 7; j++)
                            {
                                if (str[i, j] != "      ")
                                {
                                    credit += 1;
                                }
                            }
                        }
                        Console.WriteLine(credit);
                        credit = 0;
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
