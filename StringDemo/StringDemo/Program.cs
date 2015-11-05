using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
       public static void Main(string[] args)
        {
            String s1 = "  jayadurga  ";
            String s2 = "ratnasree";
            String s3 = String.Concat(s1, s2);
            Console.WriteLine(s1.Contains('r'));
            Console.WriteLine("uppercase is"+s2.ToUpper());
         
           //;
            Console.WriteLine(s1);
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s1.Substring(3));
            Console.WriteLine("remove " +s2.Remove(4)) ; 
            string s4 = string.Copy(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s3);
            int j = 0,k=0;
            String[] Array = { "ratna", "appu", "mouni" };
           
            String s5 = String.Join("*", Array);
            Console.WriteLine(s5);
            int i=Array.Length;
            Console.WriteLine("number of words in array " +i);
            
            //foreach(String s in Array)
            //{
            //char[] Chararray = s.ToCharArray();
            //    {
            //j += Chararray.Length;
            //    }
            //   //j += s.Length; 
            //}
            for (j = 0; j <i;j++)
            {
                k += Array[j].Length;
            }

            Console.WriteLine("number of characters are" + k);

            string s45 = "Ad,bd,cd,dd,ed,fd,gdd";
            string[] array=s45.Split(',');

            for (int l = 0; l < array.Length; l++)
           {
               Console.WriteLine(array[l]);
           }
            Console.WriteLine(s3.Replace('a','r'));


        }
    }
}
