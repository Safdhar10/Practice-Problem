using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            //When Array is Empty
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            al.Print();
            Console.WriteLine("--------------------");
            //Adding value using Add method
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Using Add Method");
            al.Add(2);
            al.Add(10);
            al.Add(5);
            al.Add(76);
            Console.WriteLine();
            al.Print();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            //Get Value By using get method
            Console.WriteLine("Get Value of Index 2");
            Console.WriteLine();
            Console.WriteLine(al.Get(2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");

            //trying to get outside of array list
            Console.WriteLine("Trying to get value which is not exist");
            Console.WriteLine();
            Console.WriteLine(al.Get(-1));
            Console.WriteLine(al.Get(4));//-1 is error message
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            //set value in existing array list values
            Console.WriteLine("Set value 39 to Index 2");
            Console.WriteLine();
            al.Set(2, 39);
            al.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            //try to set value which is not existing in array list
            Console.WriteLine("Trying to set which is not exist");
            Console.WriteLine();
            al.Set(6, 35);
            al.Set(-2, 88);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            //insert value
            Console.WriteLine("Insert value 25 in Index 1");
            Console.WriteLine();
            al.Insert(1, 25);
            al.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine("Try to insert value outside of the arraylist");
            Console.WriteLine();
            al.Insert(7, 99);
            al.Insert(-1, 108);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            Console.WriteLine("Delete Value of Index 2");
            al.Delete(2);
            Console.WriteLine();
            al.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine("Trying To delete Which is not Existing");
            Console.WriteLine();
            al.Delete(-2);
            al.Delete(8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            Console.WriteLine("Checking value Contains or Not");
            Console.WriteLine();
            Console.WriteLine(al.Contains(39));
            Console.WriteLine(al.Contains(89));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
        }
    }
}
