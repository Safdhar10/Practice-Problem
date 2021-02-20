using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOPathOptions1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Path.Combine - Combines strings to form a path or combines two existing paths
            string drive = "C:\\";
            string directory = "Sample\\";
            string filename = "Input.txt";

            string path = Path.Combine(drive, directory, filename);
            Console.WriteLine(path);
            Console.WriteLine("Path Combine Successfull");

            //Change path extension
            path = Path.ChangeExtension(path, "bak");
            Console.WriteLine(path);
            Console.WriteLine("Change Extension Successfull");

            //Get Directory Name
            string dirName = Path.GetDirectoryName(path);
            Console.WriteLine(dirName);
            Console.WriteLine("Get Directory Name Successfull");

            //Get File Extension
            string ext = Path.GetExtension(path);
            Console.WriteLine(ext);
            Console.WriteLine("Get File Extension Successfull");

            //Get File Name
            string fileName = Path.GetFileName(path);
            Console.WriteLine(fileName);
            Console.WriteLine("Get File Name Successfull");

            //Get File Name Without Extension
            string fileNoExt = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine(fileNoExt);
            Console.WriteLine("Get File Name Without Extension Successfull");

            //Check if File has Extension
            bool hasExtension = Path.HasExtension(path);
            Console.WriteLine(hasExtension);
            Console.WriteLine("Check hasExtension Successfull");

            //Other methods
            Console.WriteLine("Invalid file name chars");
            char[] invalidchars = Path.GetInvalidFileNameChars();
            Console.WriteLine(invalidchars);

            Console.WriteLine("Random File Name");
            string randompath = Path.GetRandomFileName();
            Console.WriteLine(randompath);

            Console.WriteLine("Get Temporary Folder Path");
            string tempfolderpath = Path.GetTempPath();
            Console.WriteLine(tempfolderpath);

            //Create Subdir in temp folder
            Directory.CreateDirectory(tempfolderpath + "\\samplesubdir");
            bool checkdir = Directory.Exists(tempfolderpath + "\\samplesubdir");
            Console.WriteLine("Sub Directory in temp folder :" + checkdir);

            //Create a file in the new directory in temp folder
            File.WriteAllText(tempfolderpath + "\\samplesubdir" + "\\Output.txt", "Sample text from program");
            Console.WriteLine("Writing to File Successfull");

            //Get Temp File Name
            Console.WriteLine("Get Temporary File Name");
            string tempfilename = Path.GetTempFileName();
            Console.WriteLine(tempfilename);

            //Writing to temp file
            File.WriteAllText(tempfilename, "Sample text for Temp File");
            Console.WriteLine("Writing to Temp File Successfull");
        }
        

    }
}
