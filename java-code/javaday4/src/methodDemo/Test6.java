package methodDemo;

public class Test6 {
    public static void main(String[] args) {
        //使用方法重载思想，设计比较两个整数是否相同的方法
        //要求：兼容全整数类型byte short int long
        compare((byte) 1,(byte) 0);
        byte b1 = 10;
        byte b2 = 20;
        compare(b1,b2);

    }

    //一般会把相同功能的方法名起成一样的
    //好处1.不需要更多的单词
    //好处2.调用方法更简单
    public  static  void compare(byte number1,byte number2){
        System.out.println(number1 == number2);
    }
    public  static  void compare(short number1,short number2){
        System.out.println(number1 == number2);
    }
    public  static  void compare(int number1,int number2){
        System.out.println(number1 == number2);
    }
    public  static  void compare(long number1,long number2){
        System.out.println(number1 == number2);
    }

}
