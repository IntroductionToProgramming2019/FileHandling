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


namespace all_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string ln;
            FileStream songLyrics = new FileStream(@"E:\sonk\lyrics.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(songLyrics);
            do
            {
                ln = sr.ReadLine();
                Console.WriteLine(ln);

            } while (ln != null);
            sr.Close();
        }
    }
}
