using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void print(FileSystemInfo fi, int z)
        {
            string s = new string(' ', z);
            s = s + fi.Name;
            Console.WriteLine(s);

            if (fi.GetType() == typeof(DirectoryInfo))
            {
                var v = (fi as DirectoryInfo).GetFileSystemInfos();
                foreach (var n in v)
                {
                    print(n, z + 3);
                }
            }

        }
        static void Main()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\PP2\Week2\Task3");
            print(di, 1);
        }
    }
}