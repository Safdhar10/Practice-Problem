using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IScream
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] get = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = get[0];
            int B = get[1];
            int MilkSolid = A + B;

            if(MilkSolid>=15 && B>=8)
            {
                Console.WriteLine(1);
                return;
            }
            if(MilkSolid>=10 && B>=3)
            {
                Console.WriteLine(2);
                return;
            }
            if(MilkSolid>=3 && B>=0)
            {
                Console.WriteLine(3);
                return;
            }
            Console.WriteLine(4) ;
        }
    }
}
