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

namespace temps2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ln;
            int temps;
            int average;
            int total = 0;
            int times = 0;
            Console.WriteLine("Temperature Report");
            Console.WriteLine("{0,-20}{1,-10}","Date","Temperature");
            FileStream temps2 = new FileStream(@"E:\sonk\temps.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(temps2);

            ln = sr.ReadLine(); // get first line

            while (ln != null)
            {
                string[] parts = ln.Split(',');
                string date = parts[0];
                temps = int.Parse(parts[1]);
                Console.WriteLine("{0,-20}{1,-10}", date, temps);
                for (int i = 0; ln != null ; i++)
                {
                    total = total + temps;
                    times = i;
                }
                average = total / times;
                Console.WriteLine(average);
                ln = sr.ReadLine(); // get first line
            }
            sr.Close();
        }
    }
}
