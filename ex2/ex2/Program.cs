using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
                   //using for loop

            //    String s1 = "ratna";
            //    String s2 = "";
            //    for(int i=s1.Length-1;i>=0;i--)
            //    {
            //        s2 = s2 + s1[i];
            //    }
            //    Console.WriteLine("reverse of string is"+s2);

                    //using tocharray

            //Console.WriteLine("enter string");
            //String s1 = Console.ReadLine();
            //char[] carray = s1.ToCharArray();
            //char[] ch = new char[10];
            //int l = carray.Length - 1;
            //for (int i = l; i >= 0; i--)
            //{
            //    ch[l - i] = carray[i];
            //    //s = s + carray[i];
            //}

            //Console.WriteLine(ch);

                      //using array and swapping 

            String s1 = Console.ReadLine();
            char[] carray = s1.ToCharArray();
            int i=0, j,l;
            l = carray.Length;
            j = l - 1;
            char temp;
            while(i<j)
            {
                temp = carray[i];
                carray[i] = carray[j];
                carray[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine(carray);



        }
    }
}
