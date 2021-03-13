using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] workA = new int[N];
            int[] workB = new int[N];
            for(int i=0;i<N;i++)
            {
                int[] get = Console.ReadLine().Split().Select(int.Parse).ToArray();
                workA[i] =Convert.ToInt32( get[0]);
                workB[i] =Convert.ToInt32( get[1]);
            }
            int WorkASmallest = KthSmallestElement(workA, 1, N);
            int WorkAIndex = Array.IndexOf(workA, WorkASmallest);
            int FirstWorkBSmallest = KthSmallestElement(workB, 1, N);
            int First = Array.IndexOf(workB, FirstWorkBSmallest);
            int SecondWorkBSmallest = KthSmallestElement(workB, 2, N);
            int Second = Array.IndexOf(workB, SecondWorkBSmallest);
            int checksum = int.MaxValue;
            int S1 = Math.Max(WorkASmallest, FirstWorkBSmallest);
            int S2 = Math.Max(WorkASmallest, SecondWorkBSmallest);
            if (WorkAIndex==First)
            {
                checksum = WorkASmallest + FirstWorkBSmallest;
                Console.WriteLine(Math.Min(S2, checksum));
                return;
            }
            
            if(WorkAIndex==Second)
            {
                checksum = int.MaxValue;
                checksum = WorkASmallest + SecondWorkBSmallest;
                Console.WriteLine(Math.Min(S1, checksum));
                return;
            }
            Console.WriteLine(S1);
        }
        public static int KthSmallestElement(int[] array, int k, int n)
        {
            int Small = int.MinValue;
            int index = 0;
            Dictionary<int, int> IndexDetails = new Dictionary<int, int>();
            for (int i = 0; i < k; i++)
            {
                int smallest = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (smallest > array[j] && Small <= array[j])
                    {
                        if (!IndexDetails.ContainsKey(j))
                        {
                            smallest = array[j];
                            index = j;
                        }
                    }
                }
                IndexDetails.Add(index, array[index]);
                Small = smallest;
            }
            return Small;
        }
    }
}
