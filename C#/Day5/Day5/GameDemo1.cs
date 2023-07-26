using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class GameDemo1
    {
        //静态字段模拟全局变量
        public static int[] Maps = new int[100];
        //声明静态数组用来存储玩家的坐标
        public static int[] PlayersPoints = new int[2];
        //玩家姓名的数组
        public static string[] PlayersNames = new string[2];
        //bool数组来看是否暂停
        public static bool[] Flags = new bool[2];//默认false
        static void Main(string[] args)
        {
            GameShow();

            #region 玩家输入姓名
            Console.WriteLine("请输入玩家A的姓名：");
            PlayersNames[0] = Console.ReadLine();
            while (PlayersNames[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入");
                PlayersNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名：");
            PlayersNames[1] = Console.ReadLine();
            while (PlayersNames[1] == "" || PlayersNames[1] == PlayersNames[0])
            {
                if (PlayersNames[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空，请重新输入");
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能用玩家A的姓名相同，请重新输入");
                }
                PlayersNames[1] = Console.ReadLine();
            }
            #endregion

            //姓名输入完成后清屏，重新调用游戏头，展现地图
            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵用A表示，{1}的士兵用B表示", PlayersNames[0], PlayersNames[1]);

            //先初始化地图，使数组里面有0，1，2，3，4五种数据，再画地图
            InitialMap();
            DrawMap();

            //没有一个人在终点的时候，玩游戏
            while (PlayersPoints[0] < 99 && PlayersPoints[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayersPoints[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了", PlayersNames[0]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayersPoints[1] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了", PlayersNames[1]);
                    break;
                }               
            }//while
            GameEnd();
            Console.ReadKey();
        }
        public static void GameEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("游戏结束");
        }
        #region 画地图并判断玩家位置，根据位置来画地图
        //地图头
        public static void GameShow()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************************");
            Console.WriteLine("******飞行器游戏1.0.1*******");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("****************************");
        }

        //将整数数组中的数字变成控制台中显示字符串的过程就是初始化地图的过程
        public static void InitialMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//1-幸运轮盘●
            for (int i = 0; i < luckyturn.Length; i++)
            {
                //将1给到地图数组，初始化为幸运轮盘
                int index = luckyturn[i];
                Maps[index] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//2-地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                //将2给到地图数组，初始化为地雷
                int index = landMine[i];
                Maps[index] = 2;
            }
            int[] pause = { 1,2,3,4,6,9, 27, 60, 93 };//3-暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                //将3给到地图数组，初始化为暂停
                int index = pause[i];
                Maps[index] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//4-时空隧道
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                //将4给到地图数组，初始化为时空隧道
                int index = timeTunnel[i];
                Maps[index] = 4;
            }
        }

        //画地图
        public static void DrawMap()
        {
            Console.WriteLine("图示：幸运轮盘-●，地雷-☆，暂停-▲，时空隧道-卍");
            #region 第一横行
            //第一横行0-29
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));

            }
            #endregion
            //换行
            Console.WriteLine();
            #region 第一个竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                #region 判断玩家位置
                Console.Write(DrawStringMap(i));
                #endregion
                Console.WriteLine();
            }
            #endregion
            #region 第二横行
            for (int i = 64; i > 34; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //换行
            Console.WriteLine();
            #region 第二个竖行
            for (int i = 65; i < 70; i++)
            {
                #region 判断玩家位置
                Console.Write(DrawStringMap(i));
                #endregion
                Console.WriteLine();
            }
            #endregion
            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));

            }
            #endregion
            Console.WriteLine();
        }

        //每一行都要判断玩家位置来确定关卡的图案，封装成一个方法
        public static string DrawStringMap(int i)
        {
            #region 判断位置并画图
            string str = "";
            //玩家坐标相同并且都在地图上时，<>
            if (PlayersPoints[0] == PlayersPoints[1] && PlayersPoints[0] == i)
            {
                str = "<>";
            }
            //不同时，a在i，则A
            else if (PlayersPoints[0] == i)
            {
                str = "Ａ";

            }
            //不同时，b在i，则B
            else if (PlayersPoints[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {

                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□"; break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("●"); break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "☆"; break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "▲"; break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "卍"; break;
                }
            }
            #endregion
            return str;

        }
        #endregion

        #region 玩游戏的方法
        public static void PlayGame(int i)
        {
            ////避免一方踩到暂停永远玩不了的情况
            //Flags[1 - i] = false;

            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("玩家{0}按任意键开始掷骰子", PlayersNames[i]);
            Console.ReadKey(true);//true-不显示按下的键；false-显示
            Console.WriteLine("玩家{0}掷出了{1}", PlayersNames[i],rNumber);
            PlayersPoints[i] += rNumber;
            ChangePoints();
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键开始行动", PlayersNames[i]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}行动完了", PlayersNames[i]);
            Console.ReadKey(true);
            //先前进，再判断踩到了什么东西                
            //A猜到B,B退六格，踩到方块无事发生，踩到幸运轮盘出选择，踩到地雷退六格，踩到暂停停一回合，踩到时空隧道进10格
            if (PlayersPoints[i] == PlayersPoints[1-i])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退六格", PlayersNames[i], PlayersNames[1-i], PlayersNames[1-i]);
                PlayersPoints[1-i] -= 6;
                ChangePoints();
                Console.ReadKey(true);
            }
            else
            {
                switch (Maps[PlayersPoints[i]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，无事发生", PlayersNames[i]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择1-交换位置，2-轰炸对方", PlayersNames[i]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}和玩家{1}交换位置", PlayersNames[i], PlayersNames[1-i]);
                                Console.ReadKey(true);
                                int temp = PlayersPoints[i];
                                PlayersPoints[i] = PlayersPoints[1-i];
                                PlayersPoints[1 - i] = temp;
                                Console.WriteLine("交换完成，按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退六格", PlayersNames[i], PlayersNames[1 - i], PlayersNames[1 - i]);
                                Console.ReadKey(true);
                                PlayersPoints[1 - i] -= 6;
                                ChangePoints();
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1-交换位置，2-轰炸对方，请重新输入");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，退六格", PlayersNames[i]);
                        PlayersPoints[i] -= 6;
                        ChangePoints();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，停止一回合", PlayersNames[i]);                       
                        Flags[i] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayersNames[i]);
                        PlayersPoints[i] += 10;
                        ChangePoints();
                        Console.ReadKey(true);
                        break;
                }//switch
            }//else
             //判断所有情况发生后，清屏，将发生后的地图显示在控制台
            Console.Clear();
            DrawMap();
        }
        //避免玩家出棋盘
        //玩家坐标发生改变的时候调用
        public static void ChangePoints()
        {
            if (PlayersPoints[0] < 0)
            {
                PlayersPoints[0] = 0;
            }
            if (PlayersPoints[0] >= 99)
            {
                PlayersPoints[0] = 99;
            }
            if (PlayersPoints[1] < 0)
            {
                PlayersPoints[1] = 0;
            }
            if (PlayersPoints[1] >= 99)
            {
                PlayersPoints[1] = 99;
            }
        }
        #endregion
    }
}
