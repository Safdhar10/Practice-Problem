using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerContest195
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M = _line[0];
            int H = _line[1];

            if (H % M == 0)
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
