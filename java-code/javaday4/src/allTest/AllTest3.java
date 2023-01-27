package allTest;

import java.util.Random;

public class AllTest3 {
    public static void main(String[] args) {

            //开发验证码

            //定义方法实现随机产生一个5位的验证码
            //长度为5
            //前四位是大写字母或者小写字母
            //最后一位是数字


            //在一堆没有什么规律的数据中随机抽取
            //可以先把这些数据放到数组中
            //再随机抽取索引


        //1.将大写字母和小写字母都放到数组中
        char[] chs = new char[52];

        for (int i = 0; i < chs.length; i++) {

            //ASCII码表中97代表a，98是b，只要把数字强制类型转换
            //再依次赋给数组，就可以得到a-z

            if(i <= 25){
                chs[i] = (char)(97 + i);
            }else
                chs[i] = (char) (65 + i - 26);
        }


        //2.随机抽取四次并拼接

        Random r = new Random();

        String result = "";

        for (int i = 0; i < 4 ; i++) {

            int m = r.nextInt(52);
            result = result + chs[m];
        }

        //3.抽数字0-9并拼接
        int number = r.nextInt(10);

        result = result + number;

        System.out.println(result);

    }
}