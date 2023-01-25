package day2;

import java.util.Scanner;

public class Day_2Demo3 {
    public static void main(String[] args) {
       //+中出现字符串
        System.out.println(1 + "123");//1123
        System.out.println(3.7 + "13");//3.713
        System.out.println("abc" + true);//abctrue


        Scanner sc = new Scanner(System.in);
        int i = sc.nextInt();
        System.out.println("请输入一个三位数：");
        int gewei = i % 10;
        int shi = i / 10 % 10;
        int bai = i / 100 % 10;
        System.out.println("个位是：" + gewei);
        System.out.println("十位是：" + shi);
        System.out.println("百位是：" + bai);


        //字符相加
        char c = 'a';
        int result = c + 0;
        System.out.println(result);//97
        //字符+字符
        //字符+数字
        //运算时会先在ASCII码表中找到字符对应的数字，再用数字进行计算
        System.out.println(1 + 'a');//98
        System.out.println('a' + "abc");//aabc
        //只要有字符串，则进行拼接操作
    }
}
