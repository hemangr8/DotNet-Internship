using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Security;

namespace AssignmentFileHandling1
{
    class Program
    {
        static void Main()
        {
            string assignmentDirectoryPath = @"C:\FileHandlingDirectory";
            string readFilePath = @"C:\FileHandlingDirectory\ReadFile.txt";
            string writeFilePath = @"C:\FileHandlingDirectory\WriteFile.txt";
            DirectoryClass directory = new DirectoryClass();
            string rootPath = directory.RootDirectory(assignmentDirectoryPath);
            Console.WriteLine("The root Directory of the directory FileHandlingDirectory is :      {0}", directory.RootDirectory(assignmentDirectoryPath));
            List<string> rootDirectoryAttributes = directory.RootDirectoryAttributes(rootPath);
            Console.WriteLine("");
            Console.WriteLine("The attribute of {0} directory are :", rootPath);
            Console.WriteLine("");
            int countRootAttributes = 1;
            foreach (string attribute in rootDirectoryAttributes)
            {
                Console.WriteLine("{0}. {1}", countRootAttributes, attribute);
                countRootAttributes++;
            }
            Console.WriteLine("");
            Console.WriteLine("The Attributes of the assignment directory i.e. ({0}) are : ", assignmentDirectoryPath);
            Console.WriteLine("");
            int count = 1;
            List<string> directoryAttributes = directory.AssignmentDirectoryAttributes(assignmentDirectoryPath);
            foreach (string attribute in directoryAttributes)
            {
                Console.WriteLine("{0}. {1}", count, attribute);
                count++;
            }
            int countFiles = 1;
            IEnumerable<FileInfo> fileNames = directory.AssignmentDirectoryFiles(assignmentDirectoryPath);
            Console.WriteLine("");
            Console.WriteLine("The Following are the files in the directory {0}", assignmentDirectoryPath);
            Console.WriteLine("");
            foreach (FileInfo name in fileNames)
            {
                string filePath = string.Concat(assignmentDirectoryPath, @"\", name.ToString());
                Console.WriteLine("");
                Console.WriteLine("{0}. {1}", countFiles, filePath);
                Console.WriteLine("{0}", name);
                if (name.ToString() == "ReadFile.txt")
                {
                    Console.WriteLine("");
                    File.SetAttributes(filePath, FileAttributes.ReadOnly);
                    Console.WriteLine("The file is set with read only access.");
                }
                Console.WriteLine("");
                directory.DisplayFileAttributes(filePath);
                Console.WriteLine("The Directory Path of the file : {0} using PathClass is :{1}", name, Path.GetDirectoryName(filePath));
                countFiles++;
            }
            Console.WriteLine("");
            Console.WriteLine("Press a Key to read contents of ReadFile.txt");
            Console.ReadKey();
            ClassReaderAndWriter readerWriter = new ClassReaderAndWriter();
            List<string> readFileData = readerWriter.FileRead(readFilePath);
            Console.WriteLine("The Contents of ReadFile.txt are:");
            foreach (string line in readFileData)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            Console.WriteLine("Press a key to append the contents of ReadFile.txt into WriteFile.txt");
            Console.ReadKey();
            readerWriter.WriteContents(writeFilePath, readFileData);
            Console.WriteLine("Press a key to read the contents of WriteFile.txt");
            Console.ReadKey();
            List<string> writeFileData = readerWriter.FileRead(writeFilePath);
            Console.WriteLine("The contents of WriteFile.txt are: ");
            foreach (string line in writeFileData)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            Console.WriteLine("Press a key to compress a the WriteFile.txt to FileWriteZip");
            Console.ReadKey();
            try
            {
                string tempFileData = File.ReadAllText(writeFilePath);
                Compresser compresser = new Compresser();
                compresser.CompressStringToFile(@"C:\FileHandlingDirectory\FileWriteZip.gz", tempFileData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
