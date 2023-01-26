package whiledemo;

public class WhileDemo1 {
    public static void main(String[] args) {

        //打印1-100
        int i = 1;
        while (i <= 100){
            System.out.println(i);
            i++;
        }


        //珠穆朗玛峰高8844430毫米
        //一张纸0.1毫米
        //多少次可以达到珠穆朗玛峰的高度
        //不知道多少次，直到开始条件和结束条件，用while
        //for循环知道循环的次数和范围
        double height1 = 8844430;
        double height2 = 0.1;
        int count = 0;
        while (height2 <= height1){
            height2 = height2 * 2;
            count++;
        }
        System.out.println(count);


    }
}
