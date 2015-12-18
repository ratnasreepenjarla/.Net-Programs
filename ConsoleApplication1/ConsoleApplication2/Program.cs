using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input1 = "aaaabbbbcccc";
            String input2 = "xyz";
            int index = 4;
            char[] result = new char[input1.Length + input2.Length];

            var input1Array = input1.ToCharArray();
            var input2Array = input2.ToCharArray();
            var counter = 0;

            for (int i = 0; i < input1Array.Length; i++)
            {
                if (index == i)
                {
                    for (int j = 0; j < input2Array.Length; j++)
                    {
                        result[counter] = input2Array[j];
                        counter++;
                    }
                }
                result[counter] = input1Array[i];
                counter++;
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            Console.Read();
        }
        }
    }
