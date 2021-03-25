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
            int[] a1 = new int[] { 1, -2, -3, 5, -6, -8, 0, int.MinValue, 240, 50 };
            int[] a2 = new int[] { 0, 1, 240, 50 };
            int[] a3 = new int[] { int.MinValue, -4, -214748 };
            int[] a4 = new int[] { -1, -2, int.MaxValue };
            int[] a5 = new int[] { 1, 2, int.MinValue };
            Console.WriteLine(largestNegative(a1));
            Console.WriteLine(largestNegative(a2));
            Console.WriteLine(largestNegative(a3));
            Console.WriteLine(largestNegative(a4));
            Console.WriteLine(largestNegative(a5));

        }
        public static int largestNegative(int[] array)
        {
            int min = int.MinValue;
            bool check = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    check = true;
                    if (array[i] > min)
                    {
                        min = array[i];
                    }
                }
            }
            return check ? min : -1;
        }
    }
}
