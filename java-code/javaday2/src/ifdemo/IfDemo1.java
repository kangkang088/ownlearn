package ifdemo;

import java.util.Scanner;

public class IfDemo1 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入女婿的酒量");
        int wine = sc.nextInt();
        if (wine > 2) {
            System.out.println("小伙子，不错");
        }

        //1.大括号的开头建议写在第一行的末尾
        //2.语句体中如果只有一行代码，大括号可以省略.建议不省略
        //3.如果对一个布尔类型的变量进行判断，不要用==号，直接将变量写进括号

        boolean flag = false;
        if (flag){
            System.out.println("flag的值为true");
        }
    }
}
