package Test;

import java.util.Scanner;

public class LoopTest2 {
    public static void main(String[] args) {


        //键盘录入一个大于等于2的整数x，计算并返回x的平方根
        //结果只保留整数部分，小数舍去

        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个大于等于2的整数");
        int x = sc.nextInt();

        /*1*1=1<10
          2*2=4<10
          3*3=9<10
          4*4=16>10
               10的平方根是在3-4之间
        */

        for (int i = 1; i <= x; i++) {
            if (i * i == x){
                System.out.println(i + "就是" + x + "的平方根");
                break;//找到了就不需要继续循环了
            } else if (i * i > x) {
                System.out.println((i-1) + "就是" + x + "的平方根");
                break;
            }
        }

    }
}
