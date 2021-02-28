using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerContest_27Feb_
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] line = Console.ReadLine().Split().Select(float.Parse).ToArray();
            float A = line[0];
            float B = line[1];
            float check = A - B;
            double result = (check / A)*100.00;
            Console.WriteLine(result);
        }
    }
}
