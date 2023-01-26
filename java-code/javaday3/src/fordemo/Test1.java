package fordemo;

import java.util.Scanner;

public class Test1 {

    public static void main(String[] args) {

        //1.输出1-5
        for (int i = 1 ; i <= 5 ; i++){
            System.out.println(i);
        }


        //2.输出5-1
        for (int m = 5 ; m >= 1 ; m--){
            System.out.println(m);
        }


        //3.断线重连
        //断线重连的次数最多只有五次
        for (int retouch = 1 ; retouch <= 5 ; retouch++){
            System.out.println("3秒后自动重连，已执行" + retouch + "次");
        }

        //4.求和
        //求1-100之间的和

        int sum = 0;
        for (int number = 1 ; number <= 100 ; number++){
            sum = sum + number;
        }
        System.out.println(sum);


        //5.求1-100之间的偶数和
        int sum1 = 0;
        for(int n = 1 ; n <= 100 ; n++){
            if (n % 2 == 0){
                sum1 = sum1 + n;
            }
        }
        System.out.println(sum1);



        //6.统计满足条件的数字
        //键盘录入两个数字，表示一个范围
        //统计既能被3整除，又能被5整除的数的个数
        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个数字表示范围的开始");
        int number1 = sc.nextInt();
        System.out.println("请录入一个数字表示范围的结束");
        int number2 = sc.nextInt();
        int add = 0;
        for (int x = number1 ; x <= number2 ; x++){
            if (x % 3 == 0 && x % 5 == 0){
                add++;
            }
        }
        System.out.println(add);
    }
}
