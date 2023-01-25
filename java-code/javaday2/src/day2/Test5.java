package day2;

import java.util.Scanner;

public class Test5 {
    public static void main(String[] args) {

        //6是一个伟大数字，键盘录入两个整数
        //如果其中一个为6，则最终结果为true
        //如果它们的和为6的倍数，则最终结果为true
        //其他情况都是false
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入第一个整数：");
        int a = sc.nextInt();
        System.out.println("请输入第二个整数：");
        int b = sc.nextInt();
        boolean o = a == 6 || b == 6 || (a+b) % 6 == 0;
        System.out.println(o);
    }
}
