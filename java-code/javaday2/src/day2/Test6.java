package day2;

import java.util.Scanner;

public class Test6 {
    public static void main(String[] args) {
        //两只老虎，体重分别通过键盘录入获得
        //判断两只老虎体重是否相同
        Scanner sc = new Scanner(System.in);
        System.out.println("请输入第一只老虎的体重");
        int weight1 = sc.nextInt();
        System.out.println("请输入第二只老虎的体重");
        int weight2 = sc.nextInt();

        //1.只能输出true或false
        boolean same1 = weight1 == weight2;
        System.out.println(same1);

        //2.自己定义输出
        String same2 = weight1 == weight2 ? "相同" : "不同";
        System.out.println(same2);


        //已知三人身高分别为150cm，210cm，165cm，
        //获取三个和尚的最高身高
        int one = 150;
        int two = 210;
        int three = 165;
        int max1 = one > two ? one : two;
        int max2 = three > max1 ? three : max1;
        System.out.println(max2);
    }
}
