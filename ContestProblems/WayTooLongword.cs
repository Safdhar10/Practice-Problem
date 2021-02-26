using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayTooLongWord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Word_add = new List<string>();
            int total_word = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < total_word; i++)
            {
                string word = Console.ReadLine();
                Word_add.Add(word);


            }
            foreach (var s in Word_add)
            {
                int length = s.Length-2;
                if (s.Length > 10)
                {
                    Console.WriteLine(s[0].ToString() + length + s[length+1].ToString());
                }
                else
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
