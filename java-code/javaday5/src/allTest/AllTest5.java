package allTest;

import java.util.Random;
import java.util.Scanner;

public class AllTest5 {
    public static void main(String[] args) {
        //1.生成中奖号码
        int[] arr = creatNumber();
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }

        //2.用户输入彩票号码
        int[] arr1 = newerInput();

        //3.判断几等奖
        int redCount = 0;
        int blueCount = 0;
        //红球中的个数
        for (int i = 0; i < arr.length - 1; i++) {
            for (int j = 0; j < arr1.length - 1; j++) {
                if (arr[i] == arr1[j]){
                    redCount++;
                    break;
                }
            }
        }
        //蓝球中的个数
        int blue = arr1[arr1.length-1];
        if (blue == arr[arr.length-1]){
            blueCount++;
        }

        //确定几等奖
        if (redCount == 6 && blueCount == 1){
            System.out.println("中1000万");
        }else if (redCount == 6 && blueCount == 0){
            System.out.println("中500万");
        }else if (redCount == 6 && blueCount == 0){
            System.out.println("中500万");
        }else if (redCount == 5 && blueCount == 1){
            System.out.println("中3000");
        }else if ((redCount == 5 && blueCount == 0) ||(redCount == 4 && blueCount == 1)){
            System.out.println("中200");
        }else if ((redCount == 4 && blueCount == 0) || (redCount == 3 && blueCount == 1)){
            System.out.println("中10");
        }else if ((redCount == 2 && blueCount == 1) || (redCount == 1 && blueCount == 1) || (redCount == 0 && blueCount == 1)){
            System.out.println("中5");
        }else {
            System.out.println("谢谢惠顾");
        }

    }
    public static int[] newerInput(){
        int[] newerNumber = new int[7];

        //用户输入红球
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < 6;) {
            System.out.println("请输入第" + (i+1) + "位红球号码");
            int redNumber = sc.nextInt();
            if (redNumber >= 1 && redNumber <= 33){
                boolean flag = contains(newerNumber,redNumber);
                if (!flag){
                    newerNumber[i] = redNumber;
                    i++;
                }
            }else {
                System.out.println("当前红球号码超出范围");
            }
        }

        //蓝球
        System.out.println("请输入篮球号码");
        while (true){
            int blueNumber = sc.nextInt();
            if (blueNumber >=1 && blueNumber <=16){
                newerNumber[newerNumber.length-1] = blueNumber;
                break;
            }else {
                System.out.println("超出范围,请重新输入");
            }
        }
        return newerNumber;
    }
    public static int[] creatNumber(){
        int[] arr = new int[7];

        //生成红球号码
        Random r = new Random();
        for (int i = 0; i < arr.length;) {
            int redNumber = r.nextInt(33) + 1;
            boolean flag = contains(arr,redNumber);
            if (!flag){
                arr[i] = redNumber;
                i++;
            }

        }

        //生成篮球号码
        int blueNumber = r.nextInt(16) + 1;
        arr[arr.length - 1] = blueNumber;

        return arr;
    }
    public static boolean contains(int[] arr,int number){
        for (int i = 0; i < arr.length; i++) {
            if(arr[i] == number){
                return true;
            }
        }
        return false;
    }
}
