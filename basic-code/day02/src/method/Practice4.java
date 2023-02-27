package method;

public class Practice4 {
    public static void main(String[] args) {
        for (int i = 101; i <= 200; i++) {
            boolean o = true;
            for (int j = 2; j < i; j++) {
                if (i % j == 0){
                    o = false;
                    break;
                }
            }
            if (o){
                System.out.print("是质数" + " ");
                System.out.println(i);
            }
        }
    }
}
