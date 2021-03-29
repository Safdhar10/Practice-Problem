using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] _line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int _min = int.MaxValue;
            int _first = (N / 2)-1;
            int _S = 0;
            int _F = 0;
            for(int i=0;i<(_first+1);i++)
            {
                _S += (_line[i] | _line[i + 1]);
                _F += (_line[i] ^ _line[i + 1]);
            }
            int _S1 = 0;
            int _F1 = 0;
            for(int j=(_first+1);j<N-1;j++)
            {
                _S1 += (_line[j] | _line[j + 1]);
                _F1 += (_line[j] ^ _line[j + 1]);
            }
            Console.WriteLine(Math.Min(_S1,Math.Min(_S,Math.Min(_F,_F1))));
        }
    }
}
