using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJAck
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] get = Console.ReadLine().Split();
            if (int.Parse(get[0]) + int.Parse(get[1]) + int.Parse(get[2]) >= 22)
            {
                Console.WriteLine("bust");
            }
            else
            {
                Console.WriteLine("win");
            }
        }
    }
}
