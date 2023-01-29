package allTest;

import java.util.Random;
import java.util.Scanner;

public class OwnTest2 {
    public static void main(String[] args) {

        //1.生成中奖号码
        int[] getNumber1 = getNumber();
        for (int i = 0; i < getNumber1.length; i++) {
            System.out.println(getNumber1[i]);
        }

        //2.用户输入号码
        int[] newerInput1 = newerInput();

        //3.统计中奖号码个数
        int redCount= 0;
        int blueCount = 0;
        //规则：只要getNumber1中有号码和newerNumber1中对应，不论顺序，都是中奖
        //红球
        for (int i = 0; i < getNumber1.length - 1; i++) {
            for (int j = 0; j < newerInput1.length - 1; j++) {
                if (getNumber1[i] == newerInput1[j]) {
                    redCount++;
                    break;
                }
            }
        }
        //蓝球
        if (getNumber1[getNumber1.length - 1] == newerInput1[newerInput1.length - 1]){
            blueCount++;
        }
        System.out.println(redCount);
        System.out.println(blueCount);

        //4.比较中奖金额
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
        int[] arr = new int[7];
        Scanner sc = new Scanner(System.in);
        //输入前六位红色号码
        for (int i = 0; i < arr.length - 1;) {
            System.out.println("请输入第" + (i + 1) + "位红球号码");
            int redNumber = sc.nextInt();
            //判断是否满足号码条件
            if (redNumber >= 1 && redNumber <= 33){
                //判断是否重复
                boolean flag = contains(arr,redNumber);
                if (!flag){
                    arr[i] = redNumber;
                    i++;
                }else {
                    System.out.println("输入的号码不合法，请重新输入");
                }
            }
        }

        //输入第七位蓝色号码
        System.out.println("请输入蓝球号码");
        while(true){
            int blueNumber = sc.nextInt();
            if (blueNumber >= 1 && blueNumber <= 16){
                arr[arr.length - 1] = blueNumber;
                break;
            }else {
                System.out.println("输入的蓝球号码不合法，请重新输入");
            }
        }
        return arr;
    }
    public static int[] getNumber(){
        Random r = new Random();
        int[] arr = new int[7];
        //前6位红球号码
        for (int i = 0; i < arr.length - 1;) {
            int redNumber = r.nextInt(33) + 1;
            //规则，红球号码不能重复
            //确定红球号码不重复并依次传到数组中
            boolean flag = contains(arr,redNumber);
            if(!flag){
                arr[i] = redNumber;
                i++;
            }
        }
        //第七位蓝球号码
        int blueNumber = r.nextInt(16) + 1;
        arr[arr.length - 1] = blueNumber;
        return arr;
    }
    public static boolean contains(int[] arr,int number){
        for (int i = 0; i < arr.length - 1; i++) {
            if (arr[i] == number){
                arr[i] = number;
                return true;
            }
        }
        return false;
    }
}
