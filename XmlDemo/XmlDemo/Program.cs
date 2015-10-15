using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader reader = new XmlTextReader("Books.xml");
            while(reader.Read())
            {
                //Console.WriteLine("Node Type={0},Name={1},value={2}",reader.NodeType,reader.Name,reader.Value);
                Console.WriteLine("{0},{1},{2}", reader.NodeType, reader.Name, reader.Value);
 
 
                while(reader.Name=="Books")
                {
                    reader.MoveToContent();
                    reader.Read();
                                 
                }
            }
        }
    }
}
