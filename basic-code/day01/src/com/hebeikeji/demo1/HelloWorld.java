package com.hebeikeji.demo1;

import java.util.Scanner;

public class HelloWorld {
    public static void main(String[] args) {
        //注释
        System.out.println("HelloWorld!");
        System.out.println(5+2);
        System.out.println(5-2);
        System.out.println(5*2);

        //代码中有小数参与运算，结果有可能不是精确的
        System.out.println(5*2.2);

        System.out.println(4/2);

        Scanner sc = new Scanner(System.in);
        System.out.print("请键盘录入一个三位数：");
        int number = sc.nextInt();
        System.out.println("个位是" + number % 10);
        System.out.println("十位是" + number / 10 % 10);
        System.out.println("百位是" + number / 100);
        byte b1 = 10;
        byte b2 = 12;
        byte sum = (byte) (b1 + b2);
        System.out.println(sum);

        //字符串拼接从左到右依次进行
        System.out.println(3.7 + "abc");//3.7abc
        System.out.println(1 + 2 + 6 + "sdjqoi");//9sdjqoi

        char c = 'a';//字符在计算机中以数字存储（ASCII码表）
        //A - 65   a - 97
        int result = c + 0;
        System.out.println(result);
        char s = '1';
        System.out.println(s);


        System.out.print("请录入您的时髦程度（0-10）：");
        int ownerFasion = sc.nextInt();
        System.out.print("请录入相亲对象的时髦程度：");
        int girlFasion = sc.nextInt();
        boolean contrast = ownerFasion > girlFasion;
        System.out.println("true表示相亲成功，false表示相亲失败");
        System.out.println(contrast);
    }
}
