using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFulMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dg=Console.ReadLine().Split('+');

            int i1 = 0;
            int i2 = 0;
            int i3 = 0;

            for (int i = 0; i < dg.Length; i++)
            {
                if ( dg[i] == "1")
                {
                    i1 = i1 + 1;
                }
                else if ( dg[i] == "2")
                {
                    i2 = i2 + 1;
                }
                else
                {
                    i3 = i3 + 1;
                }
            }
            string result = "";
                while (i1-- > 0)
                {
                    result = result + "1+".ToString();
                }
                while (i2-- > 0)
                {
                    result = result + "2+".ToString();
                }
                while (i3-- > 0)
                {
                    result = result + "3+".ToString();
                }
            result = result.Remove(result.Length - 1, 1);
            Console.WriteLine(result);
           
        }
    }
}
