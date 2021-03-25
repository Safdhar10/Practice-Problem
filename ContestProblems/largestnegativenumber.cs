using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MinValue;
            int[] array = new int[] { -1, -214748364, 3 };
            bool check = false;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]<0)
                {
                    if (array[i] > min)
                    {
                        min = array[i];
                        check = true;
                    }
                }
            }
            Console.WriteLine(check?min:-1);
        }
    }
}
