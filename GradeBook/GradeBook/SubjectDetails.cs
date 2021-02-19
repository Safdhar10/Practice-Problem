using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    public class Subject_Mark
    {
        public double Marks { get; set; }
        public string Grade { get; set; }
    }
    public class SubjectDetails
    {
        public  SortedList<string, Subject_Mark> Subjects { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public double Total { get; set; }
        public double Average { get; set; }
        public Subject_Mark Highest { get; set; }
        public Subject_Mark Lowest { get; set; }
        public string Low_Sub { get; set; }
        public string Hig_sub { get; set; }
    }

}
