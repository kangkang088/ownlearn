package method;

public class MethodDemo1 {
    public static void main(String[] args) {
        print();
        girlInfo();
        add();
    }
    public static void print(){
        System.out.println("开始游戏");
        System.out.println("对线");
        System.out.println("崩盘");
        System.out.println("骂队友");
        System.out.println("投降");
    }
    public static void girlInfo(){
        System.out.println("小冰");
        System.out.println("18岁");
        System.out.println("萌妹子");
        System.out.println("身材火辣");
    }
    public static void add(){
        int a = 10;
        int b = 20;
        System.out.println(a + b);
    }
}
