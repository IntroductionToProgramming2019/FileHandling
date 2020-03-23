/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : complete streamreading and writing guide
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_First_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream songLyrics = new FileStream(@"E:\sonk\lyrics.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(songLyrics);
            string ln = sr.ReadLine();
            Console.WriteLine(ln);
            sr.Close();
        }
    }
}
