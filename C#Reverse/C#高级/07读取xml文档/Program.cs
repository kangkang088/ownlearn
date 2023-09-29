using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _07读取xml文档
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.命名空间
            //2.创建xml对象
            XmlDocument doc = new XmlDocument();
            //3.加载要读取的xml文档
            doc.Load("books.xml");
            //4.获得根节点
            XmlElement xmlBooks = doc.DocumentElement;
            //5.获得子节点,返回子节点的集合
            XmlNodeList xmlNodeList = xmlBooks.ChildNodes;
            foreach (XmlNode xmlNode in xmlNodeList) 
            {
                Console.WriteLine(xmlNode.InnerText);
            }
            Console.WriteLine("it is successful");
        }
    }
}
