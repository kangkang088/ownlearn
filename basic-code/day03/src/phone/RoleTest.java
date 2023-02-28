package phone;

public class RoleTest {
    public static void main(String[] args) {
        Role r1 = new Role("乔峰",100,'男');
        Role r2 = new Role("鸠摩智",100,'男');
        r1.gamerInfo();
        r2.gamerInfo();
        while (true) {
            r1.attack(r2);
            if (r2.getBlood() == 0) {
                System.out.println(r1.getFace() + "的" + r1.getName() + "击败了" + r2.getName());
                break;
            }
            r2.attack(r1);
            if (r1.getBlood() == 0){
                System.out.println(r2.getFace() + "的" + r2.getName() + "击败了" + r1.getName());
                break;
            }
        }

    }
}
