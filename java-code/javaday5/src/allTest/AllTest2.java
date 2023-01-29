package allTest;

public class AllTest2 {
    public static void main(String[] args) {

        //数字解密

        //1.定义一个数组，记录解密之后的结果
        int[] arr = {8,3,4,6};

        //2.反转
        for (int i = 0, j = arr.length - 1; i < j; i++,j--) {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
        //3.由于加密是对10取余来进行的，解密时，要进行判断
        //0-4之间，+10；5-9之间，不变


        for (int i = 0; i < arr.length; i++) {
            if(arr[i] >= 0 && arr[i] <= 4){
                arr[i] = arr[i] + 10;
            }
        }
        //4.-5
        for (int i = 0; i < arr.length; i++) {
            arr[i] = arr[i] - 5;
        }


        //拼接
        int number = 0;
        for (int i = 0; i < arr.length; i++) {
            number = number * 10 + arr[i];
        }

        System.out.println(number);
    }

}
