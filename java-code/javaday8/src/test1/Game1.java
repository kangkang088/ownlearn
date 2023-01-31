package test1;

public class Game1 {
    public static void main(String[] args) {
        //文字版格斗游戏
        //每个游戏角色的姓名，血量都不相同
        //在选定任务的时候，这些信息就应该被确定下来
        //乔峰打一下，造成了xx点伤害，鸠摩智剩余xxx点血量
        //鸠摩智打一下，造成了xx点伤害，乔峰剩余xxx点血量
        //乔峰k.o.了鸠摩智
        //选1，代表乔峰
        //选2.代表鸠摩智
        Game g1 = new Game("乔峰",100,'男');
        Game g2 = new Game("鸠摩智",100,'男');
        g1.showInfo();
        g2.showInfo();
        //开打
        while (true) {
            g1.attack(g2);
            if (g2.getBlood() == 0) {
                System.out.println(g1.getName() + "K.O了" + g2.getName());
                break;
            }
            g2.attack(g1);
            if (g1.getBlood() == 0){
                System.out.println(g2.getName() + "K.O了" + g1.getName());
                break;
            }
        }

    }
}
