using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Sudoku sd = new Sudoku("input1.txt");
            //  sd.SudukoIsValid();
            Console.WriteLine(sd.FindFirstElementofSubGrid(3,5));
        }
    }
}
