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

            int MM = DateTime.Now.Month;
            int DD = DateTime.Now.Day;
            int YYYY = DateTime.Now.Year;

            int x;
            
            Console.WriteLine("Enter your birthday");
            dd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter yout birthmonth");
            mm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entr your birth year");
            yyyy = Convert.ToInt32(Console.ReadLine());

            if ((MM <= 7) && (MM % 2 == 0))
            {
                x = 30;
            }
            else if ((MM <= 7) && !(MM % 2 == 0))
            {
                x = 31;
            }
            else if (MM == 2)
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
            else if ((MM > 7) && (MM % 2 == 0))
            {
                x = 31; 
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
            Console.WriteLine($"You`re {YYYY - yyyy} year(s) {MM - mm} month(s) and {DD - dd} day(s) old");
        }
    }
}
