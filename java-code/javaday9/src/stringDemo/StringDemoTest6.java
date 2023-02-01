package stringDemo;

import java.util.Scanner;

public class StringDemoTest6 {
    public static void main(String[] args) {
        //1.键盘录入一个金额
        Scanner sc = new Scanner(System.in);
        //判断金额是否合法
        while (true) {
            System.out.println("请录入一个金额");
            int money = sc.nextInt();
            if (money >= 0 && money <= 9999999) {
                //查表法转换为大写中文数字
                String[] arr = {"零","壹","贰","叁","肆","伍","陆","柒","捌","玖"};
                String s = stringBack(arr,money);
                System.out.println(s);
                //补零
                int count = 7 - s.length();
                for (int i = 0; i < count; i++) {
                    s = "零" + s;
                }
                System.out.println(s);
                //插入单位
                String s1 = newString(s);
                System.out.println(s1);
                break;
            } else {
                System.out.println("输入金额不合法，请重新输入");
            }

        }
    }
    public static String newString(String str){
        String s = "";
        String[] strings = {"佰","拾","万","仟","佰","拾","元"};
        for (int i = 0; i < str.length(); i++) {
            char c = str.charAt(i);
            s =s + (c + strings[i]);
        }
        return s;
    }
    public static String stringBack(String[] arr,int money){
        String s = "";
        while (money > 0){
            int ge = money % 10;
            money = money / 10;
            s = arr[ge] + s;//防止拼出的字符串是倒着的
        }
        return s;
    }
}
