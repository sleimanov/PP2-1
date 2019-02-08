using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool Check(string s)
        {
            string rev = new string(s.ToCharArray().Reverse().ToArray());
            if (rev == s) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\PP2\Week2\Task1\input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            if (Check(s) == true) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
    }
}
