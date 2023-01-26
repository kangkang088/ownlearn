package arrayDemo;

public class Test1 {
    public static void main(String[] args) {

        //定义一个数组
        int[] arr = {1,2,3,4,5};

        //遍历数组
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum + arr[i];
        }
        System.out.println(sum);
    }
}
