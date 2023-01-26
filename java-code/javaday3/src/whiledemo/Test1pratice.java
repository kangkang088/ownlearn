package whiledemo;

public class Test1pratice {
    public static void main(String[] args) {

        //判断回文数

        int m = 12321;

        int temp = m;

        int sum = 0;

        while (m != 0){
            int ge = m % 10;

            m = m / 10;

            sum = sum * 10 + ge;
        }

        System.out.println(sum);

        System.out.println(m);

        System.out.println(temp);

        System.out.println(sum == temp);
    }
}
