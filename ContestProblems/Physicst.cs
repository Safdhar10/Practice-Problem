using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physicist
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int y = 0;
            int z = 0;
            for(int i=0;i<N;i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                x = x + line[0];
                y = y + line[1];
                z = z + line[2];

            }
            if(x==0 & y==0 & z==0)
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
