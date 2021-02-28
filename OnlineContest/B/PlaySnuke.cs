using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaySnuke
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int min = int.MaxValue;
            for(int i=0;i<n;i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = line[0];
                int p = line[1];
                int x = line[2];
                if(a<x)
                {
                    if(min>p)
                    {
                        min = p;
                    }
                }
            }
            if(min==int.MaxValue)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(min);
            }
        }
    }
}
