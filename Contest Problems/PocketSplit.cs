using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pockets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] get = Console.ReadLine().Split();
            int NewCount=0;
            int largest = 1;
            for(int i=1;i<=100;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(i==int.Parse(get[j]))
                    {
                        NewCount++;
                    }
                }
                if(largest<NewCount)
                {
                    largest = NewCount;
                }
                NewCount = 0;
            }
            Console.WriteLine(largest);
            //for(int i=0;i<n-1;i++)
            //{
            //    if(get[i]==get[i+1])
            //    {
            //        Scount = Scount + 1;
            //    }
            //    else
            //    {
            //        Scount = 1;
            //    }
            // if(largest<=Scount)
            // {
            //    largest = Scount;
            //  }
            //}
        }
    }
}
