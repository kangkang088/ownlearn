package whiledemo;

public class Test2 {

    public static void main(String[] args) {

        //给定两个整数，作为除数和被除数，且都是正数，不超过int的取值范围
        //将两数相除，要求不使用乘法，除法和%运算符
        //得到商和余数

         /*  100-10=90
            90-10=80
            80-10=70
            ...
            10-10=0
         */

        int a = 100;
        int b = 10;
        int count = 0;
        while (a >= b) {
            a = a - b;
            count++;
        }
        System.out.println("商是" + count);
        System.out.println("余数是" + a);
    }
}
