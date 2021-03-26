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
        public void AllGrid()
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
                }
            }
        }
        private void PrintSubGrid(int row,int column)
        {
            for(int i=row;i<row+3;i++)
            {
                Console.Write("|" + SudokuBoard[i, 0] + " " + SudokuBoard[i, 1] + " " + SudokuBoard[i, 2] + "|" + "\t");
                Console.WriteLine();
            }
        }
        public string FindFirstElementofSubGrid(int row,int column)
        {
            int _choice = GridNumber(row, column);
            if(_choice==1)
            {
                return "0,0";
            }
            else if (_choice == 2)
            {
                return "0, 3";
            }
            else if (_choice == 3)
            {
                return"0, 6";
            }
            else if (_choice == 4)
            {
                return "3, 0";
            }
            else if (_choice == 5)
            {
                return"3, 3";
            }
            else if (_choice == 6)
            {
                return "3, 6";
            }
            else if (_choice == 7)
            {
                return "6, 0";
            }
            else if (_choice == 8)
            {
                return "6, 3";
            }
            else
            {
                return "6, 6";
            }
        }
        public void Subgrid(int row,int column)
        {
            int _choice = GridNumber(row, column);
            if (_choice == 1)
            {
                PrintSubGrid(0, 0);
            }
            else if (_choice == 2)
            {
                PrintSubGrid(0, 3);
            }
            else if (_choice == 3)
            {
                PrintSubGrid(0, 6);
            }
            else if (_choice == 4)
            {
                PrintSubGrid(3, 0);
            }
            else if (_choice == 5)
            {
                PrintSubGrid(3, 3);
            }
            else if (_choice == 6)
            {
                PrintSubGrid(3, 6);
            }
            else if (_choice == 7)
            {
                PrintSubGrid(6, 0);
            }
            else if (_choice == 8)
            {
                PrintSubGrid(6, 3);
            }
            else if (_choice == 9)
            {
                PrintSubGrid(6, 6);
            }
        }
        private int GridNumber(int i,int j)
        {
            if((i >= 0 && i <= 2) && (j >= 0 && j <= 2))
            {
                return 1;
            }
            else if((i >= 0 && i <= 2) && (j >= 3 && j <= 5))
            {
                return 2;
            }
            else if((i >= 0 && i <= 2) && (j >= 6 && j <= 8))
            {
                return 3;
            }
            else if((i >= 3 && i <= 5) && (j >= 0 && j <= 2))
            {
                return 4;
            }
            else if((i >= 3 && i <= 5) && (j >= 3 && j <= 5))
            {
                return 5;
            }
            else if((i >= 3 && i <= 5) && (j >= 6 && j <= 8))
            {
                return 6;
            }
            else if ((i >= 6 && i <= 8) && (j >= 0 && j <= 2))
            {
                return 7;
            }
            else if ((i >= 6 && i <= 8) && (j >= 3 && j <= 5))
            {
                return 8;
            }
            else if ((i >= 6 && i <= 8) && (j >= 6 && j <= 8))
            {
                return 9;
            }
            else
            {
                return 0;
            }

        }

    }
}
