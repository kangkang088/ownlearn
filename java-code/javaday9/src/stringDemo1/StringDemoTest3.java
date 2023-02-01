package stringDemo1;

import java.util.Scanner;

public class StringDemoTest3 {
    public static void main(String[] args) {

        //键盘录入一个字符串，统计该字符串中大写字母字符，小写字母字符，数字字符出现的次数

        Scanner sc = new Scanner(System.in);
        System.out.println("请录入一个字符串");
        String str = sc.next();

        //遍历字符串
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        for (int i = 0; i < str.length(); i++) {
            char c = str.charAt(i);
            if (c >= 'A' && c < 'Z') {
                count1++;
            } else if (c >= 'a' && c <= 'z') {
                count2++;
            } else if ((c - 48) >= 0 && (c - 48) <= 9){
                count3++;
            }
        }
        System.out.println("大写字母字符出现的次数是" + count1 + "次");
        System.out.println("小写字符字符出现的次数是" + count2 + "次");
        System.out.println("数字字符出现的次数是" + count3 + "次");
    }
}
