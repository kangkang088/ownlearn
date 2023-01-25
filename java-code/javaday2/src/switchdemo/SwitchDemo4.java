package switchdemo;

public class SwitchDemo4 {
    public static void main(String[] args) {
        //switch 新特性  jdk12
        int number = 1;
        switch (number){
            case 1:
                System.out.println("一");
                break;
            case 2:
                System.out.println("二");
                break;
            case 3:
                System.out.println("三");
                break;
            default:
                System.out.println("没有这种选项");
                break;
        }


        //新特性 优化break，避免case穿透
        int max = 3;
        switch (max){
            case 1 -> {
                System.out.println("一");
            }
            case 2 -> {
                System.out.println("二");
            }
            case 3 -> {
                System.out.println("三");
            }
            default -> {
                System.out.println("没有这种选项");
            }
        }

        //只有一个语句时，可以省略大括号
        int min = 2;
        switch (min){
            case 1 -> System.out.println("一");
            case 2 -> System.out.println("二");
            case 3 -> System.out.println("三");
            default -> System.out.println("没有这种选项");
        }
    }
}
