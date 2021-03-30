using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChoosingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] GameArray = GetRandomArray();
            List<int> Player1 = new List<int>();
            List<int> Player2 = new List<int>();
            foreach (var item in GameArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            GameAlgorithm(GameArray, Player1, Player2);
        }
        private static int[] GetRandomArray()
        {
            Random r = new Random();
            int _size = 10;
            int[] array = new int[_size];
            int _startRange = 5;
            int _endRange = 155;
            for (int i = 0; i < _size; i++)
            {
                array[i] = r.Next(_startRange, _endRange);
            }
            return array;
        }

        public static void GameAlgorithm(int[] array, List<int> player1, List<int> player2)
        {
            int i = 10;
            int P1S = 0;
            int P1L = array.Length - 1;
            int _count = 0;
            int sum1 = 0;
            int sum2 = 0;
            while (P1S<P1L)
            {
                sum1 += array[P1S];
                sum2 += array[P1L];
                P1S++;
                P1L--;
            }
            if(sum1>sum2)
            {
                while(P1S < P1L)
                {
                    player1.Add(array[P1S]);
                    player2.Add(array[P1L]);
                    P1S++;
                    P1L--;
                }
                Console.WriteLine("Player 1 Won"); 
                foreach (var item in player1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                foreach (var item in player2)
                {
                    Console.WriteLine(item);
                }
            }
            else if (sum1 > sum2)
            {
                while (P1S < P1L)
                {
                    player2.Add(array[P1S]);
                    player1.Add(array[P1L]);
                    P1S++;
                    P1L--;
                }
                Console.WriteLine("Player 1 Won");
                foreach (var item in player1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                foreach (var item in player2)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Draw");
            }
            
        }
        public static void Loading()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("..............");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Color(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void Message(string Message)
        {
            Console.WriteLine(Message);
        }
    }

}
