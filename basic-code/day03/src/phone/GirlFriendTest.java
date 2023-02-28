package phone;

public class GirlFriendTest {
    public static void main(String[] args) {
        GirlFriend gf = new GirlFriend();
        gf.setName("冰冰");
        System.out.println(gf.getName());
        gf.setAge(23);
        System.out.println(gf.getAge());
        gf.setHeight(178);
        System.out.println(gf.getHeight());
        gf.setWeight(110);
        System.out.println(gf.getWeight());
        gf.playGame();
        gf.study();
        gf.sleep();
    }
}
