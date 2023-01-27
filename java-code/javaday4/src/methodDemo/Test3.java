package methodDemo;

public class Test3 {
    public static void main(String[] args) {

        //定义一个方法，求长方形的周长
        longSquare(10,20);
    }
    public static void longSquare(int len,int wid){
        int sum = (len + wid) * 2;
        System.out.println(sum);
    }
}
