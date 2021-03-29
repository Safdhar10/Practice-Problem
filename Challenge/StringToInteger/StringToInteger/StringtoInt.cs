using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger
{
    class StringtoInt
    {
        public int ConvertoInt(string Number)
        {
            int _length = Number.Length;
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<Number.Length;i++)
            {
                if(Number[i]>='0' && Number[i]<='9')
                {
                    sb.Append(Number[i]);
                }
            }
            return Convert.ToInt32(sb);
        }
    }
}
