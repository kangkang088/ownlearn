package array;

public class ArrayDemo1 {
    public static void main(String[] args) {
        int[] array1 = new int[]{1,2,3};
        int[] array2 = {2,3,4};
        int[] arr = {1,2,3,4,5};
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] % 3 == 0){
                sum++;
            }
        }
        System.out.println(sum);

        for (int i = 0; i < arr.length; i++) {
            if (arr[i] % 2 != 0){
                arr[i] = arr[i] * 2;
            }else {
                arr[i] = arr[i] / 2;
            }
        }
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
}
