package switchdemo;

import java.util.Scanner;

public class Text2 {
    public static void main(String[] args) {
        //拨打服务电话
        //1机票查询
        //2机票预订
        //3机票改签
        //4推出服务
        Scanner sc =new Scanner(System.in);
        System.out.println("请按键");
        int choose = sc.nextInt();
        switch (choose){
            case 1 -> System.out.println("机票查询");
            case 2 -> System.out.println("机票预订");
            case 3 -> System.out.println("机票改签");
            //case 4 -> System.out.println("推出服务");
            default -> System.out.println("推出服务");
        }

    }

}
