using System;

namespace Age_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int mm;
            int dd;
            int yyyy;

            int MM = 8;
            int DD = 4;
            int YYYY = 2021;

            int x;
            int y;

            Console.WriteLine("Enter your birthday");
            dd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter yout birthmonth");
            mm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entr your birth year");
            yyyy = Convert.ToInt32(Console.ReadLine());

            if ((mm <= 7) && (mm % 2 == 0))
            {
                x = 30;
            }
            else if ((mm <= 7) && !(mm % 2 == 0))
            {
                x = 31;
            }
            else if (mm == 2)
            {
                if (yyyy % 4 == 0)
                {
                    x = 29;
                }
                else 
                {
                    x = 28;
                }
            }
            else
            {
                x = 30; 
            }

            if (mm > MM)
            {
                MM += 12;
                YYYY -= 1;
            }
            if (dd > DD)
            {
                DD += x;
                MM -= 1;
            }
            Console.WriteLine("You`re {0} year(s) {1} month(s) and {2} day(s)", (YYYY - yyyy), (MM - mm), (DD - dd));
        }
    }
}
