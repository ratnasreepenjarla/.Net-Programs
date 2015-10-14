using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocumentWriter
{
    class Program
    {
        static void Main(string[] args)
        {
           int choice;
           bool iscontinue=true;
            XmlDocument doc = new XmlDocument();
           
            XmlElement businfo = doc.CreateElement("buses");
            do
            {
                XmlElement buselement = doc.CreateElement("bus");
                XmlAttribute busnumattribute = doc.CreateAttribute("busnum");
                XmlAttribute stimeattribute = doc.CreateAttribute("startingtime");
                XmlAttribute etimeattribute = doc.CreateAttribute("departuretime");

                XmlElement bookingelement = doc.CreateElement("bookingtype");
                XmlElement costelement = doc.CreateElement("price");
                XmlElement seatselement = doc.CreateElement("numofseats");

                Console.WriteLine("enter busnum");
                String busnum = Console.ReadLine();
                Console.WriteLine("enter starting time");
                String startingtime = Console.ReadLine();
                Console.WriteLine("enter departuretime");
                String departuretime = Console.ReadLine();
                Console.WriteLine("enter bookintype");
                String bookingtype = Console.ReadLine();

                Console.WriteLine("enter price");
                String price = Console.ReadLine();
                Console.WriteLine("enter num of seats");
                String numofseats = Console.ReadLine();


                busnumattribute.Value = busnum;
                stimeattribute.Value = startingtime;
                etimeattribute.Value = departuretime;

                bookingelement.InnerText = bookingtype;
                costelement.InnerText = price;
                seatselement.InnerText = numofseats;

                buselement.Attributes.Append(busnumattribute);
                buselement.Attributes.Append(stimeattribute);
                buselement.Attributes.Append(etimeattribute);

                buselement.AppendChild(bookingelement);
                buselement.AppendChild(costelement);
                buselement.AppendChild(seatselement);

                businfo.AppendChild(buselement);
                doc.AppendChild(businfo);
                Console.WriteLine(("do you want to continue? yes=>1 , exit=>0" ));
                 choice = int.Parse(Console.ReadLine());
            } while (iscontinue=(choice==1));

            doc.Save("businfo.xml");
         
        }
    }
}
