package skiplopp;

public class SkipLoppDemo1 {

    public static void main(String[] args) {
        //跳转控制语句

        //跳过某次循环

        //老虎吃包子，第三个有虫子


        for (int i = 1 ; i <= 5 ; i++) {
            if (i == 3){
                //结束本次循环，继续下次循环
                continue;
                }
            System.out.println("小老虎在吃第" + i + "个包子");
            }


        //第三个包子饱了
        for (int m = 1 ; m <= 5 ; m++){

            System.out.println("小老虎在吃第" + m + "个包子");//放到下面吃不到第三个包子

            if (m == 3){
                break;
                }

            }
        }


}
