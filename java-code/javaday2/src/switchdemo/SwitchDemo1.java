package switchdemo;

import java.util.Scanner;

public class SwitchDemo1 {
    public static void main(String[] args) {


        Scanner sc = new Scanner(System.in);
        int want = sc.nextInt();
        switch (want) {
            case 1:
                System.out.println("兰州拉面");
                break;
            case 2:
                System.out.println("武汉热干面");
                break;
            case 3:
                System.out.println("红烧牛肉面");
                break;
            default:
                System.out.println("方便面");
                break;
        }


        int day = sc.nextInt();
        switch (day){
            case 1:
                System.out.println("跑步");
                break;
            case 2:
                System.out.println("游泳");
                break;
            case 3:
                System.out.println("慢走");
                break;
            case 4:
                System.out.println("动感单车");
                break;
            case 5:
                System.out.println("拳击");
                break;
            case 6:
                System.out.println("爬山");
                break;
            case 7:
                System.out.println("吃一顿大餐");
                break;
            default:
                System.out.println("无效日期");
        }
    }
}
