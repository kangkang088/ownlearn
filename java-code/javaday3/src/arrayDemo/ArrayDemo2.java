package arrayDemo;

public class ArrayDemo2 {
    public static void main(String[] args) {

        //获取数组里面的元素
        //索引（下标）  数组名[索引]

        int[] arr = {1,2,3,4,5};

        //获取第一个元素

        System.out.println(arr[0]);

        //把数据存储的数组中
        //数组名[索引] = 具体数据/变量；

        arr[0] = 100;
        System.out.println(arr[0]);
        //一旦覆盖之后，原来的数据会消失
    }
}
