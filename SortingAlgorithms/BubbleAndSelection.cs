using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = { 64,25,12,22,11 };
            SelectionSorting(sampleArray);
            Console.WriteLine();
            BubbleSort(sampleArray);
            Console.WriteLine();
        }
        public static void SelectionSorting(int[] a)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
            foreach(var v in a)
            {
                Console.Write(v + " ");
            }
        }
        public static void BubbleSort(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a.Length-1;j++)
                {
                    if(a[j]<a[j+1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            foreach(var v in a)
            {
                Console.Write(v + " ");
            }
        }
    }
}
