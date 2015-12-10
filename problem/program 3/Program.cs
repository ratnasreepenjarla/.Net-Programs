
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hydera";
            Console.WriteLine(s1.GetHashCode());
            s1 = s1 + "bad";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s1);
            StringBuilder s2 = new StringBuilder("hydera");
            Console.WriteLine(s2.GetHashCode());
            s2.Append("bad");
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s2);
           
        }
    }
}
