package methodDemo;

public class methodDemo2 {
    public static void main(String[] args) {
        //带参数的方法定义和调用
        getsum(15,16);
    }

    public static void getsum(int a,int b){
        int sum = a + b;
        System.out.println(sum);
    }
}
