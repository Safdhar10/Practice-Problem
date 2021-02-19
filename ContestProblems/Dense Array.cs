using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int TestCase = Convert.ToInt32(Console.ReadLine());
            while(TestCase>0)
            {
                int ArraySize = Convert.ToInt32(Console.ReadLine());
                int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int big = 0;
                int small = 0;
                int count = 0;
                for(int i=1;i<ArraySize;i++)
                {
                    big = Math.Max(Array[i], Array[i - 1]);
                    small = Math.Min(Array[i], Array[i - 1]);
                        while (big>small*2)
                        {
                            count++;
                            small = small * 2;
                        }
                }
                Console.WriteLine(count);
                TestCase--;
            }
            
        }
    }
}
