using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library4
{
    public class EvaluateExpression
    {
        Stack<int> Number = new Stack<int>(10);
        Stack<char> Operator = new Stack<char>(10);
        public int Evaluate(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                if (input[i] == '(')
                {
                    continue;
                }
                else if (char.IsDigit(input[i]))
                {
                    StringBuilder digit = new StringBuilder();
                    while (i < length && char.IsDigit(input[i]))
                    {
                        digit.Append(input[i]);
                        i++;
                    }
                    Number.Push(int.Parse(digit.ToString()));
                    i--;
                }
                else if (input[i] == ')')
                {
                    Number.Push(ProceedOperation(Operator.Pop(),
                                     Number.Pop(),
                                    Number.Pop()));
                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    Operator.Push(input[i]);
                }
            }
            while (Operator.Count > 0)
            {
                Number.Push(ProceedOperation(Operator.Pop(), Number.Pop(), Number.Pop()));
            }
            return Number.Pop();
        }
        public int ProceedOperation(char op, int value2, int value1)
        {
            if (op == '+')
            {
                return value1 + value2;
            }
            else if (op == '-')
            {
                return value1 - value1;
            }
            else if (op == '*')
            {
                return value1 * value2;
            }
            else if (op == '/')
            {
                if (value2 != 0)
                {
                    return value1 / value2;
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            else
            {
                return 0;
            }
        }
        public bool BodmasRule(char currentOperator,
                                         char previousOperator)
        {
            if (previousOperator == '(' || previousOperator == ')')
            {
                return false;
            }
            if (currentOperator == '/' && (previousOperator == '*' || previousOperator == '+' || previousOperator == '-'))
            {
                return false;
            }
            else if (currentOperator == '*' && (previousOperator == '+' || previousOperator == '-'))
            {
                return false;
            }
            else if (currentOperator == '+' && (previousOperator == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
