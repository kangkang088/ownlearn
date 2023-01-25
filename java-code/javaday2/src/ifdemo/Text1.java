package ifdemo;

public class Text1 {
    public static void main(String[] args) {
        //如果你这次考试第一，我就做你女朋友
        int ranking = 1;
        if (ranking == 1){
            System.out.println("小红成为了你的女朋友");
        }

        //自动驾驶
        //十字路口遇到红绿灯，红灯亮停车，绿灯亮继续行驶
        boolean isLightGreen = true;
        boolean isLightRed = false;
        boolean isLightYellow = false;
        if (isLightGreen){
            System.out.println("gogogo!");
        }
        if (isLightRed) {
            System.out.println("stop!!!");
        }
        if (isLightYellow){
            System.out.println("slow!");
        }
    }
}
