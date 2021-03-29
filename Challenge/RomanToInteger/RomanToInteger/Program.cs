using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt ri = new RomanToInt();
            Console.WriteLine(ri.ConvertToInt("MMMCMXCIX"));
        }
    }
}
