package arrayDemo;

public class Test4 {
    public static void main(String[] args) {

        //求最值

        //假设为打擂台
        //假设一个擂主是最大的
        //一个一个的（遍历）和擂主打，赢得就是擂主（赋值）
        int[] arr = {35,5000,22,44,55};
        int max = arr[0]; //不能写0 ，因为数组里面的元素可能全是负数
        for (int i = 1; i < arr.length; i++) {  //开始是自己和自己比较，所以i可以从1开始
            if (arr[i] > max){
                max = arr[i];
            }
        }
        System.out.println(max);
    }
}
