using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GradeBook
{
    public class Program
    {
        public class student_details
        {
            public static void PrintMessage(String Message)
            {
                Console.WriteLine(Message);

            }
            public static int GetInt(String Message)
            {
                PrintMessage(Message);
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            public static double GetDouble(String Message)
            {
                PrintMessage(Message);
                double input = Convert.ToDouble(Console.ReadLine());
                return input;
            }
            public static string GetString(String Message)
            {
                PrintMessage(Message);
                string input = Console.ReadLine();
                return input;
            }
            public static string Grade(double mark)
            {
                if (mark >= 90)
                {
                    return "A Grade";
                }
                else if (mark >= 80)
                {
                    return "B Grade";
                }
                else if (mark >= 70)
                {
                    return "C Grade";
                }
                else if (mark >= 50)
                {
                    return "D Grade";
                }
                else
                {
                    return "F Grade";
                }
            }

            public static SubjectDetails Calculation()
            {
                SortedList<string, Subject_Mark> dummy = new SortedList<string, Subject_Mark>();
                SubjectDetails Subject = new SubjectDetails();
                Subject_Mark sm = new Subject_Mark();
                    Subject.Class = GetString("Enter Class Name");
                    Subject.StudentName = GetString("Enter The Name: ");
                    int n = GetInt("Enter No of Subject");
                    for (int i = 0; i < n; i++)
                    {
                        string Sub_Name = GetString("Enter Subject Name");
                        sm.Marks = GetDouble("Enter Mark");
                        sm.Grade = Grade(sm.Marks);
                        dummy.Add(Sub_Name, sm);
                        Subject.Subjects = dummy;
                        Subject.Total = Subject.Total + sm.Marks;

                    }
                    
                    Subject.Average = Subject.Total / n;
                    //Subject.Highest= Subject.Subjects.Values.Max();
                    //Subject.Lowest = Subject.Subjects.Values.Min();
                    //foreach (var v in Subject.Subjects)
                    //{
                    //    if (v.Value.Marks.Equals(Subject.Highest))
                    //    {
                    //        Subject.Hig_sub = v.Key;
                    //    }
                    //    if (v.Value.Marks.Equals(Subject.Lowest))
                    //    {
                    //        Subject.Low_Sub = v.Key;
                    //    }
                    //}
                    return Subject;
                
            }
            public static void Main(string[] args)
            {
                
                SubjectDetails sd = Calculation();
                PrintMessage(string.Format("Name\tClass\tSubject\tMark\tGrade"));
                foreach (var v in sd.Subjects)
                {
                    PrintMessage(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", sd.StudentName, sd.Class, v.Key, v.Value.Marks, v.Value.Grade));
                }
                PrintMessage(string.Format("Total : {0}", sd.Total));
                PrintMessage(string.Format("Average : {0}", sd.Average));
                PrintMessage(string.Format("Lowest Mark {0} in {1}", sd.Lowest, sd.Low_Sub));
                PrintMessage(string.Format("Highest Mark {0} in {1}", sd.Highest, sd.Hig_sub));
            }

        }

    }
}
