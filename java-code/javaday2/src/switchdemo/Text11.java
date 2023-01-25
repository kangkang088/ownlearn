package switchdemo;

import java.util.Scanner;

public class Text11 {
    public static void main(String[] args) {
        //键盘录入星期数，输出工作日，休息日
        //1-5 工作日
        //6-7 休息日
        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个星期日");
        int day = sc.nextInt();
        switch (day){
            case 1:
                System.out.println("工作日");
                break;
            case 2:
                System.out.println("工作日");
                break;
            case 3:
                System.out.println("工作日");
                break;
            case 4:
                System.out.println("工作日");
                break;
            case 5:
                System.out.println("工作日");
                break;
            case 6:
                System.out.println("休息日");
                break;
            case 7:
                System.out.println("休息日");
                break;

            default:
                System.out.println("没有这个星期");
        }



        //太繁琐，可以利用case穿透
        int day1 = sc.nextInt();
        switch (day1){
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                System.out.println("工作日");
                break;
            case 6:
            case 7:
                System.out.println("休息日");
                break;
            default:
                System.out.println("没有这个星期");
        }


        //继续简化
        int day2 = sc.nextInt();
        switch (day2){
            case 1,2,3,4,5:
                System.out.println("工作日");
                break;
            case 6,7:
                System.out.println("休息日");
                break;
            default:
                System.out.println("没有这个星期");
        }


        //继续简化
        int day3 = sc.nextInt();
        switch (day3){
            case 1,2,3,4,5 -> System.out.println("工作日");
            case 6,7 -> System.out.println("休息日");
            default -> System.out.println("没有这个星期");
        }
    }
}
