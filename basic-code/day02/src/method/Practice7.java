package method;

import java.util.Scanner;

public class Practice7 {
    public static void main(String[] args) {
        int[] scoreArr = getScores();
        int max = getMax(scoreArr);
        int min = getMin(scoreArr);
        int sum = getAdd(scoreArr);
        int avg = (sum - max - min) / (scoreArr.length - 2);
        System.out.println(avg);
    }
    public static int[] getScores(){
        int[] fraction = new int[6];
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < fraction.length;) {
            System.out.println("请第" + (i+1) + "位评委打分");
            int fractions = sc.nextInt();
            if (fractions >= 0 && fractions <= 100) {
                fraction[i] = fractions;
                i++;
            }else {
                System.out.println("数据不合法，请重新输入");
            }
        }
        return fraction;
    }
    public static int getMax(int[] arr){
        int max = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (max < arr[i]){
                max = arr[i];
            }
        }
        return max;
    }
    public static int getMin(int[] arr){
        int min = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (min > arr[i]){
                min = arr[i];
            }
        }
        return min;
    }
    public static int getAdd(int[] arr){
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum + arr[i];
        }
        return sum;
    }
}
