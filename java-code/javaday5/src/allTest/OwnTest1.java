package allTest;

public class OwnTest1 {

    public static void main(String[] args) {

        //把数字每一位添加到数组

        //1.确定数字的长度

        int number = 1983;

        int temp = number;

        int count = 0;
        while (number != 0){
            number = number / 10;
            count++;
        }

        //2.动态初始化数组
        int[] arr = new int[count];

        //3.添加到数组中
        for (int i = arr.length - 1; i >= 0; i--) {
            arr[i] = temp % 10;
            temp = temp / 10;
        }

        //4.每一位+5

        for (int i = 0; i < arr.length; i++) {
            arr[i] = arr[i] + 5;
        }

        //5.%10
        for (int i = 0; i < arr.length; i++) {
            arr[i] = arr[i] % 10;
        }

        //6.反转
        for (int i = 0,j = arr.length - 1; i < j; i++,j--) {
            int temp1 = arr[i];
            arr[i] = arr[j];
            arr[j] = temp1;
        }

        //7.拼接
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum * 10 + arr[i];
        }

        System.out.println(sum);


    }
}
