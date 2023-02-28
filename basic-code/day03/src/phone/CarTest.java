package phone;

import java.util.Scanner;

public class CarTest {
    public static void main(String[] args) {
        Car[] arr = new Car[3];
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < arr.length; i++) {
            System.out.print("请输入第" + (i + 1) + "辆汽车的品牌：");
            String brand = sc.next();
            System.out.print("请输入第" + (i + 1) + "辆汽车的价格：");
            double price = sc.nextDouble();
            System.out.print("请输入第" + (i + 1) + "辆汽车的颜色：");
            String color = sc.next();
            Car c = new Car(brand,price,color);
            arr[i] = c;
        }
        for (int i = 0; i < arr.length; i++) {
            System.out.println("第" + (i+1) + "辆车的信息位" + arr[i].getBrand() + arr[i].getPrice() + arr[i].getColor());

        }

    }
}
