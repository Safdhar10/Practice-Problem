using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfCubeRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            while (test-- > 0)
            {
                long x = Convert.ToInt64(Console.ReadLine());
                long calc = 0;
                long b3 = 0;
                long i = 1;
                bool ch = false;
                    while (i * i * i <= x)
                    {
                        calc = i * i * i;
                        b3 = x - calc;
                        i++;
                        if(b3!=0)
                        {
                            decimal check = (decimal)Math.Pow(b3, (double)1 / 3);
                            while (check * check * check > b3) check--;
                            while (check * check * check < b3) check++;
                            if (check * check * check == b3)
                            {
                                ch = true;
                                break;
                            }
                        }
                    }
                if(ch==true)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            
        }
    }
}
