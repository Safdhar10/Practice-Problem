using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StackConsoleApp
{
    class SimpleEditor
    {
        StringBuilder sb = new StringBuilder();
        int _previousChoice;
        int _previousK;
        Stack<char> st = new Stack<char>();
        Stack<char> undo = new Stack<char>();
        StreamReader setin =new StreamReader( @"C:\Users\Saffu\Desktop\inputSimpleEditor.txt");
        StreamWriter setout =new StreamWriter( @"C:\Users\Saffu\Desktop\outputSimpleEditor.txt");
        public SimpleEditor()
        {
            int N = Convert.ToInt32(setin.ReadLine());
            for(int i=0;i<N;i++)
            {
                string[] _line = setin.ReadLine().Split();
                if (int.Parse(_line[0])==1)
                {
                    for(int j=0;j<_line[1].Length;j++)
                    {
                        st.Push(_line[1][j]);
                    }
                    undo.Push((char)_line[1].Length);
                    undo.Push('1');
                }
                else if (int.Parse(_line[0]) == 2)
                {
                    int _length = int.Parse(_line[1]);
                   for (int j=0;j<_length;j++)
                    {
                        undo.Push(st.Pop());
                    }
                    undo.Push((char)_length);
                    undo.Push('2');
                }
                else if (int.Parse(_line[0]) == 3)
                {
                    int _noOfLoop = st.Count - int.Parse(_line[1]);
                    for (int j =0 ; j <_noOfLoop ; j++)
                    {
                        undo.Push(st.Pop());
                    }
                    setout.WriteLine(st.Peek());
                    for (int j = 0; j < _noOfLoop; j++)
                    {
                        st.Push(undo.Pop());
                    }
                }
                else
                {

                    if(undo.Peek()=='1')
                    {
                        undo.Pop();
                        int _endRange = (int)undo.Pop();
                       for(int j=1;j<=_endRange ; j++)
                        {
                            st.Pop();
                        }
                    }
                    else if(undo.Peek()=='2')
                    {
                        undo.Pop();
                        int _endRange = (int)undo.Pop();
                        for (int j=1;j<=_endRange;j++)
                        {
                            char _put = undo.Pop();
                            st.Push(_put);
                        }
                    }
                }
        }
            setout.Flush();
            setout.Close();
            setin.Close();
        }
    }
}
