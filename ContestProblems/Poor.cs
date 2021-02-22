using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] get = Console.ReadLine().Split();
            int a = int.Parse(get[0]);
            int b = int.Parse(get[1]);
            int c = int.Parse(get[2]);
            int x = a ^ b ^ c;
            if ((x==a) || (x==b) || (x==c))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
