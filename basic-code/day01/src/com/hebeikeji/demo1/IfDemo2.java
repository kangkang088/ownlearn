package com.hebeikeji.demo1;

import java.util.Scanner;

public class IfDemo2 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("请键盘录入用户所拥有的钱数：");
        int number = sc.nextInt();
        if (number >= 600){
            System.out.println("付款成功！");
        }else{
            System.out.println("付款失败！");
        }

        System.out.print("请键盘录入小明成绩：");
        int fraction = sc.nextInt();

        //对异常数据进行校验
        if (fraction >= 0 && fraction <= 100) {
            if (fraction >= 95 && fraction <= 100) {
                System.out.println("自行车一辆");
            } else if (fraction >= 90 && fraction <= 94) {
                System.out.println("游乐场一天");
            } else if (fraction >= 80 && fraction <= 89) {
                System.out.println("变形金刚一个");
            } else {
                System.out.println("揍一顿");
            }
        }else {
            System.out.println("当前录入的成绩不合法");
        }

        int price = 1000;
        System.out.print("键盘录入会员的级别：");
        int vipLevel = sc.nextInt();
        if (vipLevel == 1){
            System.out.println("实际支付的钱为：" + (price * 0.9));
        }else if (vipLevel == 2){
            System.out.println("实际支付的钱为：" + (price * 0.8));
        }else if (vipLevel == 3){
            System.out.println("实际支付的钱为：" + (price * 0.7));
        }else {
            System.out.println("实际支付的钱为：" + price);
        }
    }
}
