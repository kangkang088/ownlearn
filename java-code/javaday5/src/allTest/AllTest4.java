package allTest;

import java.util.Random;

public class AllTest4 {
    public static void main(String[] args) {
        //抢红包
        //直播抽奖，分别有{2，588，888，1000，10000}五个奖金
        //请用代码模拟抽奖，打印出每个奖项
        //奖项的出现顺序要随机且不重复

        //1.把奖池里面的所有奖项打乱顺序
        //2.遍历奖池
        //3.效率高
        int[] arr= {2,588,888,1000,10000};

        Random r = new Random();

        //打乱奖池
        for (int i = 0; i < arr.length; i++) {
            //获取随机索引

            int index = r.nextInt(arr.length);

            int temp = arr[i];
            arr[i] = arr[index];
            arr[index] = temp;

        }

        //遍历奖池打印
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
}
