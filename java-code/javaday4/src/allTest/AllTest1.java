package allTest;

import java.util.Scanner;

public class AllTest1 {
    public static void main(String[] args) {
        //机票价格按照淡季旺季，头等舱和经济舱收费
        //输入机票原价，月份和头等舱或经济舱
        //计算价格
        //旺季（5-10月）头等舱九折，经济舱8.5折
        //淡季（11月到来年四月）头等舱7折，经济舱6.5折

        Scanner sc = new Scanner(System.in);
        System.out.println("请输入机票原价");
        double m = sc.nextInt();

        System.out.println("请输入月份");
        int n = sc.nextInt();


        System.out.println("1表示经济舱，0表示头等舱");
        int number = sc.nextInt();


        if (n >= 5 && n <= 10){

            m = message1(m,number,0.9,0.85);

        }else if ((m <= 4 && m >=1) || (m >= 11 && m <= 12)){

            m = message1(m,number,0.7,0.65);

        }else {
            System.out.println("没有这个月份");
        }

        System.out.println("机票的价格为：" + m);

    }

    public static double message1(double price,int plan,double v0,double v1){
        if (plan == 1){
            price = price * v1;

        }else if (plan == 0){
            price = price * v0;

        }else
            System.out.println("没有这个舱位");
        return price;


        //ctrl+alt+m快捷抽取方法
        //ctrl+alt+v数组初始化快捷取名
    }
}
