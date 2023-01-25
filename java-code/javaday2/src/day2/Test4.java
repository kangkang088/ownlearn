package day2;

import java.util.Scanner;

public class Test4 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入男生的时髦度");
        int boyFasion = sc.nextInt();
        System.out.println("请输入女生的时髦度");
        int girlFasion = sc.nextInt();
        boolean result = boyFasion > girlFasion;
        System.out.println(result);
    }
}
