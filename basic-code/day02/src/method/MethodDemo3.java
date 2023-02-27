package method;

public class MethodDemo3 {
    public static void main(String[] args) {
        getSum(10,20,30);
        int result = getSum(10,20,30);
        System.out.println(result);
        System.out.println(getSum(10,20,30));
    }
    public static int getSum(int a, int b,int c){
        int all = a+ b+ c;
        return all;
    }
}
