using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = Convert.ToInt32(Console.ReadLine());
            while(testcase-->0)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int K = 3;
                int[] get = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] count = new int[K];
                for(int j=0;j<N;j++)
                {
                    count[get[j] % K]++;
                }
                int i = 0;
                int move = 0;
                int Next = 0;
                int current = 0;
                while(count.Distinct().Count()!=1)
                {
                    Next =Next+ 1;
                    current =Next-1;
                    if (current==K-1)
                    {
                        Next = 0;
                    }
                    if(count[current]>(N/K))
                    {
                        count[Next] += count[current] - (N / K);
                        move += count[current] - (N / K);
                        count[current] = N / K;
                    }
                }
                Console.WriteLine(move);
            }
        }
    }
}
