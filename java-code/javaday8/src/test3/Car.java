package test3;

public class Car {
    private String name;
    private double price;
    private String color;
    public Car(){

    }
    public Car(String name,double price,String color){
        this.name = name;
        this.price = price;
        this.color = color;
    }
    public void setName(String name){
        this.name = name;
    }
    public String getName(){
        return name;
    }
    public void setPrice(double price){
        this.price = price;
    }
    public double getPrice(){
        return price;
    }
    public void setColor(String color){
        this.color = color;
    }
    public String getColor(){
        return color;
    }
}
