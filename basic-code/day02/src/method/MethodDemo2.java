package method;

public class MethodDemo2 {
    public static void main(String[] args) {
        getSum(160,20);
        getLength(10,50);
        areas(5);
    }

    public static void getSum(int a, int b){
        int c = a + b;
        System.out.println(c);
    }
    public static void getLength(int length,int width){
        int all = (length + width) * 2;
        System.out.println(all);
    }
    public static void areas(int r){
        double S = 3.14 * r * r;
        System.out.println(S);
    }
}
