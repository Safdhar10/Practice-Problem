using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyDetected
{
    class Program
    {
        static void Main(string[] args)
        {
            int _t = Convert.ToInt32(Console.ReadLine());
            for(int j=0;j<_t;j++)
            {
                int _n = Convert.ToInt32(Console.ReadLine());
                int[] _a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int i = 0; i < _n-1; i++)
                {
                    if (_a[i]!=_a[i+1])
                    {
                        if(i==_n-2)
                        {
                            Console.WriteLine(i+2);
                            break;
                        }
                        if (_a[i+1]!=_a[i+2])
                        {
                            Console.WriteLine(i+2);
                            break;
                        }
                        Console.WriteLine(i+1);
                        break;
                    }
                }
            }
            
        }
    }
}
