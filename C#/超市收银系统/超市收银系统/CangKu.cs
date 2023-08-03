using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class CangKu
    {
        //存储货物         
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        /// <summary>
        /// 在创建仓库对象的时候，向仓库中添加货架
        /// </summary>
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void GetPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "鸿基笔记本"));
                        break;
                    case "Banana":
                        list[1].Add(new Banana(Guid.NewGuid().ToString(), 10, "香蕉"));
                        break;
                    case "SamSung":
                        list[2].Add(new SamSung(Guid.NewGuid().ToString(), 10000, "三星笔记本"));
                        break;
                    case "JiangYou":
                        list[3].Add(new JiangYou(Guid.NewGuid().ToString(), 5, "酱油"));
                        break;

                }
            }



        }
        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="strType">取的货物的型号</param>
        /// <param name="count">取的数量</param>
        /// <returns></returns>
        public ProductFather[] TakePros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "鸿基笔记本":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "香蕉":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "三星笔记本":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "酱油":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
        /// <summary>
        /// 展示货物
        /// </summary>
        public void ShowPros()
        { 
            foreach(var item in list) 
            {
                Console.WriteLine("我们仓库有{0}，有{1}个，单价是{2},ID是{3}。", item[0].Name, item.Count, item[0].Price, item[0].ID);
            }
        }
        

    }
}
