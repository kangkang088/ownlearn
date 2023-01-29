package allTest;

public class TwoDimensionDemo2 {
    public static void main(String[] args) {

        //二维数组动态初始化
        int[][] arr = new int[3][5];
        //3表示二维数组长度为三，可以装三个一维数组
        //5表示每一个一维数组的长度都是5，可以装5个int类型的元素
        arr[0][0] = 10;
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                System.out.print(arr[i][j] + " ");
            }
            System.out.println();
        }

    }
}
