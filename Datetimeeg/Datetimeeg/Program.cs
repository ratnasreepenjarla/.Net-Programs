using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetimeeg
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            do
            {
                DateTime date = DateTime.Now;
                DateTime universal = DateTime.UtcNow;
                Console.WriteLine(universal);
                Console.WriteLine(date);
                Console.WriteLine(date.ToShortDateString());
                CultureInfo culture = new CultureInfo("zh-CN");
                Console.WriteLine(date.ToString(culture));

            } while (s.Elapsed.Seconds < 3);

        }
    }
}
