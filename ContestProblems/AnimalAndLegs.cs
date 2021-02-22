using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEB16_10A_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int Animals = line1[0];
            int Total_Legs = line1[1];

            //int Remaining = Total_Legs % 2;

            //int Crane = Animals * 2;
            //int Turtle = Animals * 4;

            //if(Remaining==0 & Crane<=Total_Legs)
            //{
            //    if(Turtle>=Total_Legs)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            //int crane = Animals;
            //int turtle = 0;
            //for(int i=0;i<=Animals;i++)
            //{
            //    if(((crane * 2) +(turtle * 4))==Total_Legs)
            //    {
            //        Console.WriteLine("Yes");
            //        return;
            //    }
            //    crane--;
            //    turtle++;
            //}
            //Console.WriteLine("No");

            int crane = ((4*Animals)-Total_Legs)/2;
            int turtle = (Total_Legs-(2*Animals))/2;
            
            if((crane*2)+(turtle*4)==Total_Legs & crane>=0 & turtle >=0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
