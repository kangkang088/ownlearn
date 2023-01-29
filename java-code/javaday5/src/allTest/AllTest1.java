package allTest;

public class AllTest1 {
    public static void main(String[] args) {

        //数字加密
        //某系统数字密码（大于0），比如1983，采用加密方式进行传输，
        //先得到某位数
        //每位数+5，再对10求余，最后将所有数字反转，得到一串新数

        int[] arr = {1,9,8,3};// 把整数上的每一位添加到数组中

        //+5
        for (int i = 0; i < arr.length; i++) {
            arr[i] = arr[i] + 5;
        }

        //%10
        for (int i = 0; i < arr.length; i++) {
            arr[i] = arr[i] % 10;
        }

        //反转
        for (int i = 0, j = arr.length - 1; i < j; i++,j--) {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        //数字拼接

        int number = 0;

        for (int i = 0; i < arr.length; i++) {
            number = number * 10 + arr[i];
        }



        System.out.print(number);





    }
}
