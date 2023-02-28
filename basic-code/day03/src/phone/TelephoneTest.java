package phone;

public class TelephoneTest {
    public static void main(String[] args) {
        Telephone[] arr = new Telephone[3];
        Telephone t1 = new Telephone("小米",1999,"黑色");
        Telephone t2 = new Telephone("华为",3999,"蓝色");
        Telephone t3 = new Telephone("魅族",4999,"白色");
        arr[0] = t1;
        arr[1] = t2;
        arr[2] = t3;
        int avg = (int)(t1.getPrice() + t2.getPrice() + t3.getPrice()) / arr.length;
        System.out.println(avg);
    }
}
