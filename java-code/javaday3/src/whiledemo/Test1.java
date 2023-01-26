package whiledemo;

import java.util.Scanner;

public class Test1 {
    public static void main(String[] args) {
        //.回文数
        //正序和倒序读都是一样的数
        //判断一个数是不是回文数，是，则打印true；不是，打印false。
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入一个整数");
        int number = sc.nextInt();
        //temp记录number，用来最后和倒叙的比较
        int temp = number;
        int num = 0;
        while (number != 0){
            //从右往左获取每一位数字
            int ge = number % 10;

            //去掉获取的数字
            number = number / 10;

            //拼接获取的数字
            num = num * 10 + ge;
        }
        System.out.println(num);

        System.out.println(num == temp);
    }
}
