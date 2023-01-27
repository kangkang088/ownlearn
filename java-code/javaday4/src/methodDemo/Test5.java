package methodDemo;

public class Test5 {
    public static void main(String[] args) {
        //定义一个方法，比较两个长方形的面积

        double area1 = area(19.8,35.6);
        double area2 = area(15.8,42.9);

        if (area1 > area2){
            System.out.println("第一个长方形面积大");

        }else {
            System.out.println("第二个长方形面积大");
        }

    }
    public static double area(double len,double width){
        double sum = len * width;
        return sum;
    }
}
