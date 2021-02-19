using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFromtheLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder s=new StringBuilder(2000000);
            //s.Append(Console.ReadLine());
            //StringBuilder t = new StringBuilder(2000000);
            //t.Append(Console.ReadLine());
            //Console.WriteLine(s.Length);
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int length = 0;
            int j = 0;
            if (t.Length<s.Length)
            {
                length = t.Length;
                j = s.Length;
            }
            else 
            {
                length = s.Length;
                j = t.Length;
            }
            int count = length+j;
            while (length > 0)
            {
                length = length - 1;
                j = j - 1;
                count = count - 2;
                if (s.Length>t.Length)
                {
                    if(t[length]!=s[j])
                    {
                        count = count +2;
                        break;
                    }
                }
                else
                {
                    if(s[length]!=t[j])
                    {
                        count = count +2;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
            //int check = 0;
            //for (int i = 0; i < length; i++)
            //{
            //    if (s == t)
            //    {
            //        break;
            //    }
            //    if (s.Length==t.Length)
            //    {
            //        check = check + 2;
            //        s = s.Remove(0, 1);
            //        t = t.Remove(0, 1);
            //    }
            //    else if(s.Length>t.Length)
            //    {
            //        check = check + 1;
            //        s = s.Remove(0, 1);
            //    }
            //    else
            //    {
            //        check = check + 1;
            //        t = t.Remove(0, 1);
            //    }
            //}
            //Console.WriteLine(check);
        }
    }
}
