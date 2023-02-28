package method;

public class Practice10 {
    public static void main(String[] args) {
        int[][] arr = {
                {1,2,3},
                {4,5,6,7,8}
        };
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                System.out.println(arr[i][j]);
            }
        }

        int[][] arr1 = new int[3][5];
        for (int i = 0; i < arr1.length; i++) {
            for (int j = 0; j < arr1[i].length; j++) {
                System.out.print(arr1[i][j]);
            }
            System.out.println();
        }
    }
}
