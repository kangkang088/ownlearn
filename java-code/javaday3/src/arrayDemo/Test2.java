package arrayDemo;

public class Test2 {
    public static void main(String[] args) {

        //定义数组
        int[] arr = {1,2,3,4,5,6,7,8,9,10};

        //遍历数组
        int count = 0;
        for (int i = 0; i < arr.length; i++) {

            //判断是否为三的倍数并统计
            if(arr[i] % 3 == 0){
                System.out.println(arr[i]);
                count++;
            }
        }
        System.out.println("总共有" + count + "个");
    }
}
