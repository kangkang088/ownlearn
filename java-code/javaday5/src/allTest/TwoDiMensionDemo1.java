package allTest;

public class TwoDiMensionDemo1 {
    public static void main(String[] args) {
        //1.二维数组静态初始化
        int[][] arr = new int[][]{{2,3},{4,5,6}};
        int[][] arr1 = {{2,3},{4,5,6}};

        //建议这样写
        //每一个一维数组时二维数组的一个元素，要用，隔开
        int[][] arr3 = {
                {2,3},
                {4,5,6}
        };

        //2.获取元素
        //arr[i][j]
        //arr 二维数组
        //i 二维数组的索引，获取的是一维数组
        //j 一维数组的索引，获取到是真的的元素
        System.out.println(arr3[0]);//获取二维数组中的第一个一维数组的地址值
        System.out.println(arr3[0][0]);//获取二维数组中的第一个一维数组的第一个元素2
        System.out.println(arr3[1][2]);//6


        //3.二维数组遍历
        for (int i = 0; i < arr3.length; i++) {
            //i表示二维数组的索引，表示的是一维数组
            for (int j = 0; j < arr3[i].length; j++) {
                //j表示一维数组的每一个元素
                System.out.print(arr[i][j] + " ");
            }
            System.out.println();
        }
    }
}
