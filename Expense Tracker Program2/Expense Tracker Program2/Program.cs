using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker_Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int type = 0, income = 0, expense, total = 0, remain, expense_order = 0;
            int[] money = new int[5];
            double[] per = new double[5];
            string[] str = new string[5];
            str[0] = string.Empty;
            str[1] = string.Empty;
            str[2] = string.Empty;
            str[3] = string.Empty;
            str[4] = string.Empty;
            while (type != 8)
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能:");
                type = int.Parse(Console.ReadLine());
                if (type == 1)
                {
                    Console.Write("輸入金額:");
                    String amount = Console.ReadLine();
                    int n;
                    bool isstring = int.TryParse(amount, out n);
                    if (isstring == false)
                    {
                        Console.WriteLine("請輸入數字");
                    }
                    else
                    {
                        int amountnum = int.Parse(amount);
                        if (amountnum < 0)
                        {
                            Console.WriteLine("收入不可為負數");
                        }
                        else
                        {
                            income += amountnum;
                        }
                    }

                }
                else if (type == 2)
                {
                    if (str[0] == string.Empty && str[1] == string.Empty && str[2] == string.Empty && str[3] == string.Empty && str[4] == string.Empty)
                    {
                        Console.WriteLine("請新增支出項目");
                    }
                    for (int i = 0; i < expense_order; i++)
                    {
                        if (str[i] != string.Empty)
                        {
                            Console.Write("(" + (i + 1) + ")" + str[i]);
                        }
                    }
                    if (str[0] != string.Empty || str[1] != string.Empty || str[2] != string.Empty || str[3] != string.Empty || str[4] != string.Empty)
                    {
                        Console.WriteLine();
                        Console.Write("輸入數字選擇支出項目:");
                        int expense_type = int.Parse(Console.ReadLine());
                        if (expense_type > expense_order + 1)
                        {
                            Console.WriteLine("此數字不在範圍內");
                        }
                        else
                        {
                            Console.Write("輸入支出金額:");
                            expense = int.Parse(Console.ReadLine());
                            if (expense > income)
                            {
                                Console.WriteLine("存款不足");
                            }
                            switch (expense_type)
                            {
                                case 1:
                                    money[0] += expense;
                                    break;
                                case 2:
                                    money[1] += expense;
                                    break;
                                case 3:
                                    money[2] += expense;
                                    break;
                                case 4:
                                    money[3] += expense;
                                    break;
                                case 5:
                                    money[4] += expense;
                                    break;
                            }
                            total += expense;
                        }
                    }
                }
                else if (type == 3)
                {
                    if (expense_order < 5)
                    {
                        Console.Write("輸入項目名稱:");
                        string item = Console.ReadLine();
                        str[expense_order] = String.Copy(item);
                        expense_order++;
                        for (int i = 0; i < expense_order - 1; i++)
                        {
                            if (item.Equals(str[i]) == true)
                            {
                                Console.WriteLine("支出項目已存在");
                                str[expense_order - 1] = string.Empty;
                                expense_order -= 1;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("已無法再新增支出項目");
                    }


                }
                else if (type == 4)
                {
                    if (str[0] == string.Empty)
                    {
                        Console.WriteLine("已無法再刪除支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱:");
                        string item_delete = Console.ReadLine();
                        if (item_delete.Equals(str[0]) == true)
                        {
                            total -= money[0];
                            for (int i = 0; i < 4; i++)
                            {
                                str[i] = string.Copy(str[i + 1]);
                                money[i] = money[i + 1];
                            }
                            str[4] = string.Empty;
                            money[4] = 0;
                            expense_order -= 1;
                        }
                        else if (item_delete.Equals(str[1]) == true)
                        {
                            total -= money[1];
                            for (int i = 1; i < 4; i++)
                            {
                                str[i] = string.Copy(str[i + 1]);
                                money[i] = money[i + 1];
                            }
                            str[4] = string.Empty;
                            money[4] = 0;
                            expense_order -= 1;
                        }
                        else if (item_delete.Equals(str[2]) == true)
                        {
                            total -= money[2];
                            for (int i = 2; i < 4; i++)
                            {
                                str[i] = string.Copy(str[i + 1]);
                                money[i] = money[i + 1];
                            }
                            str[4] = string.Empty;
                            money[4] = 0;
                            expense_order -= 1;

                        }
                        else if (item_delete.Equals(str[3]) == true)
                        {
                            total -= money[3];
                            for (int i = 3; i < 4; i++)
                            {
                                str[i] = string.Copy(str[i + 1]);
                                money[i] = money[i + 1];
                            }
                            str[4] = string.Empty;
                            money[4] = 0;
                            expense_order -= 1;
                        }
                        else if (item_delete.Equals(str[4]) == true)
                        {
                            total -= money[4];
                            str[4] = string.Empty;
                            money[4] = 0;
                            expense_order -= 1;
                        }
                        else
                        {
                            Console.WriteLine("此項目不存在");
                        }
                    }
                }
                else if (type == 5)
                {
                    if (total == 0)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (str[i] != string.Empty)
                            {
                                Console.WriteLine("(" + (i + 1) + ")" + str[i] + ": " + "0%");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            per[i] = money[i] * 100.00 / total;
                        }
                        for (int i = 0; i < expense_order; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ")" + str[i] + ": " + per[i] + "%");
                        }
                    }

                }
                else if (type == 6)
                {
                    Console.WriteLine("目前總支出: " + total);
                    Console.Write("輸入要查詢的項目:　");
                    String check = Console.ReadLine();
                    for (int i = 0; i < 5; i++)
                    {
                        if (check.Equals(str[i]) == true)
                        {
                            Console.WriteLine(str[i] + ": " + money[i]);
                        }
                    }
                    if (check.Equals(str[0]) == false && check.Equals(str[1]) == false && check.Equals(str[2]) == false && check.Equals(str[3]) == false && check.Equals(str[4]) == false)
                        Console.WriteLine("此項目不存在");
                }
                else if (type == 7)
                {
                    remain = income - total;
                    Console.WriteLine("剩餘金額為: " + remain);
                }
                Console.WriteLine();
            }
        }
    }
}
