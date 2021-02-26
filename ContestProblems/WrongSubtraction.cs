using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrongSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split();
            int n = int.Parse(number[0]);
            int time_to_decrease = int.Parse(number[1]);
            for (int i = 0; i < time_to_decrease; i++)
            {

                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                {
                    n = n - 1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
