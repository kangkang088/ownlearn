package methodTest;

public class Test2 {
    public static void main(String[] args) {
        //设计一个方法，求数组的最大值并返回


        int[] arr = {15,87,6,45,7,13};

        int reallymax = max(arr);
        System.out.println(reallymax);

    }
    public static int max(int[] arr){
        int maxif = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (maxif < arr[i]){
                maxif = arr[i];
            }
        }
        return maxif;
    }
}
