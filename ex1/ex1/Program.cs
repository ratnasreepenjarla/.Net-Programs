using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter number to generate table");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Ratnge");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("multiplication table is");
            for(int i=1;i<=r;i++)
            {
                Console.WriteLine(n+"*"+i+"="+(n*i));
            }

        }
    }
}
