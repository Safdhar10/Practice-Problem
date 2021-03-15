using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commas
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = Convert.ToInt64(Console.ReadLine());
            int Digit=(int) Math.Floor(Math.Log(N,10))+1;
            long _start = 1000;
            long _totalNoOfCommas = 0;
            while(N>=_start)
            {
                _totalNoOfCommas = _totalNoOfCommas + (N - _start + 1);
                _start = _start * 1000;
            }
            Console.WriteLine(_totalNoOfCommas);
        }
    }
}
