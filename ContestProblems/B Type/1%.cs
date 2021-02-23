using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1yEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 X = Convert.ToInt64(Console.ReadLine());
            Int64 n = 100;
            int year = 0;
            while(n<X)
            {
                n =n+(n/100);
                year++;
            }
            Console.WriteLine(year);
        }
    }
}
