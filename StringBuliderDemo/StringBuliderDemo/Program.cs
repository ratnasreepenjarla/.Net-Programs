using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookInfo info = new BookInfo();
            Console.WriteLine("enter book catageory");
            Console.WriteLine("0.mathmatics\n1.social\n2.english");
            int choice =int.Parse( Console.ReadLine());
            Catageory cat = (Catageory)choice;
            switch(cat)
            {
                case  Catageory.mathmatics:
                    info.id = 1;
                    info.name="MFCSE";
                
                    Console.WriteLine("book id is "+info.id);
                    Console.WriteLine(" book name is :"+info.name);
                        break;
                case Catageory.social:
                        info.id = 2;
                        info.name = "social";

                       Console.WriteLine("book id is "+info.id);
                      Console.WriteLine(" book name is :"+info.name);
                        break;
                case Catageory.english:
                        info.id = 3;
                        info.name = "english";
                        Console.WriteLine("book id is " + info.id);
                        Console.WriteLine(" book name is :" + info.name);
                        break;

                  
            }
       

    }
    }
}
