package arrayDemo;

public class ArrayDemo5 {
    public static void main(String[] args) {

        //索引越界问题
        int[] arr = {1,2,3,4,5};
        //最大索引是4  arr.length-1
        System.out.println(arr[2]);

        //索引越界异常
        //知道索引的范围就可以
        //0~length-1
    }
}
