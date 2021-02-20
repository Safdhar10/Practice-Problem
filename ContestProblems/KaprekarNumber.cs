using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            string gx1 = line[0];
            int k = int.Parse(line[1]);
            while(k>0)
            {
                 gx1 = (Int64.Parse(DscendingCheck(gx1)) - Int64.Parse(AscendingCheck(gx1))).ToString();
                k--;
            }
            Console.WriteLine(gx1);

        }
        public static string AscendingCheck(string gx1)
        {
            Int64[] array = new Int64[gx1.Length];
            string gx2 = "";
            for (int i = 0; i < gx1.Length; i++)
            {
                array[i] = Int64.Parse(gx1[i].ToString());
            }
            Array.Sort(array);
            for (int j = 0; j < gx1.Length; j++)
            {
                gx2 = gx2 + array[j].ToString();
            }
            gx1 = gx2;
            return gx2;
        }
        public static string DscendingCheck(string gx1)
        {
            Int64[] array = new Int64[gx1.Length];
            string gx2 = "";
            for (int i = 0; i < gx1.Length; i++)
            {
                array[i] = Int64.Parse(gx1[i].ToString());
            }
            Array.Sort(array);
            Array.Reverse(array);
            for (int j = 0; j < gx1.Length; j++)
            {
                gx2 = gx2 + array[j].ToString();
            }
            gx1 = gx2;
            return gx2;
        }
    }
}
