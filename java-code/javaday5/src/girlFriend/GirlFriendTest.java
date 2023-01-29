package girlFriend;

public class GirlFriendTest {
    public static void main(String[] args) {
        GirlFriend g = new GirlFriend();
        System.out.println(g.getAge());
        g.setAge(18);
        int age = g.getAge();
        System.out.println(age);
        g.setHeight(1.74);
        double height = g.getHeight();
        System.out.println(height);
        g.setName("小康康");
        String name = g.getName();
        System.out.println(name);
        g.setWeight(103.5);
        double weight = g.getWeight();
        System.out.println(weight);
        g.sleep();
        g.playGame();

        GirlFriend g1 = new GirlFriend();
        g1.setName("小丽丽");
        String name1 = g1.getName();
        System.out.println(name1);
        g1.setAge(19);
        int age1 = g1.getAge();
        System.out.println(age1);

        //通过构造方法省略set
        GirlFriend g2 = new GirlFriend(18,"小红",100.0,1.65);
        System.out.println(g2.getAge());
        System.out.println(g2.getHeight());
        System.out.println(g2.getName());
        System.out.println(g2.getWeight());
    }
}
