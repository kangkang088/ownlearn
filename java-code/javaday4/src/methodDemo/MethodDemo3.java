package methodDemo;

public class MethodDemo3 {
    public static void main(String[] args) {
        //求商场每个季度的营业额
        //再计算出全年的总额
        getSum(10,20,30);//无结果

        double sum1 = getSum(10,20,30);
        System.out.println(sum1);
        System.out.println(getSum(10,20,30));

        double sum2 = getSum(10,20,40);
        double sum3 = getSum(10,50,60);
        double sum4 = getSum(50,40,50);

        double all = sum1 + sum2 + sum3 + sum4;
        System.out.println(all);
    }

    public static double getSum(int num1,int num2,int num3){
        int sum = num1 + num2 + num3;
        return sum;
    }
}
