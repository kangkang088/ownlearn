using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;//1.

namespace _04创建XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建xml文档
            //1.引用命名空间
            //2.创建xml文档对象
            XmlDocument doc = new XmlDocument();
            //3.创建第一行描述信息并且添加到doc中
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(xmlDeclaration);
            //4.创建根节点并添加到文档中
            XmlElement xmlBooks =  doc.CreateElement("books");
            doc.AppendChild(xmlBooks);
            //5.给根节点books创建节点
            XmlElement xmlBooks1 = doc.CreateElement("book");
            xmlBooks.AppendChild(xmlBooks1);
            //6.给book添加子节点
            //第一个
            XmlElement xmlName1 = doc.CreateElement("name");
            xmlName1.InnerText = "金瓶梅";
            xmlBooks1.AppendChild(xmlName1);

            XmlElement xmlPrice1 = doc.CreateElement("price");
            xmlPrice1.InnerText = "10";
            xmlBooks1.AppendChild(xmlPrice1);

            XmlElement xmdDes1 = doc.CreateElement("des");
            xmdDes1.InnerText = "好看";
            xmlBooks1.AppendChild (xmdDes1);

            //第二个
            XmlElement xmlBooks2 = doc.CreateElement("book");
            xmlBooks.AppendChild(xmlBooks2);

            XmlElement xmlName2 = doc.CreateElement("name");
            xmlName2.InnerText = "金瓶梅";
            xmlBooks2.AppendChild(xmlName2);

            XmlElement xmlPrice2 = doc.CreateElement("price");
            xmlPrice2.InnerText = "10";
            xmlBooks2.AppendChild(xmlPrice2);

            XmlElement xmdDes2 = doc.CreateElement("des");
            xmdDes2.InnerText = "好看";
            xmlBooks2.AppendChild(xmdDes2);



            doc.Save("books.xml");
            Console.WriteLine("保存成功");
        }
    }
}
