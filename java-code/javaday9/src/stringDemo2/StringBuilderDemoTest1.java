package stringDemo2;

import java.util.Scanner;

public class StringBuilderDemoTest1 {

    //使用StringBuilder的场景
    //字符串的拼接
    //字符串的反转
    public static void main(String[] args) {
        //1.对称
        //正反一样


        Scanner sc = new Scanner(System.in);
        System.out.println("请输入一个字符串");
        String s = sc.next();

        StringBuilder sb = new StringBuilder();
 //       //添加字符串
 //       sb.append(s);
 //       //反转字符串
 //       sb.reverse();
 //       //容器变为字符串
 //       String s2 = sb.toString();
 //       System.out.println(s2);


        //链式编程也可以
        String s1 = sb.append(s).reverse().toString();

        //比较
        if (s.equals(s1)){
            System.out.println("对称");
        }else {
            System.out.println("不对称");
        }

    }
}
