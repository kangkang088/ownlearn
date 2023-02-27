package array;

import java.util.Random;

public class ArrayDemo2 {
    public static void main(String[] args) {
        //数组求最大值
        int[] arr = {11,2,5,48,9,1,54};
        int max = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (max < arr[i]){
                max = arr[i];
            }
        }
        System.out.println(max);


        //
        int[] arr1 = new int[10];
        Random r = new Random();
        for (int i = 0; i < arr1.length; i++) {
            int randomNumber = r.nextInt(100) + 1;
            arr1[i] = randomNumber;
        }
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum + arr1[i];
        }
        System.out.println("和为：" + sum);
        int average = sum / arr1.length;
        System.out.println("平均数为：" + average);
        int count = 0;
        for (int i = 0; i < arr1.length; i++) {
            if (arr1[i] < average){
                count++;
            }
        }
        System.out.println("比平均数小的数据的个数为：" + count);


        int[] arr2 = {1,2,3,4,5};
        int temp = arr2[0];
        arr2[0] = arr2[4];
        arr2[4] = temp;
        for (int i = 0; i < arr2.length; i++) {
            System.out.println(arr2[i]);
        }


        int[] arr3 = {1,2,3,4,5,6,7,8,9};
        for (int i = 0,j = arr3.length - 1; i < j; i++,j--) {
            int temp1 = arr3[i];
            arr3[i] = arr3[j];
            arr3[j] = temp1;
        }
        for (int i = 0; i < arr3.length; i++) {
            System.out.println(arr3[i]);
        }

        //打乱数组中数据的顺序
        int[] arr4 = {1,7,4,64,97,5};
        for (int i = 0; i < arr4.length; i++) {
            int randomIndex = r.nextInt(arr4.length);
            int temp2 = arr4[i];
            arr4[i] = arr4[randomIndex];
            arr4[randomIndex] = temp2;
        }
        for (int i = 0; i < arr4.length; i++) {
            System.out.print(arr4[i] + " ");
        }
    }
}
