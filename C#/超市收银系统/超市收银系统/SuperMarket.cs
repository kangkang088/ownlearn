using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class SuperMarket
    {
        /// <summary>
        /// 创建仓库对象
        /// </summary>
        CangKu ck = new CangKu();
        /// <summary>
        /// 创建超市对象的时候，给仓库的货架导入货物
        /// </summary>
        public SuperMarket()
        {
            ck.GetPros("Acer", 1000);
            ck.GetPros("Banana", 1000);
            ck.GetPros("SamSung", 1000);
            ck.GetPros("JiangYou", 1000);

        }
        /// <summary>
        /// 和用户交互的过程
        /// </summary>
        /// <returns></returns>
        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要什么？");
            Console.WriteLine("我们有鸿基笔记本，香蕉，三星笔记本，酱油.您想要哪个？");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货
            ProductFather[] pros = ck.TakePros(strType, count);
            //计算价格
            double sumMoney = GetMoney(pros);
            Console.WriteLine("您总共应付{0}元",sumMoney);
            //选择打折方式
            //不同时期不同的打着方式，提取一个打折父类，让子类去具体实现
            Console.WriteLine("请选择您的打折方式：1-不打折，2-打九折，3-打八五折，4-买三百送五十，5-买五百送一百");
            string input = Console.ReadLine();
            //通过简单工厂设计模式，根据用户输入获得打折对象并返回父类对象
            CalFather cal = GetCal(input);
            //打折后实际付的价钱          
            double getTotalMoney = cal.GetTotalMoney(sumMoney);
            Console.WriteLine("打完折后，您应付{0}元",getTotalMoney);
            Console.WriteLine("以下是您的购物信息");
            ShowBuyInfo(pros);
        }
        public void ShowBuyInfo(ProductFather[] pros)
        {
            for (int i = 0; i < pros.Length; i++)
            {
                Console.WriteLine("货物名称：" + pros[i].Name + "\t" +"货物单价:" + pros[i].Price + "\t" + "货物编号：" + pros[i].ID);
            }
        }
        /// <summary>
        /// 根据用户的输入，选择所需要的打折对象
        /// </summary>
        /// <param name="input">用户的选择</param>
        /// <returns>返回的父类对象，装的是子类对象</returns>
        public CalFather GetCal(string input)
        { 
            CalFather cal = null;
            switch (input)
            {
                case "1":cal = new CalNormal();
                    break;
                case "2":cal = new CalRate(0.9);
                    break;
                case "3":cal = new CalRate(0.85);
                    break;
                case "4":cal = new CalBuy(300, 50);
                    break;
                case "5":cal = new CalBuy(500, 100);
                    break;
            }
            return cal;
        }
        /// <summary>
        /// 根据用户买的货物，计算总价钱
        /// </summary>
        /// <param name="pros">买的货物</param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double sumMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                sumMoney = sumMoney + pros[i].Price;
            }
            return sumMoney;
        }
        public void ShowPross()
        { 
            ck.ShowPros();
        }
    }
}
