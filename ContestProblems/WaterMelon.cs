using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterMelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight =Convert.ToInt32(Console.ReadLine());
            if (weight > 2 & weight % 2 == 0)
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
