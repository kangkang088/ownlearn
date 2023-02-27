package method;

import java.util.Scanner;

public class Practice3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("请键盘录入机票原价，月份和舱位类型(0-头等舱，1-经济舱)");
        int price = sc.nextInt();
        int month = sc.nextInt();
        int ticket = sc.nextInt();
        if (month >= 5 && month <= 10){
            if (ticket == 0)  {
                System.out.println(price * 0.9);
            }
            else if(ticket == 1) {
                System.out.println(price * 0.85);
            }
            else {
                System.out.println("没有这个舱位");
            }
        }else if ((month >= 1 && month <= 4) || (month >= 11 && month <= 12)){
            if (ticket == 0) {
                System.out.println(price * 0.7);
            }
            else if(ticket == 1) {
                System.out.println(price * 0.65);
            }
            else {
                System.out.println("没有这个舱位");
            }
        }else {
            System.out.println("键盘录入的月份不合法");
        }
    }
}
