package stringDemo;

import java.util.Scanner;

public class StringDemoTest5 {
    public static void main(String[] args) {
        //定义一个方法，实现字符串反转
        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个字符串");
        String str = sc.next();
        String s = stringIndex(str);
        System.out.println(s);
    }
    public static String stringIndex(String str){
        String s = "";
        for (int j = str.length() - 1; j >= 0;j--) {
            char c2 = str.charAt(j);
            s = s + c2;
        }
        return s;
    }
}
