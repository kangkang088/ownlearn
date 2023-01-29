package phone;

public class PhoneTest {
    public static void main(String[] args) {

        //创建手机的对象
        Phone1 p = new Phone1();
        p.brand = "小米";
        p.price = 1999.98;

        System.out.println(p.brand);
        System.out.println(p.price);

        p.call();
        p.playGame();

        Phone1 p2 = new Phone1();
        p2.price = 8999.9;
        p2.brand = "苹果";
        System.out.println(p2.price);

    }
}
