﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SuperMarket superMarket = new SuperMarket();
            //展示货物
            superMarket.ShowPross();
            superMarket.AskBuying();

        }
    }
}
