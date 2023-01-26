package arrayDemo;

public class ArrayDemo4 {


    public static void main(String[] args) {
        //动态初始化
        //存储班级50个学生的姓名
        String[] arr = new String[50];

        arr[0] = "张三";
        arr[1] = "李四";

        System.out.println(arr[0]);
        System.out.println(arr[1]);
        System.out.println(arr[2]);//打印出来的是默认初始化值null

        //数组默认初始化值的规律
        //整数类型 0
        //小数类型 0.0
        //字符类型 '/u0000'  其实就是一个空格
        //布尔类型 false
        //引用数据类型 null


        int[] arr1 = new int[3];
        System.out.println(arr1[0]);//0
    }

}
