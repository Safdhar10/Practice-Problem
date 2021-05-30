
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinchirorin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if(_input[0]==_input[1])
            {
                Console.WriteLine(_input[2]);
            }
            else if(_input[1] == _input[2])
            {
                Console.WriteLine(_input[0]);
            }
            else if(_input[0] == _input[2])
            {
                Console.WriteLine(_input[1]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
