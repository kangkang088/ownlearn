package girlFriend;

public class GirlFriend {

    private int age;
    //赋值
    public void setAge(int age){
        if (age >= 18 && age <= 50){
            this.age = age;
        }else {
            System.out.println("年龄不合法");
        }
    }
    //返回
    public int getAge(){
        return age;
    }
    private String name;

    public void setName(String b){
        name = b;
    }

    public String getName(){
        return name;
    }
    private double height;

    public void setHeight(double c){
        if (c >= 1.60 && c <= 1.75){
            height = c;
        }else {
            System.out.println("身高不合法");
        }
    }

    public double getHeight(){
        return height;
    }
    private double weight;

    public void setWeight(double d){
        if (d >= 90.0 && d <= 110.0){
            weight = d;
        }else {
            System.out.println("体重不合法");
        }
    }

    public double getWeight(){
        return weight;
    }
    public void sleep(){
        System.out.println("睡觉");
    }
    public void playGame(){
        System.out.println("打游戏");
    }
    //构造方法，省略set
    public GirlFriend(){

    }
    public GirlFriend(int age,String name,double weight,double height){
        this.age = age;
        this.name = name;
        this.weight = weight;
        this.height = height;
    }
}
