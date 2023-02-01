package stringDemo;

import java.util.Scanner;

public class StringDemoTest2 {
    public static void main(String[] args) {
        //键盘录入一个字符串，使用程序实现在控制台遍历该字符串

        //1.键盘录入
        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个字符串");

        String s = sc.next();

        //2.根据字符串的索引返回字符
        //public char charAt(int index)
        //public int length() 返回字符串的长度
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            System.out.println(c);
        }
    }
}
