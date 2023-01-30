package game;

import java.util.Random;

public class Game {
    private String name;
    private int blood;
    public Game(){

    }
    public Game(String name,int blood){
        this.blood = blood;
        this.name = name;
    }
    public void setName(String name){
        this.name = name;
    }
    public String getName(){
        return name;
    }
    public void setBlood(int blood){
        this.blood = blood;
    }
    public int getBlood(){
        return blood;
    }

    //攻击
    public void attack(Game g){
        Random r = new Random();
        int number = r.nextInt(20) + 1;
        //剩余血量
        int remainNumber = g.getBlood() - number;
        remainNumber = remainNumber < 0 ? 0:remainNumber;
        //修改挨揍人的血量
        g.setBlood(remainNumber);
        System.out.println(this.name + "打了" + g.getName() + "一下，造成了" + number +  "点伤害，" + g.getName() + "还剩下" + remainNumber + "点血量");
    }
}
