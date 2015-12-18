using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "aaaabbbbcccc    COMMUNICATION";
            var array = input.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            int miditemindex = array.Length / 2;
            Console.WriteLine(array[miditemindex - 1]);
            Console.ReadLine();
            int[] alphabets = new int[26];
            var replaced = input.Replace(" ", "");
            var array1 = replaced.ToLower().ToCharArray();
            for (int i = 0; i < array1.Length; i++)
            {
                alphabets[array[i] - 97] = alphabets[array[i] - 97] + 1;
            }

            for (int i = 0; i < alphabets.Length; i++)
            {
                if (alphabets[i] > 0)
                {
                    Console.WriteLine((char)(97 + i) + "    " + alphabets[i]);
                }
            }
        }
    }
}
