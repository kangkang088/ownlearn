package day2;

public class Text3 {
    public static void main(String[] args) {
        int x = 10;
        int y = x++;//先用后加 y=10,x=11
        int z = ++x;//先加后用 z=12,x=12
        System.out.println("x:" + x);//12
        System.out.println("y:" + y);//10
        System.out.println("z:" + z);//12
    }
}
