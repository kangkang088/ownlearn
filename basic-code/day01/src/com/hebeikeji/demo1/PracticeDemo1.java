package com.hebeikeji.demo1;

import java.util.Scanner;

public class PracticeDemo1 {
    public static void main(String[] args) {
        System.out.println(true & true);
        System.out.println(true & false);
        System.out.println(false & true);
        System.out.println(false & false);
        System.out.println("------------");
        System.out.println("------------");
        System.out.println(true | true);
        System.out.println(true | false);
        System.out.println(false | true);
        System.out.println(false | false);
        System.out.println("------------");
        System.out.println("------------");
        System.out.println(true ^ true);
        System.out.println(true ^ false);
        System.out.println(false ^ true);
        System.out.println(false ^ false);
        System.out.println("------------");
        System.out.println("------------");
        System.out.println(!true);
        System.out.println(!false);

        Scanner sc = new Scanner(System.in);
        System.out.print("请录入第一个整数：");
        int number1 = sc.nextInt();
        System.out.print("请录入第二个整数：");
        int number2 = sc.nextInt();
        //三种满足一个（||），而不是一个不满足就全否定（&&）
        boolean result = number1 == 6 || number2 == 6 || (number2 + number1) % 6 == 0;
        System.out.println(result);

    }
}
