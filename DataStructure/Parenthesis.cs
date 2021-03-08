using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library4
{
    public class Parenthesis
    {
        Stack<char> St = new Stack<char>(5);

        List<char> OpenParenthesis =new List<char>() { '{', '(', '[', '<' };
        List<char> ClosedParenthesis = new List<char>() { '}', ')', ']', '>' };
        public string ReverseString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                St.Push(input[i]);
            }
            return St.ToString();
        }
        public bool BalancedParanthesis(string input)
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
                    if (St.Count == 0)
                    {
                        return false;
                    }
                    if (St.Peek() == '(')
                    {
                        St.Pop();
                    }
                }

            }
            return St.Count == 0;
        }
        public bool IsPair(char _leftParanthesis, char _rightParanthesis)
        {

            if ((_leftParanthesis == '(' && _rightParanthesis == ')'))
            {
                return true;
            }
            else if ((_leftParanthesis == '{' && _rightParanthesis == '}'))
            {
                return true;
            }
            else if ((_leftParanthesis == '[' && _rightParanthesis == ']'))
            {
                return true;
            }
            else if ((_leftParanthesis == '<' && _rightParanthesis == '>'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BalancedBracket(string input)
        {
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
                    if (OpenParenthesis.IndexOf(St.Peek())!=ClosedParenthesis.IndexOf(input[i]))
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
