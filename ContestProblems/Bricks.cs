using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brick
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] get = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(get[0])/int.Parse(get[1]));
        }
    }
}
