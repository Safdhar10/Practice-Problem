using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    public class Sudoku
    {
        StreamReader setin;
        int[,] SudokuBoard = new int[9, 9];
        int[] Digit = new int[10];
        public Sudoku(string path)
        {
            setin =new StreamReader( @"C:\Users\Saffu\Desktop\sudoku\" + path);
            for (int j = 0; j < 9; j++)
            {
                int[] sample = setin.ReadLine().Split().Select(int.Parse).ToArray();
                for (int i = 0; i < sample.Length; i++)
                {
                    SudokuBoard[j, i] = sample[i];
                }
            }
        }
        private bool CheckRowisValid()
        {
            for(int i=0;i<9;i++)
            {
                Digit = new int[10];
                for (int j=0;j<9;j++)
                {
                    if(!Digit.Contains(SudokuBoard[i,j]))
                    {
                       Digit[j]=SudokuBoard[i, j];
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool CheckColumnisValid()
        {
            for(int i=0;i<9;i++)
            {
                Digit = new int[10];
                for (int j=0;j<9;j++)
                {
                    if(!Digit.Contains(SudokuBoard[j,i]))
                    {
                        Digit[j]=SudokuBoard[j,i];
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void SudukoIsValid()
        {
            if(CheckRowisValid() && CheckColumnisValid())
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("NoT Correct");
            }
        }

        public void PringGrid()
        {
            int count = 0;
            Console.WriteLine(" " + "------" + " " + "-------" + " " + "------" + " " + "\t");
            for (int i=0;i<9;i++)
            {
                count++;
                for (int j=0;j<9;j+=3)
                {
                    Console.Write("|"+SudokuBoard[i, j + 0] + " " + SudokuBoard[i, j + 1] + " " + SudokuBoard[i, j + 2] +"|"+ "\t");
                }
                Console.WriteLine();
                if(count==3)
                {
                    Console.WriteLine(" " + "------" + " " + "-------" + " " + "------" + " " + "\t");
                    Console.WriteLine();
                    count = 0;
                    Console.WriteLine(" " + "------" + " " + "-------" + " " + "------" + " " + "\t");
                }
            }
        }

    }
}
