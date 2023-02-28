package phone;

import java.util.Random;

public class Role {
    private String name;
    private  int blood;
    private String face;
    private char gender;
    String[] boyFaces = {"气宇轩昂","风流倜傥","英俊潇洒","猥琐"};
    String[] girlFaces = {"倾国倾城","美奂绝伦","性感妩媚","丑陋"};
    String[] attacks = {
            "%s使出了一招背心钉，转到对方身后，一掌向%s的灵台穴拍去",
            "%s使出了一招贴心掌，转到对方身旁，一脚向%s的侧腰踢去"
    };
    String[] injures = {
            "结果%s后退了一步，造成了一处瘀伤",
            "结果%s脸色一下变得惨白，连退了好几步",
            "结果%s大吐一口鲜血，倒了下去"
    };
    public String getFace() {
        return face;
    }

    public void setFace(char gender) {
        Random r = new Random();
        if(gender == '男'){
            int index = r.nextInt(boyFaces.length);
            this.face = boyFaces[index];
        }else if (gender == '女'){
            int index = r.nextInt(girlFaces.length);
            this.face = girlFaces[index];
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

    public Role() {
    }

    public Role(String name, int blood,char gender) {
        this.name = name;
        this.blood = blood;

        this.gender = gender;
        setFace(gender);
    }

    /**
     * 获取
     * @return name
     */
    public String getName() {
        return name;
    }

    /**
     * 设置
     * @param name
     */
    public void setName(String name) {
        this.name = name;
    }

    /**
     * 获取
     * @return blood
     */
    public int getBlood() {
        return blood;
    }

    /**
     * 设置
     * @param blood
     */
    public void setBlood(int blood) {
        this.blood = blood;
    }
    public void attack(Role role){
        Random r = new Random();
        int index = r.nextInt(attacks.length);
        String kungFu = attacks[index];
        System.out.printf(kungFu,this.getName(),role.getName());
        System.out.println();
        int hurt = r.nextInt(20) + 1;
        int remainBlood = role.getBlood() - hurt;
        remainBlood = remainBlood < 0 ? 0 : remainBlood;
        role.setBlood(remainBlood);
        //System.out.println(this.getName() + "举起拳头打了" + role.getName() + "一下，造成了" + hurt + "点伤害，" + role.getName() + "还剩下" + remainBlood + "点血");
        if (remainBlood >=80 && remainBlood <100){
            System.out.printf(injures[0],role.getName());
        }else if (remainBlood >= 30 && remainBlood < 80){
            System.out.printf(injures[1],role.getName());
        }else {
            System.out.printf(injures[2],role.getName());
        }
        System.out.println();
    }
    public void gamerInfo(){
        System.out.println(getName());
        System.out.println(getBlood());
        System.out.println(getGender());
        System.out.println(getFace());
    }
}
