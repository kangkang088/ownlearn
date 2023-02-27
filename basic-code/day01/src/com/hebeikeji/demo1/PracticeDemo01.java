package com.hebeikeji.demo1;

import java.util.Random;
import java.util.Scanner;

public class PracticeDemo01 {
    public static void main(String[] args) {


        Random r = new Random();
        int randomNumber = r.nextInt(100) + 1;
        Scanner sc = new Scanner(System.in);
        while (true) {
            System.out.println("请猜数字：");
            int guessNumber = sc.nextInt();
            if (guessNumber > randomNumber) {
                System.out.println("猜大了");
            } else if (guessNumber < randomNumber) {
                System.out.println("猜小了");
            } else {
                System.out.println("猜对了");
                break;
            }
        }
    }
}
