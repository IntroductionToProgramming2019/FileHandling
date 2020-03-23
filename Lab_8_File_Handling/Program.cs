using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream songLrics = new FileStream(@"E:\sonk\lyrics.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(songLrics);
            sw.WriteLine("The anniversaries are short lived");
            sw.WriteLine("But they come back around at a breakneck speed");
            sw.WriteLine("My world spins so fast");
            sw.WriteLine("The centrifugal force keep me stuck in the middle");
            sw.Close();
        }
    }
}
