package method;

import java.util.Random;

public class Practice9 {
    public static void main(String[] args) {
        int[] arr = {2,588,888,1000,10000};
        int[] newArr = new int[arr.length];
        Random r = new Random();
        for (int i = 0; i < 5;) {
            int randomIndex = r.nextInt(arr.length);
            int prize = arr[randomIndex];
            boolean o = contains(newArr,prize);
            if (!o){
                newArr[i] = prize;
                i++;
            }
        }
        for (int i = 0; i < newArr.length; i++) {
            System.out.println(newArr[i]);
        }

    }
    public static boolean contains(int[] arr,int prize){
        for (int i = 0; i < arr.length; i++) {
            if(arr[i] == prize){
                return true;
            }
        }
        return false;
    }
}
