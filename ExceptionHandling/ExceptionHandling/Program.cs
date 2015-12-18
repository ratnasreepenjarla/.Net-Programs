using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            //if(y==0)
            //{
            //    throw new Exception("divide by zero Exception");
            //}
            try
            {
                int c = x / y;
            }
            //Console.WriteLine(c);
            catch(Exception ex)
            {
              
                //Console.WriteLine(ex.Message);
            }
        }
    }
}
