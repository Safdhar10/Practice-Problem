using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = _line[0];
            int B = _line[1];
            int C = _line[2] * 1000;
            int _upper =C / A;
            int _lower =(int) Math.Ceiling(C / (double)B);
            if(_lower<=_upper)
            {
                Console.WriteLine(_lower + " "+ _upper);
            }
            else
            {
                Console.WriteLine("UNSATISFIABLE ");
            }

        }
    }
}
