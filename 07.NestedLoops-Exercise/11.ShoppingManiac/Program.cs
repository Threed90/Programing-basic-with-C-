using System;

namespace _11.ShoppingManiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneys = int.Parse(Console.ReadLine());
            int clothsCounter = 0;
            int moneysLeft = moneys; 
            while (true)
            {
                string action = Console.ReadLine();
                if(action =="enough")
                {
                    break;
                }

                if(action == "enter")
                {
                    while (true)
                    {
                        string buys = Console.ReadLine();
                        if(buys =="leave")
                        {
                            break;
                        }
                        moneysLeft -= int.Parse(buys);
                        clothsCounter++;
                        if(moneysLeft<0)
                        {
                            Console.WriteLine("Not enough money.");
                            moneysLeft += int.Parse(buys);
                            clothsCounter--;
                        }
                        else if(moneysLeft == 0)
                        {
                            Console.WriteLine($"For {clothsCounter} clothes I spent {moneys} lv and have 0 lv left.");
                            return;
                        }
                        
                    }
                }
            }

            Console.WriteLine($"For {clothsCounter} clothes I spent {moneys-moneysLeft} lv and have {moneysLeft} lv left.");
        }
    }
}
