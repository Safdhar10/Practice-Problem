using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class RomanToInt
    {
        Dictionary<char, int> GetRomanValue = new Dictionary<char, int>();
        public RomanToInt()
        {
            GetRomanValue.Add('I', 1);
            GetRomanValue.Add('V', 5);
            GetRomanValue.Add('X', 10);
            GetRomanValue.Add('L', 50);
            GetRomanValue.Add('C', 100);
            GetRomanValue.Add('D', 500);
            GetRomanValue.Add('M', 1000);
        }
        public int ConvertToInt(string RomanLetters)
        {
            int _length = RomanLetters.Length;
            int _answer = 0;
            int _previousCharValue = 0;
            while(_length-->0)
            {
               
                int _charValue = GetRomanValue[RomanLetters[_length]];
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

        
    }
}
