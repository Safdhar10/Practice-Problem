using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofRoominEachFloor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = _input[0];
            int K = _input[1];

            int Start = 0;
            int result = 0;

            for(int i=1;i<=N;i++)
            {
                Start += 100;
                for(int j=1;j<=K;j++)
                {
                    int temp = ++Start;
                    result += temp;
                }
                Start -= K;
            }
            Console.WriteLine(result) ;
        }
    }
}
