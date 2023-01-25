package switchdemo;

public class SwitchDemo2 {
    public static void main(String[] args) {
        //1.default的位置 不一定写在最下面，可以写在任意位置，只是习惯写在最下面
        //2.省略 default可以省略，语法没有问题，但不建议省略
        int number = 200;
        switch (number){
            default:
                System.out.println("number的值无法匹配");
                break;
            case 100:
                System.out.println("number的值为：" + number);
                break;
            case 200:
                System.out.println("number的值为：200");
                break;
        }
    }
}
