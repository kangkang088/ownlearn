package methodTest;

public class Test1 {
    public static void main(String[] args) {
        //设计方法，求数组的遍历
        int[] arr = {1,2,3,4,5};
        array(arr);


    }

    public static void array(int[] arr){
        System.out.print("[");
        for (int i = 0; i < arr.length; i++) {
            if (i<=arr.length-2){
                System.out.print(arr[i] +"," + " ");
            }else {
                System.out.print(arr[i]);
            }
        }
        System.out.println("]");
    }
}
