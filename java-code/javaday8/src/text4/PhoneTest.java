package text4;

import java.util.Scanner;

public class PhoneTest {
    public static void main(String[] args) {
        Phone[] phones = new Phone[3];

        //用键盘录入手机信息
        //再求出三部手机的平均价格
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < phones.length; i++) {
            Phone phone = new Phone();
            System.out.println("请录入第" + (i + 1) + "部手机的价格");
            double price = sc.nextDouble();
            phone.setPrice(price);
            phones[i] = phone;
        }
        double sum = 0;
        for (int i = 0; i < phones.length; i++) {
            Phone phone = phones[i];
            sum = sum + phone.getPrice();
        }
        double avg = sum / phones.length;
        System.out.println("三部手机的平均价格为：" + avg);
    }
}
