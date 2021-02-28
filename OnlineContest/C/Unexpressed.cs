using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unexpressed
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long x = 2;
            long i = 2;
            Dictionary<long,int> check = new Dictionary<long, int>();
            while(i*i<=n)
            {
                long sum = i*i;
                while(sum<=n)
                {
                    if(!check.ContainsKey(sum))
                    {
                        check.Add(sum, 1);

                    }
                    sum = sum * i;
                }
                i++;
            }
            Console.WriteLine(n-check.Count());
        }
    }
}
