using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentFileHandling1
{
    class DirectoryClass
    {
        public string RootDirectory(string directoryPath)
        {
            DriveInfo driveInfo = new DriveInfo(directoryPath);
            return driveInfo.RootDirectory.ToString();
        }

        public List<string> AssignmentDirectoryAttributes(string directoryPath)
        {
            DirectoryInfo dirctoryInfo = new DirectoryInfo(directoryPath);
            List<string> directoryAttributes = new List<string>();
            directoryAttributes.Add("Full Name : " + dirctoryInfo.FullName);
            directoryAttributes.Add("Creation Time : " + dirctoryInfo.CreationTime);
            directoryAttributes.Add("Last Access Time : " + dirctoryInfo.LastAccessTime);
            return directoryAttributes;
        }

        public IEnumerable<FileInfo> AssignmentDirectoryFiles(string directoryPath)
        {
            DirectoryInfo directoryFiles = new DirectoryInfo(directoryPath);
            return directoryFiles.EnumerateFiles();
        }

        public List<string> RootDirectoryAttributes(string rootDirectory)
        {
            DriveInfo driveInfo = new DriveInfo(rootDirectory);
            List<string> rootAttributes = new List<string>();
            rootAttributes.Add("Name :" + driveInfo.Name);
            rootAttributes.Add("Drive Format :" + driveInfo.DriveFormat);
            rootAttributes.Add("Drive Type :" + driveInfo.DriveType.ToString());
            rootAttributes.Add("Drive Space in bytes :" + driveInfo.TotalSize.ToString());
            rootAttributes.Add("Drive Free Space in bytes :" + driveInfo.TotalFreeSpace.ToString());
            return rootAttributes;
        }

        public void DisplayFileAttributes(string filePath)
        {
            try
            {
                FileInfo fileAtttributes = new FileInfo(filePath);
                Console.WriteLine("The Attributes of the file are : ");
                Console.WriteLine("File is located in the directory: " + fileAtttributes.Directory.ToString());
                Console.WriteLine("File was created on : " + File.GetCreationTime(filePath));
                Console.WriteLine("File Was Last Accessed on : " + File.GetLastAccessTime(filePath));
                Console.WriteLine("The Size of file in bytes is : " + fileAtttributes.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
