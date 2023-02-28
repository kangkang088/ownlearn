package method;

public class Practice8 {
    public static void main(String[] args) {

        int number = 1983;
        int temp =number;
        int count = 0;
        while (number > 0) {
            int ge = number % 10;
            number = number / 10;
            count++;
        }
        int[] arr = new int[count];

        for (int i = arr.length - 1; i >= 0; i--) {
            int ge = temp % 10;
            temp = temp / 10;
            arr[i] = ge;
        }
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
        for (int i = 0; i < arr.length; i++) {
            arr[i] = arr[i] + 5;
        }
        for (int i = 0; i < arr.length; i++) {
            arr[i] = arr[i] % 10;
        }
        for (int i = 0,j = arr.length - 1; i < j; i++,j--) {
            int temp1 = arr[i];
            arr[i] = arr[j];
            arr[j] = temp1;
        }
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum * 10 + arr[i];
        }
        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
}
