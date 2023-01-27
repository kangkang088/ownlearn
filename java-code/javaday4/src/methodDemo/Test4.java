package methodDemo;

public class Test4 {
    public static void main(String[] args) {
        //定义一个方法，求圆的面积

        getArea(5.5);
    }
    public static void getArea(double r){
        double S = 3.14 * r * r;
        System.out.println(S);
    }
}
