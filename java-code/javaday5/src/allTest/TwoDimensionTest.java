package allTest;

public class TwoDimensionTest {
    public static void main(String[] args) {

        //第一季度22，66，44
        //第二季度77，33，88
        //第三季度25，45，65
        //第四季度11，66，99
        //计算出每个季度的总营业额和全年的总营业额
        int[][] rich = {
                {22,66,44},
                {77,33,88},
                {25,45,65},
                {11,66,99}
        };
        System.out.println(rich.length);
        int sum = 0;
        for (int i = 0; i < rich.length; i++) {
            int[] rich1 = rich[i];
            //求每个季度的营业额
            //定义一个方法
            int sum1 = all(rich1);
            System.out.println("第" + (i + 1) + "个季度的营业额为" + sum1);
            sum = sum + sum1;
        }
        System.out.println("全年的营业额为" + sum);
    }
    public static int all(int[] arr){
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum + arr[i] ;
        }
        return sum;
    }
}
