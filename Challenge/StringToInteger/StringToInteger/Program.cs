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
            Console.WriteLine(WhiteSpace("++12345"));
            //Console.WriteLine(int.Parse("123.32"));
        }
        public static int WhiteSpace(string Number)
        {
            int _answer = 0;
            int _minusCount = 0;
            int _rangeCount = 0;
            int _positiveCount = 0;
            for (int i = 0; i < Number.Length; i++)
            {
                if ((Number[i] >= 48 && Number[i] <= 57))
                {
                    int _digitValue = Number[i] - 48;
                    _answer = (_answer * 10) + _digitValue;
                    _rangeCount++;
                    if(_rangeCount>10)
                    {
                        throw new ArithmeticException("Integer overflow has occurred");
                    }
                }
                else if (_rangeCount==0 && Number[i] == '-')
                {
                    if (_minusCount < 1)
                        _minusCount++;
                    else
                        throw new FormatException("Input string is not in the right format");
                }
                else if(_rangeCount==0 && Number[i]=='+')
                {
                    _positiveCount++;
                    if(_positiveCount>1)
                    {
                        throw new FormatException("Input string is not in the right format");
                    }
                }
                else if (_rangeCount>0)
                {
                    if (Number[i] == '.')
                    {
                        for(int j=i+1;j<Number.Length;j++)
                        {
                            if(Number[j]=='.')
                            {
                                throw new FormatException("Input string is not in the right format");
                            }
                        }
                        break;
                    }
                    else
                       throw new FormatException("Input string is not in the right format");
                }
            }
            _answer = _minusCount == 1 ? (_answer * -1) : _answer;

            if (_minusCount == 0 && _answer < 0)
                throw new ArithmeticException("Integer overflow has occurred");
            else if (_minusCount == 1 && _answer > 0)
                throw new ArithmeticException("Integer overflow has occurred");

            return _rangeCount>0?_answer:throw new FormatException("Input string is not in the right format");
        }


    }
}
