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
            RomanToInt RI = new RomanToInt();
            Console.WriteLine(RI.ConvertToInt("MMMCMXCIX"));
        }
    }
}
