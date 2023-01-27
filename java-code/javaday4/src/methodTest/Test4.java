package methodTest;

public class Test4 {
    public static void main(String[] args) {

        //定义一个方法copyOfRange（int[]，int from，int to）
        //将数组arr中从索引from开始，到索引to结束的元素复制到新的数组中
        //返回新的数组

        int[] arr = {1,2,5,6,7,8,9,4};

        int[] copyarr = copyOfRange(arr,3,7);//返回数组，就用数组来接收

        for (int i = 0; i < copyarr.length; i++) {
            System.out.println(copyarr[i]);
        }
    }

    public static int[] copyOfRange(int[] arr,int from,int to){

        int[] newarr = new int[to - from];

        //伪造索引
        //新数组用来接收
        int index = 0;


        for (int i = from; i < to; i++) {
            newarr[index] = arr[i];
            index++;
        }

        return newarr;
    }
}
