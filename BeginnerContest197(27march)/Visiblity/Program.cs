using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int W = input[1];
            int x = input[2];
            int y = input[3];
            int count = 0;
            int count2 = 0;
            for(int i=0;i<N;i++)
            {
                string line= Console.ReadLine();
                if(i==x-1)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j]=='.')
                        {
                            count++;
                        }
                        else if(line[j]=='#' && count>0)
                        {
                            break;
                        }
                    }
                }
                if(i==x)
                {
                    for(int j=0;j<line.Length;j++)
                    {
                        if(line[j]=='.')
                        {
                            count2++;
                        }
                        else if(count2>0 && line[j]=='#')
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(count+count2);
        }
    }
}
