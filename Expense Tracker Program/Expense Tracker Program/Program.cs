using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int type = 0, expense_type, income = 0, expense, eat = 0, cloth = 0, live = 0, transport = 0, fun = 0, money = 0, remain = 0;
            double eat_per, cloth_per, live_per, transport_per, fun_per;
            while (type != 5)
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
                Console.Write("輸入數字選擇功能:");
                type = int.Parse(Console.ReadLine());
                if (type == 1)
                {
                    Console.Write("輸入金額:");
                    int amount = int.Parse(Console.ReadLine());
                    income += amount;
                }
                else if (type == 2)
                {
                    Console.WriteLine("(1)食 (2)衣 (3)住 (4)行 (5)育樂");
                    Console.Write("輸入數字選擇支出項目: ");
                    expense_type = int.Parse(Console.ReadLine());
                    Console.Write("輸入支出金額: ");
                    expense = int.Parse(Console.ReadLine());
                    if (expense_type == 1)
                    {
                        eat += expense;
                        money += expense;
                    }
                    else if (expense_type == 2)
                    {
                        cloth += expense;
                        money += expense;
                    }
                    else if (expense_type == 3)
                    {
                        live += expense;
                        money += expense;
                    }
                    else if (expense_type == 4)
                    {
                        transport += expense;
                        money += expense;
                    }
                    else if (expense_type == 5)
                    {
                        fun += expense;
                        money += expense;
                    }
                }

                else if (type == 3)
                {
                    if (money == 0)
                    {
                        Console.WriteLine("食: 0%");
                        Console.WriteLine("衣: 0%");
                        Console.WriteLine("住: 0%");
                        Console.WriteLine("行: 0%");
                        Console.WriteLine("育樂: 0%");
                    }
                    else
                    {
                        eat_per = (double)eat * 100 / money;
                        cloth_per = (double)cloth * 100 / money;
                        live_per = (double)live * 100 / money;
                        transport_per = (double)transport * 100 / money;
                        fun_per = (double)fun * 100 / money;
                        Console.WriteLine("食: " + eat_per + "%");
                        Console.WriteLine("衣: " + cloth_per + "%");
                        Console.WriteLine("住: " + live_per + "%");
                        Console.WriteLine("行: " + transport_per + "%");
                        Console.WriteLine("育樂: " + fun_per + "%");
                    }
                }
                else if (type == 4)
                {
                    remain = income - money;
                    Console.WriteLine("剩餘金額為: " + remain);
                }
                Console.WriteLine();
            }
        }
    }
}
