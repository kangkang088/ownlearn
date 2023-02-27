package method;

public class Practice1 {
    public static void main(String[] args) {
        int[] arr1 = {1,2,3,4,5};
        array(arr1);
        int max = getMax(arr1);
        System.out.println(max);
        boolean o = getLive(arr1,8);
        System.out.println(o);
    }
    public static void array(int[] arr){
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
    }
    public static int getMax(int[] arr){
        int max = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (max < arr[i]){
                max = arr[i];
            }
        }
        return max;
    }
    public static boolean getLive(int[] arr,int number){
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == number){
                return true;
            }
        }
        return false;
    }
}
