package stringDemo2;

import java.util.Scanner;

public class StringBuilderDemo2 {
    public static void main(String[] args) {
        //链式编程
        //当完美在调用一个方法的时候，不需要用变量接收其返回值，可以继续调用其他方法
        int length = getString().substring(1).replace("a", "q").length();
        //表示对返回的字符串截取索引1-末尾的内容，然后替换a为q，再计算长度，因为计算长度后就变成数了，所以不能再继续调用了
        System.out.println(length);

        //利用链式编程添加字符串
        StringBuilder sb = new StringBuilder();
        sb.append("aaa").append("bbb").append("ccc").append("ddd");
        //因为调用完了append后返回的依旧是容器，所以可以继续调用
        System.out.println(sb);
    }
    public static String getString(){
        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个字符串");
        String str = sc.next();
        return str;
    }
}
