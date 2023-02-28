package phone;

public class GirlFriend {
    private String name;
    public void setName(String name){
        this.name = name;
    }
    public String getName(){
        return name;
    }
    private int age;
    public void setAge(int age){
        if (age >= 18 && age <= 50){
            this.age = age;
        }else {
            System.out.println("非法参数");
        }
    }
    public int getAge(){
        return age;
    }
    private double weight;
    public void setWeight(double weight){
        this.weight = weight;
    }
    public double getWeight(){
        return weight;
    }
    private double height;
    public void setHeight(double height){
        this.height = height;
    }
    public double getHeight(){
        return height;
    }
    public void playGame(){
        System.out.println("女朋友在打游戏");
    }
    public void study(){
        System.out.println("打完游戏去学习");
    }
    public void sleep(){
        System.out.println("学习完去睡觉");
    }
}
