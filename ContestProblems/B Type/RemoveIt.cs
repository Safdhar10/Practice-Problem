using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdysseyContest_Feb23_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = line1[0];
            int X = line1[1];
            string[] line2 = Console.ReadLine().Split();
            for(int i=0;i<N;i++)
            {
               if(line2[i]!=X.ToString())
                {
                    Console.Write(line2[i]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
