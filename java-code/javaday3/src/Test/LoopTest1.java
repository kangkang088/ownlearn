package Test;

public class LoopTest1 {
    public static void main(String[] args) {

        //任意一个数字开始报数
        //包含7或者是7的倍数时，都要说过
        //打印出1-100之间的满足逢7必过规则的数据

        int i = 1;
        while (i <= 100){

            if (i % 10 == 7 || i / 10 == 7 || i % 7 == 0){
                System.out.println("过");
            }else {
                System.out.println(i);//这里可以用continue，结束打印i，跳到下一次循环
            }
            i++;
        }

    }
}
