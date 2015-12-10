using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringeg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0,i=0;
            String s1 = "somexsoftwaresolutions";
            //char[] chararray = s1.ToCharArray();
            char c=s1[i];
            for( i=0;i<s1.Length-1;i++)
            //{
            //    for(int j=0;j<=chararray.Length-1;j++)
            //    {
                if (s1[i] == c)
                    {
                        count++;
                       
                    }
                  
                //continue;
                //}
                Console.WriteLine("Repeated char"+s1[i]+"count is "+count);
            }
        }
    }
//}
