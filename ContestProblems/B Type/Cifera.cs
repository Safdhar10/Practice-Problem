using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifera
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 K = Convert.ToInt64(Console.ReadLine());
            Int64 l = Convert.ToInt64(Console.ReadLine());
            decimal x =(decimal) Math.Log(l, K);
            decimal floor = Math.Floor(x);
            decimal seal = Math.Ceiling(x);
            if(floor==seal)
            {
                Console.WriteLine("YES");
                Console.WriteLine(floor-1);
            }
            else
            {
                Console.WriteLine("NO");
            }
            //if()
            //{
            //    Console.WriteLine("YES");
            //    Console.WriteLine(x-1);
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            
            //while(x<l)
            //{
            //    i++;
            //    x = Math.Pow(K, i);
            //}
            //if(x==l)
            //{
            //    Console.WriteLine("YES");
            //    Console.WriteLine(i-1);
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
        }
    }
}
