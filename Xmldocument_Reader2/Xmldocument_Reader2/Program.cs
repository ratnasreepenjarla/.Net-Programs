using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xmldocument_Reader2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            Console.WriteLine("BUSESINFORMATION");
            doc.Load("books.xml");
            XmlNodeList buseslist = doc.SelectNodes("/buses/bus");
           
            foreach(XmlNode buslist in buseslist)
            {
                Console.WriteLine(buslist.InnerText.Trim());
                Console.WriteLine("{0},{1},{2}",buslist.Attributes.GetNamedItem("busnum").Value,buslist.Attributes.GetNamedItem("startingtime").Value,
                   buslist.Attributes.GetNamedItem("departuretime").Value );
            }

        }
    }
}
