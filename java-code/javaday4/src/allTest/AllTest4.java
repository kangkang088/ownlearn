package allTest;

public class AllTest4 {
    public static void main(String[] args) {

        //把一个数组中的元素复制到另一个新的数组中去

        int[] arr1 = {1,2,3,4,5};
        int[] arr2 = new int[arr1.length];
        for (int i = 0; i < arr1.length; i++) {
            arr2[i] = arr1[i];
        }
        for (int i = 0; i < arr2.length; i++) {
            System.out.println(arr2[i]);
        }
    }
}
