package com.hebeikeji.demo1;

import java.util.Scanner;

public class SwitchDemo1 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("请点餐：");
        int number = sc.nextInt();
        switch (number){
            case 1 -> {
                System.out.println("重庆热干面");
            }
            case 2 -> {
                System.out.println("打卤面");
            }
            case 3 -> {
                System.out.println("麻辣牛肉面");
            }
            default -> {
                System.out.println("汤面");
            }

        }

        System.out.print("请键盘录入一个整数：");
        int day = sc.nextInt();
        switch (day){
            case 1,2,3,4,5 -> System.out.println("工作日");
            case 6,7 -> System.out.println("休息日");
            default -> System.out.println("数据不存在");
        }
    }
}
