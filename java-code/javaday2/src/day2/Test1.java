package day2;

import java.util.Scanner;

public class Test1 {
    public static void main(String[] args) {
        //键盘录入一个三位数，获取其中的个位，十位，百位
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入一个三位数");
        int number = sc.nextInt();

        int one = number % 10;
        int ten = number / 10 % 10;
        int hundred = number / 100 % 10;
        System.out.println(one);
        System.out.println(ten);
        System.out.println(hundred);
    }
}
