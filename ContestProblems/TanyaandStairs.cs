using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanyaAndStairways
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalSteps = Convert.ToInt32(Console.ReadLine());
            int[] TanyaPronouncedNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Count = 1;
            string stairs = "";
            for(int i=0;i<TotalSteps-1;i++)
            {
                if(TanyaPronouncedNumbers[i]>=TanyaPronouncedNumbers[i+1])
                {
                    Count = Count + 1;
                    stairs = stairs + TanyaPronouncedNumbers[i] + " ";
                }
            }
            stairs = stairs + TanyaPronouncedNumbers[TotalSteps - 1];
            Console.WriteLine(Count);
            Console.WriteLine(stairs);
        }
    }
}
