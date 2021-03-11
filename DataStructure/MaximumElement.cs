using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Stack<int> _s1 = new Stack<int>();
            for(int i=1;i<=N;i++)
            {
                int[] _nextLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(_nextLine[0]==2)
                {
                    _s1.Pop();
                }
                else if(_nextLine[0]==3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(_s1.Peek());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    _s1.Push(_nextLine[1]);
                }

            }


        }
    }
}
