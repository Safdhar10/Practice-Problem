using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackConsoleApp;

namespace StackConsoleApp
{
    class Waiter
    {
        public Waiter()
        {
            int[] _line1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = _line1[0];
            int q = _line1[1];
            int[] _line2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> MainStack = new Stack<int>(n);
            for (int i = 0; i <n; i++)
            {
                MainStack.Push(_line2[i]);
            }
            int[] _primeNumber = FirstNPrimeNumber(q);
            StringBuilder sb = new StringBuilder();
            for (int i=0;i<q;i++)
            {
                Stack<int> A = new Stack<int>(n);
                Stack<int> B = new Stack<int>(n);
                while (MainStack.Count>0)
                {
                    if(MainStack.Peek()%_primeNumber[i]==0)
                    {
                        B.Push(MainStack.Pop());
                    }
                    else
                    {
                        A.Push(MainStack.Pop());
                    }
                }
                sb.Append(B.ToString());
                MainStack = A;
            }
            sb.Append(MainStack.ToString());
            Console.WriteLine(sb.ToString());
        }
        public static int[] FirstNPrimeNumber(int n)
        {
            int[] result = new int[n];
            int index = 0;
            result[index++] = 2;
            int i = 3;
            while (index<n)
            {
                if (PrimeOrNot(i))
                {
                    result[index] = i;
                    index++;
                }
                i = i + 2;
            }
            return result;

        }
        public static bool PrimeOrNot(int n)
        {
            bool check = true;
            if (n < 2)
            {
                check = false;
                return check;
            }
            //using root n method
            for (int j = 2; j * j <= n; j++)
            {
                if (n % j == 0)
                {
                    check = false;
                    return check;
                }
            }
            return check;
        }
    }
}
