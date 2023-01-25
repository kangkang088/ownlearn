package day2;

public class Day_2Demo5 {
    public static void main(String[] args) {
        int a = 10;
        int b = 20;
        a += b;//等同于 a = (int) (a + b);
        //把a+b的值赋给a
        System.out.println(a);//30
        System.out.println(b);//20


        //细节：
        //+= -= /= *= %= 底层都隐藏了一个强制类型转换
        short s = 1;
        //short类型计算时转换为int类型
        s += 1;//实质是 s = ( short ) ( s+1 );不是s = s + 1;
        System.out.println(s);//2
    }
}
