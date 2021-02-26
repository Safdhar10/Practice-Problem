using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Very_Very_Preemeptive_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] get = Console.ReadLine().Split();
            int Takahashi = int.Parse(get[0]);
            int Aoki = int.Parse(get[1]);
            int Who_First = int.Parse(get[2]);
            if (Who_First == 0)
            {
                if (Takahashi > Aoki)
                {
                    Console.WriteLine("Takahashi");
                }
                else
                {
                    Console.WriteLine("Aoki");
                }
            }
            else if(Who_First==1)
            {
                if (Aoki > Takahashi)
                {
                    Console.WriteLine("Aoki");
                }
                else
                {
                    Console.WriteLine("Takahashi");
                }
            }
        }
    }
}
