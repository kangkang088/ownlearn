package arrayDemo;

import java.util.Random;

public class Test5 {

    public static void main(String[] args) {

        //生成10个 1-100之间的随机数存入数组
        //求出所有数的和
        //求所有数的平均数
        //统计有多少个数比平均值小


        //定义数组
        int[] arr = new int[10];

        //生成随机数
        Random r = new Random();
        //10个
        for (int i = 0; i < arr.length; i++) {
            int number = r.nextInt(100) + 1;

            //添加到数组中
            arr[i] = number;
        }

        //求和
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum + arr[i];
        }
        System.out.println(sum);


        //求平均数
        int avg = sum / arr.length;
        System.out.println("数组中的平均数为：" + avg);


        //统计比平均数小的数据个数

        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] < avg){
                count++;
            }
        }
        System.out.println("数组中比平均数小的数据个数为：" + count);

        //验证
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }

    }
}
