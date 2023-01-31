package test3;

import java.util.Scanner;

public class CarTest {
    public static void main(String[] args) {
        Car[] cars = new Car[3];

        //创建汽车对象，数据来自键盘录入
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < cars.length; i++) {
            Car c = new Car();
            System.out.println("请录入汽车的品牌");
            String name = sc.next();
            c.setName(name);
            System.out.println("请输入汽车的价格");
            double price = sc.nextDouble();
            c.setPrice(price);
            System.out.println("请输入汽车的颜色");
            String color = sc.next();
            c.setColor(color);

            //把汽车对象放入数组
            cars[i] = c;
        }

        for (int i = 0; i < cars.length; i++) {
            Car c = cars[i];
            System.out.println(c.getName() + ',' + c.getPrice() + ',' + c.getColor());
        }
    }
}
