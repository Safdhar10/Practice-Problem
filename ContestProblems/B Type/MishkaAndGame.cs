using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishikAndGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0; 
            int sum2 = 0; 
            for (int i = 0; i < n; i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int M = line[0];
                int C = line[1];
                if (M == C)
                {
                    continue;
                }
                else if(M>C)
                {
                    sum1++;
                }
                else if(M<C)
                {
                    sum2++;
                }
            }
            if (sum1>sum2)
            {
                Console.WriteLine("Mishka");
            }
            else if(sum2>sum1)
            {
                Console.WriteLine("Chris");
            }
            else
            {
                Console.WriteLine("Friendship is magic!^^");
            }
        }
    }
}
