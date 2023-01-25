package ifdemo;

import java.util.Scanner;

public class Text3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //95-100送自行车
        //90-94，游乐场玩一天
        //80-89，变形金刚一个
        //80，揍一顿
        int score = sc.nextInt();
        if (score >= 0 && score <= 100) {
            if (score >= 95 && score <= 100) {
                System.out.println("送自行车");
            } else if (score >= 90 && score <= 94) {
                System.out.println("游乐场");
            } else if (score >= 80 && score <= 89) {
                System.out.println("变形金刚");
            } else {
                System.out.println("揍一顿");
            }
        }else {
            System.out.println("不合法");
        }



        //商品总价为1000
        //键盘录入会员级别，算出实际价格
        //会员一级，九折
        //会员二级，八折
        //会员三级，七折
        //非会员，骨折
        int price = 1000;
        int level = sc.nextInt();
        if (level == 1){
            System.out.println("实际支付的钱为：" + (price*0.9));
        }   else if (level == 2){
            System.out.println("实际支付的钱为：" + (price*0.8));
        }else if (level == 3){
            System.out.println("实际支付的钱为：" + (price*0.7));
        }else {
            System.out.println("实际支付的钱为：" + price);
        }


        //自动驾驶
        boolean isLightGreen = false;
        boolean isLightRed = false;
        boolean isLightYellow = true;
        if (isLightGreen){
            System.out.println("gogogo!!!");
        } else if (isLightRed) {
            System.out.println("stop!!");
        } else if (isLightYellow) {
            System.out.println("slow!");
        }
    }
}
