package arrayDemo;

public class ArrayDemo3 {
    public static void main(String[] args) {

        //数组的遍历
        int[] arr = {1,2,3,4,5};

        //获取数组里面所有的元素
        System.out.println(arr[0]);
        System.out.println(arr[1]);
        System.out.println(arr[2]);
        System.out.println(arr[3]);
        System.out.println(arr[4]);
        //如果数组元素过多就不行了


        //前提是知道数组长度，不知道时就不行了
        for (int i = 0; i < 5; i++) {
            System.out.println(arr[i]);
        }


        //利用数组长度
        //数组名.length
        System.out.println(arr.length);

        for (int i = 0 ; i < arr.length ; i++){
            System.out.println(arr[i]);
        }

        //快速生成数组遍历
        //数组名.fori
    }
}
