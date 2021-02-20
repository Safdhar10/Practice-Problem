using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardToRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            bool check = true;

            for(int k=0;k<S.Length;k++)
            {
                if(k%2!=0)
                {
                   if(S[k]>'A'||S[k]<'Z')
                    {
                        check = false;
                        Console.WriteLine("No");
                        return;

                    }
                }
                else
                {
                    if(S[k]>'a' || S[k] < 'z')
                    {
                        check = false;
                        Console.WriteLine("No");
                        return;
                    }
                }
            }
            Console.WriteLine("Yes");
            //if(S.Length==1)
            //{
            //    if(char.IsLower(S[0]))
            //    {
            //        Console.WriteLine("Yes");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //        return;
            //    }
            //}
            //int i = 0;
            //int j = 1;
            //while (i<S.Length & j<S.Length)
            //{
            //   if(!( char.IsLower(S[i]) & char.IsUpper(S[j])))
            //    {
            //        Console.WriteLine("No");
            //        return;
            //    }
            //    i = i + 2;
            //    j = j + 2;
            //}
            //Console.WriteLine("Yes");
        }
    }
}
