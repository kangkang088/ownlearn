package switchdemo;

public class SwitchDemo3 {
    public static void main(String[] args) {
        //case 穿透
        //首先用小括号里面的值跟下面每一个case匹配
        //匹配不上，则往下继续匹配
        //匹配上了，从这个case开始，如果没有发现break，程序会继续执行下一个case的语句体，直到遇到break或者大括号为止

        //使用场景
        //如果多个case语句重复，则用case穿透


        int number = 200;
        switch (number){
            case 100:
                System.out.println("number的值为：" + number);
                break;
            case 200:
                System.out.println("number的值为：200");
                //break;
            default:
                System.out.println("number的值无法匹配");
                break;
        }
    }
}
