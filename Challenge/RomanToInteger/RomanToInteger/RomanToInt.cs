using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class RomanToInt
    {
        public int ConvertToInt(string RomanLetters)
        {
            int _length = RomanLetters.Length;
            int _answer = 0;
            int _previousCharValue = 0;
            while(_length-->0)
            {
                int _charValue = GetRomanValue(RomanLetters[_length]);
                if(_previousCharValue<=_charValue)
                {
                    _answer += _charValue;
                }
                else
                {
                    _answer -= _charValue;
                }
                _previousCharValue = _charValue;
            }
            return _answer;
        }

        public int GetRomanValue(char RomanChar)
        {
            if(RomanChar=='I')
            {
                return 1;
            }
            else if(RomanChar=='V')
            {
                return 5;
            }
            else if(RomanChar=='X')
            {
                return 10;
            }
            else if(RomanChar=='L')
            {
                return 50;
            }
            else if(RomanChar=='C')
            {
                return 100;
            }
            else if(RomanChar=='D')
            {
                return 500;
            }
            else
            {
                return 1000;
            }
        }
    }
}
