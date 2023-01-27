package methodTest;

public class Test3 {
    public static void main(String[] args) {

        //定义一个方法，判断数组中的某一个数是否存在，并返回这个数到调用处

        int[] arr = {15,4,6,55,5,87,3,1,};



        boolean n = getnumber(arr,88);
        System.out.println(n);
    }
    public static boolean getnumber(int[] arr,int number){



        for (int i = 0; i < arr.length; i++) {
            if (number == arr[i]){
                return true;
            }
        }
        return false;
    }
}
