package method;

import java.util.Random;

public class Practice5 {
    public static void main(String[] args) {
        random();
    }
    public static void random(){
        Random r = new Random();
        char[] arr1 = new char[52];
        for (int i = 0; i < arr1.length; i++) {
            if (i <=25) {
                arr1[i] = (char) (97 + i);
            }else {
                arr1[i] = (char)(65 + i - 26);
            }
        }
        String str = "";
        for (int i = 0; i < 4; i++) {
            int index = r.nextInt(arr1.length);
            str = str + arr1[index];
        }
            int number = r.nextInt(10);
            str = str + number;
        System.out.print(str);
    }
}
