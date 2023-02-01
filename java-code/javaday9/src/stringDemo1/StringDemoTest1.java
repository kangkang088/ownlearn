package stringDemo1;

import java.util.Scanner;

public class StringDemoTest1 {
    public static void main(String[] args) {
        //已知正确的用户名和密码，请用程序实现模拟用户登录
        //总共给三次机会，登录之后，给出相应的提示


        //1.正确的用户名和密码
        String rightUsername = "zhangsan";
        String rightPassword = "123456";

        int count = 0;
        for (int i = 0; i < 3; i++) {
            //2.键盘录入
            Scanner sc = new Scanner(System.in);
            System.out.println("请输入用户名");
            String userName = sc.next();
            System.out.println("请输入密码");
            String password = sc.next();

            //3.比较

            if (userName.equals(rightUsername) && password.equals(rightPassword)){
                System.out.println("用户登录成功");
                break;
            }else {
                count++;
                if (count == 3){
                    System.out.println("账户已被锁定，请联系相关人员解锁");
                }else {
                    System.out.println("用户名或密码有误," + "还有" + (3 - count) + "次机会");
                }
            }
        }
    }
}
