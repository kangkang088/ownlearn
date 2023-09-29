using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _08读取带属性的xml文档
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.命名空间
            //2.创建xml文档对象
            XmlDocument doc = new XmlDocument();
            doc.Load("order.xml");
            //获得所有子节点
            XmlNodeList xmlNodeList = doc.SelectNodes("/order/items/orderItem");
            foreach (XmlNode xmlNode in xmlNodeList) 
            {
                Console.WriteLine(xmlNode.Attributes["name"].Value);
                Console.WriteLine(xmlNode.Attributes["count"].Value);
            }
        }
    }
}
