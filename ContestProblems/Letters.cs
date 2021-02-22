using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] line1 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long Dorm = line1[0];
            long Letters = line1[1];
            long[] line2 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] line3 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long CurrenctDorm = 0;
            long CurrentFloor = 0;
            long Check = 0;
            long count = 0;
            long j = 0;
            for(int i=0;i<line2.Length;i++)
            {
                CurrenctDorm =CurrenctDorm+ line2[i];
                CurrentFloor =CurrentFloor +1;
                for(j=count;j<line3.Length;j++)
                {
                    if(line3[j]<=CurrenctDorm)
                    {
                        Console.WriteLine(CurrentFloor+" "+(line3[j]-Check));
                    }
                    else
                    {
                        break;
                    }
                }
                count = j;
                Check = CurrenctDorm;
            }

        }
    }
}
