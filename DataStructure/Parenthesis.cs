using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthesisUsingStack
{
    public class Parenthesis
    {
        Stack<char> St = new Stack<char>();
        public bool BalancedParanthesis(char[] input)
        {
            int _charLength = input.Length;
            for (int i = 0; i < _charLength; i++)
            {
                if (input[i] == '(')
                {
                    St.Push(input[i]);
                }
                if (input[i] == ')')
                {
                    if (St.Count > 0)
                    {
                        if (St.Peek() == '(')
                        {
                            St.Pop();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (St.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
