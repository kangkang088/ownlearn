package Test;

import java.util.Scanner;

public class LoopTest3 {
    public static void main(String[] args) {


        //录入一个正整数，判断是不是质数

        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个正整数");

        int i = sc.nextInt();

        //判断
            boolean flag = true;  //建立一个标记，来确定验证到哪里

            //假设一开始是质数


        for (int m = 2; m <= i - 1; m++) {
            if (i % m == 0){
                flag = false; //因为一开始是true，有一次false，就不是质数。直到i-1
                System.out.println("不是质数");
                break;
            }
        }
        if (flag){
            System.out.println("是一个质数");
        }else {
            System.out.println("不是质数");
        }


        //数字过大时效率低
        //优化
        //判断一个数是不是质数，只需要判断这个数的中心（平方根）和之前的数  2-平方根

    }
}
