using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsAndTravelCost
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<long, long> VillageAndMoney = new SortedList<long, long>();
            VillageAndMoney.Add(0, 0);

            long[] _line1 = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long TotalFriendHeHave = _line1[0];
            long TotalYenHeHave = _line1[1];

            long[] A = new long[TotalFriendHeHave + 1];
            long[] B = new long[TotalFriendHeHave + 1];

            for (int i = 1; i <= TotalFriendHeHave; i++)
            {
                long[] _friendandMoney = Console.ReadLine().Split().Select(long.Parse).ToArray();

                A[i] = _friendandMoney[0];
                B[i] = _friendandMoney[1];

            }
            Array.Sort(A, B);

            long TotalVillageHeGoes = 0;

            for(int i=1;i<=TotalFriendHeHave;i++)
            {
                if(TotalYenHeHave>=(A[i]-A[i-1]))
                {
                    TotalVillageHeGoes += (A[i] - A[i - 1]);
                    TotalYenHeHave = TotalYenHeHave - (A[i] - A[i - 1]) + B[i];
                }
                else
                {
                    TotalVillageHeGoes += TotalYenHeHave;
                    Console.WriteLine(TotalVillageHeGoes);
                    return;
                }
            }
            Console.WriteLine(TotalVillageHeGoes + TotalYenHeHave); ;

            //string[] input = Console.ReadLine().Split(' ');
            //long n = long.Parse(input[0]);
            //long k = long.Parse(input[1]);

            //long[] a = new long[n + 1];
            //long[] b = new long[n + 1];


            //for (int i = 1; i < n + 1; i++)
            //{
            //    string[] inaa = Console.ReadLine().Split(' ');
            //    a[i] = long.Parse(inaa[0]);
            //    b[i] = long.Parse(inaa[1]);
            //}

            //Array.Sort(a, b);


            //long m = 0;

            //for (long j = 0; j < n; j++)
            //{
            //    if (k >= a[j + 1] - a[j])
            //    {
            //        m += a[j + 1] - a[j];
            //        k = k - a[j + 1] + a[j] + b[j + 1];
            //    }
            //    else
            //    {
            //        m += k;
            //        break;
            //    }

            //    if (j == n - 1)
            //    {
            //        m += k;
            //        break;
            //    }
            //}

            //Console.WriteLine(m.ToString());



        }
    }
}
