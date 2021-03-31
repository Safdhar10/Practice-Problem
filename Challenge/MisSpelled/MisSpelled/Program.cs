using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MisSpelled
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchMovie(Console.ReadLine().ToUpper());
        }
        public static void SearchMovie(string input)
        {
            List<string> MovieNames = new List<string>();
            Dictionary<int,char> IndexWithChar = new Dictionary<int, char>();
            StreamReader setin = new StreamReader(@"C:\Users\Saffu\Documents\movie.txt");
            int count = File.ReadAllLines(@"C:\Users\Saffu\Documents/movie.txt").Count();
            while (count-- > 0)
            {
                MovieNames.Add(setin.ReadLine().ToUpper());
            }
            for(int i=0;i<MovieNames.Count;i++)
            {
                string _getmovie=MovieNames.ElementAt(i);
                IndexWithChar.Clear();
                if(_getmovie[0]==input[0])
                {
                    if(_getmovie.Length==input.Length)
                    {
                        IndexWithChar.Add(0, input[0]);
                        for(int j=1;j<_getmovie.Length;j++)
                        {
                            int _left = 1;
                            int _right = input.Length - 1;
                            while(_left<=_right)
                            {
                                if(_getmovie[j]==input[_left])
                                {
                                    if(!IndexWithChar.ContainsKey(_left))
                                    {
                                        IndexWithChar.Add(_left,input[_left]);
                                        break;
                                    }
                                    
                                }
                                if(_getmovie[j]==input[_right])
                                {
                                    if (!IndexWithChar.ContainsKey(_right))
                                    {
                                        IndexWithChar.Add(_right,input[_right]);
                                        break;
                                    }
                                }
                                _left++;
                                _right--;
                            }
                            //for(int k=1;k<input.Length;k++)
                            //{
                            //    if(_getmovie[j]==input[k])
                            //    {
                            //        if(!IndexCount.Contains(k))
                            //        {
                            //            IndexCount.Add(k);
                            //            break;
                            //        }
                            //    }
                            //}
                        }
                        if(_getmovie.Length==IndexWithChar.Count)
                        {
                            Console.WriteLine(_getmovie);
                            Console.WriteLine("You want to search more");
                            if(Console.ReadLine().ToUpper()=="YES")
                            {
                                SearchMovie(Console.ReadLine().ToUpper());
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("No Word is Found Please Enter Correct Spell");
            SearchMovie(Console.ReadLine().ToUpper());

        }
    }
}
