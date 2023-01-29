package allTest;

import java.util.Random;

public class AllTest3 {
    public static void main(String[] args) {
        //抢红包
        //直播抽奖，分别有{2，588，888，1000，10000}五个奖金
        //请用代码模拟抽奖，打印出每个奖项
        //奖项的出现顺序要随机且不重复
        int[] arr = {2, 588, 888, 1000, 10000};
        //定义新数组，存储抽奖结果
        int[] newarr = new int[arr.length];
        //抽五次
        Random r = new Random();
        for (int i = 0; i < 5; ) {
            int randomIndex = r.nextInt(arr.length);

            int prize = arr[randomIndex];

            //判断是否存在
            boolean flag = contains(newarr, prize);
            if (!flag){
                //把当前抽取到的奖项添加到newarr中
                newarr[i] = prize;
                i++;
            }
        }
        for (int i = 0; i < newarr.length; i++) {
            System.out.println(newarr[i]);
        }
    }
    //判断prize在数组中是否存在
    //存在，true
    //false不存在
    public static boolean contains(int[] arr, int prize) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == prize) {
                return true;
            }
        }
        return false;
    }
}
