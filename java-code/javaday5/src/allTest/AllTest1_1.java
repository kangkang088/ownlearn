package allTest;

public class AllTest1_1 {
    public static void main(String[] args) {

        //把整数上的每一位添加到数组中

        //求数组长度
        int number = 45546;

        //临时记录number的值

        int temp = number;

        //统计长度
        int count = 0;

        while (number != 0){
            number = number / 10;
            count++;

        }

        //动态初始化数组
        int[] arr = new int[count];

        //把整数的每一位添加到数组中

        int i = arr.length - 1;

        while (temp != 0){

            int ge = temp % 10;
            temp = temp / 10;

            arr[i] = ge;
            i--;
        }

    }
}
