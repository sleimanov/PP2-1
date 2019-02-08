using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool Check(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\PP2\Week2\Task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream fswrite = new FileStream(@"D:\PP2\Week2\Task2\output.txt", FileMode.Open, FileAccess.Write);
            StreamWriter srwrite = new StreamWriter(fswrite);
            string org = sr.ReadLine();
            string[] res = org.Split() ;
            int n;
            string res1 = "";
            for (int i = 0; i < res.Length; i++)
            {
                n = int.Parse(res[i]);
                if (Check(n) == true)
                {
                    res1 += n;
                    res1 += " ";

                }
            }
            srwrite.Write(res1);
            sr.Close();
            fs.Close();
            srwrite.Close();
            fswrite.Close();

        }
    }
}
