package arrayDemo;

import java.util.Random;

public class Test7 {
    public static void main(String[] args) {

        //打乱数组中所有数据的顺序
        //可以理解为从第一个元素开始，和其余随机一个元素交换
        //再从第二个开始，再和其余随机元素交换
        //直到最后一个元素

        //定义数组
        int[] arr = {1,2,3,4,5};
        Random r= new Random();

        //循环遍历数组

        for (int i = 0; i < arr.length; i++) {
            //生成随机索引
            int randomIndex = r.nextInt(arr.length);
            //用随机索引指向的元素和i指向的元素交换
            int temp = arr[i];
            arr[i] = arr[randomIndex];
            arr[randomIndex] = temp;
        }


        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
}
