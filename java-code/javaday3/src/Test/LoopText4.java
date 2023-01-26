package Test;

import java.util.Random;
import java.util.Scanner;

public class LoopText4 {
    public static void main(String[] args) {


        //猜数字小游戏



        //获取随机数
        Random r = new Random();

        //小括号里面时随机数的范围，一定是0开始，到这个数减一。
        //包头不包尾，包左不包右
        int i = r.nextInt(10);

        System.out.println(i);

        //要生成任意数到任意数的范围

        //比如7-15
        //1.减去7  0-8
        //尾巴+1   0-9  右边作为括号里面的值
        //再加7
        int m = r.nextInt(9) + 7; // 7-15

        System.out.println(m);

        //生成1-100的随机数
        int x = r.nextInt(100) + 1;//这个代码不能写到循环里面
        System.out.println(x);
        //猜这个数字是多少

            Scanner sc = new Scanner(System.in);
            System.out.println("请猜数字");
            int count = 0;
        while (true) {
            int n = sc.nextInt();
            count++;
            if (count == 3){
                System.out.println("猜中了");
                break;
            }
            if (n > x) {
                System.out.println("猜大了");
            } else if (n < x) {
                System.out.println("猜小了");
            } else {
                System.out.println("恭喜你，猜中了！");
                break;
            }

        }

        //加一个保底机制，第3次猜不中直接提示猜中了

    }
}
