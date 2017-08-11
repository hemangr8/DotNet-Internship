using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentFileHandling1
{
    public class ClassReaderAndWriter
    {
        public List<string> FileRead(string filePath)
        {
            List<string> textData = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    do
                    {
                        textData.Add(reader.ReadLine());
                    } while (reader.Peek() != -1);
                    return textData;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return textData;
            }
        }
        public void WriteContents(string filePath, List<string> readFileData)
        {
            try
            {
                using (FileStream appendStream = new FileStream(filePath, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(appendStream))
                    {
                        foreach (string data in readFileData)
                        {
                            writer.WriteLine(data);
                        }
                    }
                }
                Console.WriteLine("Append Successfull");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
