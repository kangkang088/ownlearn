package com.hebeikeji.demo1;

import java.util.Scanner;

public class ForDemo1 {
    public static void main(String[] args) {
        for (int i = 0; i < 5; i++) {
            System.out.println("HelloWorld！");
        }
        for (int i = 1; i < 6; i++) {
            System.out.println(i);
        }
        int sum = 0;
        for (int i = 2; i < 101; i+=2) {
            sum = sum + i;
        }
        System.out.println(sum);
        Scanner sc = new Scanner(System.in);
        System.out.print("请键盘录入第一个数字：");
        int number1 = sc.nextInt();
        System.out.print("请键盘录入第二个数字：");
        int number2 = sc.nextInt();
        int count = 0;
        if (number1 >= number2){
            for (int i = number2; i <= number1; i++) {
                if (i % 3 == 0 && i % 5 == 0){
                    count++;
                }
            }
        }
        if (number1 <= number2){
            for (int i = number1; i <= number2; i++) {
                if (i % 3 == 0 && i % 5 == 0){
                    count++;
                }
            }
        }
        System.out.println(count);

        int height = 8844430;
        double paper = 0.1;
        int count1 = 0;
        while (paper <= height){
            paper = paper * 2;
            count1++;
        }
        System.out.println(count1);

        int x = 12321;
        int temp = x;
        int num = 0;
        while (x != 0){
            int ge = x % 10;
            x = x / 10;
            num = num * 10 + ge;
        }
        System.out.println(num);
        boolean contrast = num == temp;
        System.out.println(contrast);

        int a = 101;
        int b = 10;
        int count2 = 0;
        while (a >= b){
            a = a - b;
            count2++;
        }
        System.out.println("商是：" + count2);
        System.out.println("余是：" + a);


        //逢7过
        for (int i = 1; i < 101; i++) {
            if (i % 10 == 7 || i / 10 == 7 || i % 7 == 0) {
                System.out.println("过");
                continue;
            }
            System.out.println(i);
        }

        //平方根
        int someone = 10;
        for (int i = 1; i <= someone; i++) {
            if (i * i == someone){
                System.out.println(i);
                break;
            }else if (i * i > someone){
                System.out.println(i - 1);
                break;
            }
        }

        //判断是否为质数
        int m = 3;
        boolean o1 = true;
        for (int i = 2; i <= m - 1; i++) {
            if (m % i == 0){
                o1 = false;
                System.out.println("不是质数");
                break;
            }
        }
        if (o1){
            System.out.println("是质数");
        }
    }
}
