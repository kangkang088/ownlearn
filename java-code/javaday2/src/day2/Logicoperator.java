package day2;

public class Logicoperator {
    public static void main(String[] args) {
        //1. &  逻辑与
        System.out.println(true & true);
        System.out.println(true & false);
        System.out.println(false & true );
        System.out.println(false & false);


        //2. |逻辑或
        System.out.println(true | true);
        System.out.println(true | false);
        System.out.println(false | true);
        System.out.println(false | false);


        //3. ^逻辑异或  相同为false  不同为true
        System.out.println(true ^ true);
        System.out.println(true ^ false);
        System.out.println(false ^ true);
        System.out.println(false ^ false);


        //4. !逻辑非
        //逻辑非！要么不写，要么只写一个
        System.out.println(!false);
        System.out.println(!true);

        //5.短路逻辑运算符 &&
        System.out.println(true && true);
        System.out.println(true && false);
        System.out.println(false && true);
        System.out.println(false && false);

        //6.   ||
        System.out.println(true || true);
        System.out.println(true || false);
        System.out.println(false || true);
        System.out.println(false || false);

        //短路逻辑运算符具有短路效果
        //左边表达式成立，右边的就不会运行，提高了效率
        int a = 10;
        int b = 10;
        boolean o = ++a < 5 && ++b < 5;
        System.out.println(a);//11
        System.out.println(b);//10
        System.out.println(o);//false
    }
}
