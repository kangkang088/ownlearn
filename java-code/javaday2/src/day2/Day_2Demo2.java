package day2;

public class Day_2Demo2 {
    public static void main(String[] args) {

        //隐式转换（自动类型提升）
        int a = 10;
        double b = a;
        System.out.println(b);//10.0


        //强制转换
        double m = 10.3;
        int n = (int) m;
        System.out.println(n);

        int s = 300;
        byte q =(byte) s;
        System.out.println(q);
        //结果不准确，有损失
    }
}
