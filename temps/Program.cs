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

namespace temps
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream temps = new FileStream(@"E:\sonk\temps.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(temps);
            sw.WriteLine("23/11/2013,8");
            sw.WriteLine("24/11/2013,6");
            sw.WriteLine("25/11/2013,2");
            sw.WriteLine("26/11/2013,5");
            sw.WriteLine("27/11/2013,12");
            sw.Close();
        }
    }
}
