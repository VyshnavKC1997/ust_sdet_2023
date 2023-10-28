using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FileOperation
    {
        public void CreateFile()
        {
            FileInfo fileInfo= new FileInfo("C:\\Users\\Administrator\\Documents\\vy\\sample.txt");
            using StreamWriter str=fileInfo.CreateText();
            str.WriteLine("hello");
            str.WriteLine("hai");
        }
        public void WriteData()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Documents\\vy\\sample3.txt", FileMode.Create
                , FileAccess.Write);
            StreamWriter streamWriter=new StreamWriter(fileStream);
            Console.WriteLine("what you want to write");
            string? str=Console.ReadLine();
            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Documents\\vy\\sample3.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str=sr.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void CopyMoveFile()
        {
            FileInfo fileInfo = new FileInfo("C:\\Users\\Administrator\\Documents\\vy\\sample.txt");
            FileInfo fileInfo1 = new FileInfo("C:\\Users\\Administrator\\Documents\\vy\\sample3.txt");
            fileInfo.CopyTo("C:\\Users\\Administrator\\Documents\\vy\\temp\\gokul.txt");
            fileInfo1.MoveTo("C:\\Users\\Administrator\\Documents\\vy\\temp\\gokul2.txt");
        }
        public void FileProperties()
        {
            FileInfo file = new FileInfo("C:\\Users\\Administrator\\Documents\\vy\\temp\\gokul2.txt");
            Console.WriteLine(file.FullName);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.LinkTarget);
            Console.WriteLine(file.DirectoryName);
            Console.WriteLine(file.LastWriteTime);
            Console.WriteLine(file.Exists);

        }
    }
}
