package day2;

public class Test2 {
    public static void main(String[] args) {
        //隐式转换
        byte b1 = 10;
        byte b2 = 20;
        int result1 = b1 + b2;
        System.out.println(result1);

        //强制转换
        byte a1 = 10;
        byte a2 = 20;
        byte add = (byte) (a1+a2);
        System.out.println(add);
        //强制转换时，数值过大结果会不精确
    }
}
