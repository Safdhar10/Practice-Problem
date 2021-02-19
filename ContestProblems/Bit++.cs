using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int X = 0;
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                if (str == "++X")
                {
                    ++X;
                }
                else if (str == "--X")
                {
                    --X;
                }
                else if (str == "X++")
                {
                    X++;
                }
                else if (str == "X--")
                {
                    X--;
                }
            }
            Console.WriteLine(X);
        }
    }
}
