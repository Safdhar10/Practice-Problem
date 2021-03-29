using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WhiteSpace(" "));
        }
        public static int WhiteSpace(string Number)
        {
            bool _digitCame = false;
            int _answer = 0;
            int _minusCount = 0;
            if (Number == "2147483648" || Number.Equals("-2147483648"))
            {
                throw new ArithmeticException("Integer overflow has occurred");
            }
            for (int i = 0; i < Number.Length; i++)
            {
                if ((Number[i] >= 48 && Number[i] <= 57))
                {
                    int _digitValue = Number[i] - 48;
                    _answer = (_answer * 10) + _digitValue;
                    _digitCame = true;
                }
                else if(!_digitCame && Number[i]=='-')
                {
                    if (_minusCount < 1)
                        _minusCount++;
                    else
                        throw new FormatException("Input string is not in the right format");

                }
                else if(_digitCame)
                {
                    if (Number[i] == '-')
                        throw new FormatException("Input string is not in the right format");
                    else
                        break;
                }
            }
            _answer= _minusCount == 1 ? (_answer * -1) : _answer;
            return _digitCame?_answer:throw new FormatException("Input string is not in the right format");
        }


    }
}
