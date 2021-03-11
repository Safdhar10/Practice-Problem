using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBracket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                bool _check = BalancedBracket(Console.ReadLine());
                if(_check)
                Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
//{[()]}
//{[(])}
//{{[[(())]]}}
        }
        public static bool BalancedBracket(string input)
        {
            List<char> OpenParenthesis = new List<char>() { '{', '(', '[', '<' };
            List<char> ClosedParenthesis = new List<char>() { '}', ')', ']', '>' };
            Stack<char> St = new Stack<char>();
            int _length = input.Length;
            for (int i = 0; i < _length; i++)
            {
                //input[i] == '(' || input[i] == '{' || input[i] == '[' || input[i] == '<'
                if (OpenParenthesis.Contains(input[i]))
                {
                    St.Push(input[i]);
                }
                //input[i] == ')' || input[i] == '}' || input[i] == ']' || input[i] == '>'
                if (ClosedParenthesis.Contains(input[i]))
                {
                    if (St.Count == 0)
                    {
                        return false;
                    }
                    //IsPair(St.Peek(), input[i])
                    if (OpenParenthesis.IndexOf(St.Peek()) != ClosedParenthesis.IndexOf(input[i]))
                    {
                        return false;
                    }
                    St.Pop();
                }
            }
            return St.Count == 0;
        }
    }
}
