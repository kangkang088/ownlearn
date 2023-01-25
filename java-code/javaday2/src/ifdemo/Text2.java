package ifdemo;

import java.util.Scanner;

public class Text2 {
    public static void main(String[] args) {
        //键盘录入一个整数表示身上的钱
        //如果大于等于100，则吃网红餐厅
        //否则，去经济实惠的沙县小吃
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入身上的钱");
        int money = sc.nextInt();
        if(money >= 100){
            System.out.println("网红餐厅");
        }else {
            System.out.println("沙县小吃");
        }


        //实际商品价格为600
        //键盘录入一个整数表示用户支付的钱
        //大于等于600，支付成功。否则，失败

        int actuallymoney = sc.nextInt();
        if (actuallymoney >= 600){
            System.out.println("付款成功");
        }else {
            System.out.println("付款失败");
        }


        //影院卖100张票，票号1-100
        //奇数坐左边，偶数坐右边
        //键盘录入一个票号数
        //奇数，打印坐左边
        //偶数，打印坐右边

        System.out.println("请录入票号数");
        int ticket = sc.nextInt();
        if (ticket >=1 && ticket <= 100) {
            if (ticket % 2 == 1) {
                System.out.println("坐左边");
            } else {
                System.out.println("坐右边");
            }
        }
    }
}
