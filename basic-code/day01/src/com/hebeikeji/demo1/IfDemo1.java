package com.hebeikeji.demo1;

import java.util.Scanner;

public class IfDemo1 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("请键盘录入女婿的酒量：");
        int number  = sc.nextInt();
        if (number > 2){
            System.out.println("小伙子，不错不错！！！");
        }else {
            System.out.println("垃圾！！");
        }

        System.out.print("请录入小明的分数：");
        int fraction = sc.nextInt();
        if (fraction >= 99){
            System.out.println("小红成了小明的女朋友");
        }else {
            System.out.println("小明失去了小红");
        }

        System.out.println("-----------");
        System.out.println("-----------");

        boolean isLightGreen = true;
        boolean isLightRed = false;
        boolean isLightYellow = false;
        if (isLightGreen){
            System.out.println("gogogo！！！");
        }
        if (isLightRed){
            System.out.println("stand up！！！");//cease   crease
        }
        if (isLightYellow){
            System.out.println("slow！");
        }

    }
}
