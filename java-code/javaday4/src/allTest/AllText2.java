package allTest;

public class AllText2 {
    public static void main(String[] args) {
        //判断101-200之间有多少个质数，并输出所有质数
        int count = 0;
        for (int i = 101; i <= 200 ; i++) {

            boolean flag = true;

            for (int j = 2; j <= i - 1; j++) {
                if (i % j == 0){
                    flag = false;
                    break;
                }
            }
            if (flag){
                System.out.println(i);
                count++;
            }

        }
        System.out.println("共有" + count + "个质数");
    }
}
