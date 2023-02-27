package method;

public class Practice2 {
    public static void main(String[] args) {
        int[] arr1 = {1,2,3,4,5,6,7,8,9,10};
        int[] newArr = copyOfRange(arr1,3,7);
        for (int i = 0; i < newArr.length; i++) {
            System.out.println(newArr[i]);
        }
    }
    public static int[] copyOfRange(int[] arr,int from,int to){
        int[] arr2 = new int[to - from];
        int j = 0;
        for (int i = from; i < to; i++) {
            arr2[j] = arr[i];
            j++;
        }
        return arr2;
    }
}
