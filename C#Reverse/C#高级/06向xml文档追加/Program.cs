using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _06向xml文档追加
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //追加xml文档
            //1.命名空间
            //2.创建xml文档对象
            XmlDocument doc = new XmlDocument();
            XmlElement xmlBooks;
            if (File.Exists("books.xml"))
            {
                //3.追加，如果文件存在
                doc.Load("books.xml");//先加载
                //3.1获得文件的根节点
                 xmlBooks = doc.DocumentElement;//这里不用追加到doc，因为文件存在，，本身就有根节点，获得它的根节点就可以了，然后可以利用这个获得的节点，实现追加
            }
            else
            {
                //4.追加，如果文件不存在
                //4.1创建第一行
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8",null);
                doc.AppendChild(dec);
                //4.2创建根节点
                xmlBooks = doc.CreateElement("books");
                doc.AppendChild(xmlBooks);
            }
            //5.给根节点books创建节点
            XmlElement xmlBooks1 = doc.CreateElement("book");
            xmlBooks.AppendChild(xmlBooks1);
            //6.给book添加子节点
            XmlElement xmlName1 = doc.CreateElement("name");
            xmlName1.InnerText = "CSharp";
            xmlBooks1.AppendChild(xmlName1);

            XmlElement xmlPrice1 = doc.CreateElement("price");
            xmlPrice1.InnerText = "1000";
            xmlBooks1.AppendChild(xmlPrice1);

            XmlElement xmdDes1 = doc.CreateElement("des");
            xmdDes1.InnerText = "看不懂";
            xmlBooks1.AppendChild(xmdDes1);

            doc.Save("books.xml");
            Console.ReadKey();


        }
    }
}
