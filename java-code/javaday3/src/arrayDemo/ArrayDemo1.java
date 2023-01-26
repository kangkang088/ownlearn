package arrayDemo;

public class ArrayDemo1 {
    public static void main(String[] args) {
        //数组


        //存储五个学生的年龄
        int[] age1 = new int[]{11,12,13,14,15};//完整类型
        int[] age2 = {11,12,13,14,15};//简写类型

        //姓名
        String[] name1 = new String[]{"张三","李四","王五"};
        String[] name2 = {"张三","李四","王五"};

        //身高
        double[] height1 = new double[]{1.93,1.75};
        double[] height2 = {1.93,1.75};

        System.out.println(height2);//[D@65ab7765 地址值

        //地址值的格式含义
        //[D@65ab7765
        //[ 表示数组
        //D 表示当前数组里面的元素都是double类型的
        //@ 表示一个间隔符号 （固定格式）
        //65ab7765 数组真正的地址值
        //习惯闪上把[D@65ab7765这个整体叫做数组的地址值
    }
}
