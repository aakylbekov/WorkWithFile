using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("FileT.txt");
            FileStream fs = fi.Create();
            fs.Close();


            string path = Path.Combine(fi.DirectoryName, fi.Name);

            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    GetInfoFromUser(sw);
            //}
            AppendFile(fi);


        }

        static void M1(FileInfo fi)
        {
            if (!fi.Exists)
            {
                using (FileStream fs = fi.Create())
                {
                    Console.WriteLine("File created");
                }
            }
        }

        static void GetInfoFromUser(StreamWriter sw)
        {
            Console.WriteLine("Name: ");
            sw.WriteLine(Console.ReadLine());
            Console.WriteLine("Age: ");
            sw.WriteLine(Console.ReadLine());
            Console.WriteLine("id: ");
            sw.WriteLine(Console.ReadLine());
        }
        static void AppendFile(FileInfo fi)
        {
            if (fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    GetInfoFromUser(sw);
                }
            }
        }
    //    static void ReadFile(FileInfo fi)
    //    {
    //        string path = Path.Combine(fi.DirectoryName, fi.Name);
    //        if (fi.Exists)
    //        {
    //            using (StreamWriter sr = new StreamWriter(path)
    //            { Console.WriteLine();
    //        }
                     
        
    //    }
    //}



}
}
