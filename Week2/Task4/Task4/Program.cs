﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\PP2\Week2\Task4\topicreate.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine("Pidr");
            sr.Close();
            fs.Close();
            File.Copy(@"D:\PP2\Week2\Task4\topicreate.txt", @"D:\PP2\Week2\Task4\Task4\topicreate.txt");
            
            File.Delete(@"D:\PP2\Week2\Task4\topicreate.txt");



        }
    }
}
