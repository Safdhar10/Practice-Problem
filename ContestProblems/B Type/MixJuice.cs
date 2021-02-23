using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixJuice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = line[0];
            int K = line[1];
            int[] line2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int small = int.MinValue;
            //Array.Sort(line2);
            //for(int i=0;i<K;i++)
            //{
            //    small = small + line2[i];
            //}
            //Console.WriteLine(small);
            int index = N;
            int sum = 0;
            Dictionary<int, int> Ka = new Dictionary<int, int>();
            for(int i=0;i<K;i++)
            {
                int smallest = int.MaxValue;
                for(int j=0;j<N;j++)
                {
                    if(smallest>line2[j] && line2[j]>=small)
                    {
                        if(!Ka.ContainsKey(j))
                        {
                            smallest = line2[j];
                            index = j;
                        }
                    }
                }
                Ka.Add(index, line2[index]);
                small = smallest;
                sum += small;
            }
            Console.WriteLine(sum);
        }
    }
}
