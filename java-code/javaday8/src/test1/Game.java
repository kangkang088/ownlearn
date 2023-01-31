package test1;

import java.util.Random;

public class Game {
    private String name;
    private int blood;
    private  char gender;
    private String face;
    String[] boyfaces = {"气宇轩昂","风流倜傥","英俊潇洒"};
    String[] girlfaces = {"美奂绝伦","倾国倾城","沉鱼落雁"};
    //攻击描述
    String[] attack_desc = {
            "%s使出了一招【背心钉】，转到对方身后，一掌向%s的灵台拍去",
            "%s使出了一招【游龙步】，飞到对方上方，一脚向%s的太阳穴踢去",
            "%s大喝一声，一瞬间飞到%s的面前，向其刺去"
    };
    //受伤描述
    String[] injured_desc = {
            "结果%s毫发无损",
            "结果一击命中，%s痛的弯下了腰",
            "结果%s摇摇晃晃，一下子摔倒在地"
    };
    public Game(){

    }
    public Game(String name, int blood,char gender){
        this.blood = blood;
        this.name = name;
        this.gender = gender;
        setFace(gender);
    }
    public void setFace(char gender) {
        //长相随机
        Random r = new Random();
        if (gender == '男'){
            int index = r.nextInt(boyfaces.length);
            this.face = boyfaces[index];
        }else if(gender == '女'){
            int index = r.nextInt(girlfaces.length);
            this.face = girlfaces[index];
        }else {
            this.face = "面目狰狞";
        }
    }
    public char getGender() {
        return gender;
    }

    public void setGender(char gender) {
        this.gender = gender;
    }

    public String getFace() {
        return face;
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
        //攻击的描述
        Random r1 = new Random();
        int index = r1.nextInt(attack_desc.length);
        String kongFu = attack_desc[index];
        System.out.printf(kongFu,this.getName(),g.getName());
        System.out.println();

        Random r = new Random();
        int number = r.nextInt(20) + 1;
        //剩余血量
        int remainNumber = g.getBlood() - number;
        remainNumber = remainNumber < 0 ? 0:remainNumber;
        //修改挨揍人的血量
        g.setBlood(remainNumber);

        //受伤的描述
        //血量大于90，0索引的描述
        //50-90，1索引的描述
        //0-49，2索引的描述
        if (remainNumber >90 && remainNumber <= 100){
            System.out.printf(injured_desc[0],g.getName());
        }else if (remainNumber >= 50 && remainNumber <= 90){
            System.out.printf(injured_desc[1],g.getName());
        }else if (remainNumber >= 0 && remainNumber <= 49){
            System.out.printf(injured_desc[2],g.getName());
        }
        System.out.println();

    }
    public void showInfo(){
        System.out.println("姓名为" + getName());
        System.out.println("血量为" + getBlood());
        System.out.println("性别为" + getGender());
        System.out.println("长相为" + getFace());
    }
}
