package stringDemo;

public class StringDemoTest8 {
    public static void main(String[] args) {
        //身份证信息查看
        //7-14位，出生年月日
        //17位，性别，奇数男，偶数女

        //1.定义一个字符串，记录身份证号码
        String id = "321281202001011234";
        //2.获取出生年月日
        String year = id.substring(6,10);
        String month = id.substring(10,12);
        String day = id.substring(12,14);
        System.out.println("人物信息为：");
        System.out.println("出生年份是" + year + "年");
        System.out.println("出生月份是" + month + "月");
        System.out.println("出生日是" + day + "日");
        //3.性别
        char gender = id.charAt(16);//获取的是字符
        //字符变成数字
        //'0' -> 48
        //'1' -> 49
        //'2' -> 50
        //'3' -> 51
        //'4' -> 52
        //字符变数字，减去48
        //判断奇数偶数，判断男女
        if ((gender - 48) % 2 == 0){
            System.out.println("性别为女");
        }else {
            System.out.println("性别为男");
        }

    }
}
