using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _line1 = Console.ReadLine().Split();
            string[] _line2 = Console.ReadLine().Split();
            string[] _line3 = Console.ReadLine().Split();
            string[] _line4 = Console.ReadLine().Split();
            Stack<int> _s1 = new Stack<int>();
            Stack<int> _s2 = new Stack<int>();
            Stack<int> _s3 = new Stack<int>();
            int MaxLenth = Math.Max(_line2.Length, Math.Max(_line3.Length, _line4.Length));
            for (int i = MaxLenth - 1; i >= 0; i--)
            {
                if (_line2.Length > i)
                {
                    _s1.Push(Convert.ToInt32(_line2[i]));
                }
                if (_line3.Length > i)
                {
                    _s2.Push(Convert.ToInt32(_line3[i]));
                }
                if (_line4.Length > i)
                {
                    _s3.Push(Convert.ToInt32(_line4[i]));
                }
            }
            int _s1Sum = _s1.Sum();
            int _s2Sum = _s2.Sum();
            int _s3Sum = _s3.Sum();
            while (!(_s1Sum == _s2Sum && _s2Sum == _s3Sum))
            {
                if (_s1Sum > _s2Sum || _s1Sum > _s3Sum)
                {
                    _s1Sum -= _s1.Pop();
                }
                if (_s2Sum > _s1Sum || _s2Sum > _s3Sum)
                {
                    _s2Sum -= _s2.Pop();
                }
                if (_s3Sum > _s1Sum || _s3Sum > _s2Sum)
                {
                    _s3Sum -= _s3.Pop();
                }
            }
            Console.WriteLine(_s1Sum);
        }
    }
}
