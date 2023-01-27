package allTest;

import java.util.Scanner;

public class AllTest5 {
    public static void main(String[] args) {

        //评委打分

        //在歌唱比赛中，有6个评委个选手打分，0-100之间的整数
        //选手最后得分位：去掉最高分，最低分后的4个评委的平均分，
        //完成上述过程并计算出选手的得分

        //

        //1.建立一个方法获取评委打分
        int[] scores = getScores();

        //2.建立一个方法获取最大值
        int max = getMax(scores);

        //3.建立一个方法获取最小值
        int min = getMin(scores);

        //4.建立一个方法求平均值
        int avg = getAvg(max,min,scores);

        //5.打印平均分
        System.out.println(avg);
    }
    public static int[] getScores(){

        int[] getScore = new int[6];

        Scanner sc = new Scanner(System.in);


        for (int i = 0; i < 6;) {

            System.out.println("请评委打分");

            int score = sc.nextInt();

            if (score >= 0 && score <= 100){
                getScore[i] = score;
                i++;
            }else {
                System.out.println("请重新打分");
            }
        }
        return getScore;
    }

    public static int getMax(int[] scores){
        int max = scores[0];
        for (int i = 1; i < scores.length; i++) {
            if(max < scores[i]){
                max = scores[i];
            }
        }
        return max;
    }

    public static int getMin(int[] scores){
        int min = scores[0];
        for (int i = 0; i < scores.length; i++) {
            if (min > scores[i]){
                min =scores[i];
            }
        }
        return min;
    }

    public static int getAvg(int max,int min,int[] scores){
        int sum = 0;
        for (int i = 0; i < scores.length; i++) {
            sum = sum + scores[i];
        }
        int avg = (sum - max - min) / (scores.length - 2);

        return avg;
    }
}
