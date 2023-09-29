using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05创建带属性的xml文档
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8",null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("customerName");
            customerName.InnerText = "康康";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("customerNumber");
            customerNumber.InnerText = "10000";
            order.AppendChild(customerNumber);

            XmlElement items = doc.CreateElement("items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("orderItem");
            //给节点添加属性
            orderItem1.SetAttribute("name", "码表");
            orderItem1.SetAttribute("count", "10");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("orderItem");
            //给节点添加属性
            orderItem2.SetAttribute("name", "码表");
            orderItem2.SetAttribute("count", "10");
            items.AppendChild(orderItem2);

            XmlElement orderItem3 = doc.CreateElement("orderItem");
            //给节点添加属性
            orderItem3.SetAttribute("name", "码表");
            orderItem3.SetAttribute("count", "10");
            items.AppendChild(orderItem3);

            doc.Save("order.xml");
            Console.WriteLine("保存成功");
        }
    }
}
