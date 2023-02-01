package stringDemo;

import java.util.Scanner;

public class StringDemo3 {
    public static void main(String[] args) {
        //1.键盘录入一个字符串
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入一个字符串");
        String str1 = sc.next();//abc 是new出来的
        //2.定义一个字符串
        String str2 = "abc";
        //3.用==号比较
        System.out.println(str1 == str2);//false

        //只要想比较字符串的内容，就必须要用string里面的方法

    }
}
