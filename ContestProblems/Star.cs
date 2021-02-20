using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerContest_Feb20_
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int R = X % 100;
            Console.WriteLine(100-R);
        }
    }
}
