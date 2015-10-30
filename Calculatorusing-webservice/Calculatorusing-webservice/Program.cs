using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorusing_webservice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcutorusingwsdl.Calculator cal = new Calcutorusingwsdl.Calculator();
            Console.WriteLine("1.Add \n2.sub\n3.mul\n4.div");
            Console.WriteLine("enter choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine("addition is");
                        Console.WriteLine(cal.Add(1, 2));
                        break;
                case 2: Console.WriteLine("substraction is");
                        Console.WriteLine(cal.Subtract(3,1));
                         break;
                case 3: 
                        Console.WriteLine("multiplication is: {0}",cal.Multiply(2,3));
                         break;
                case 4: Console.WriteLine("multiplication is: {0}", cal.Divide(10, 2));
                         break;
                default: Console.WriteLine("enter correct choice");
                         break;
            }

            Console.Read();
        }
    }
}
