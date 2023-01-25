package day2;

public class Day_2Demo1 {
    public static void main(String[] args) {
        // 除法
        System.out.println(10/2);
        System.out.println(10/3);//整数参与运算，结果只能得到整数3
        System.out.println(10.0/3);//3.3333333333333335
        //整数参与运算，结果只能得到整数
        //小数参与运算，结果可能是不精确的

        //取模
        System.out.println(10%2);//0
        System.out.println(10%3);//1

        //应用场景
        //1.判断A是否可以被B整除
        //2.判断一个数A是否为偶数/奇数
        //3.斗地主发牌
        //每张牌的序号%3
        //1则给第一个玩家，2给第二个玩家，0给第三个玩家


    }
}
