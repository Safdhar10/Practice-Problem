using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line2 = { 150, 80, 100, 120, 80 };
            int N = 5;
            int K = 3;
            //Console.WriteLine("K Smallest Element in Array");
            //Console.WriteLine(KthSmallestElement(line2,K,N));
            Console.WriteLine("K Largest Element in Array");
            Console.WriteLine(KthLargestElement(line2, K, N));
        }
        public static int KthSmallestElement(int[] array,int k,int n)
        {
            int Small = int.MinValue;
            int index = 0;
            Dictionary<int, int> IndexDetails = new Dictionary<int, int>();
            for(int i=0;i<k;i++)
            {
                int smallest = int.MaxValue;
                for(int j=0;j<n;j++)
                {
                    if(smallest>array[j] && Small<=array[j])
                    {
                        if(!IndexDetails.ContainsKey(j))
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
        public static int KthLargestElement(int[] array, int k, int n)
        {
            int Large = int.MaxValue;
            int index = 0;
            Dictionary<int, int> IndexDetails = new Dictionary<int, int>();
            for (int i = 0; i < k; i++)
            {
                int largest = int.MinValue;
                for (int j = 0; j < n; j++)
                {
                    if (largest < array[j] && array[j] < Large)
                    {
                        if (!IndexDetails.ContainsKey(j))
                        {
                            largest = array[j];
                            index = j;
                        }
                    }
                }
                IndexDetails.Add(index, array[index]);
                Large = largest;
            }
            return Large;
        }
        
    }
}
