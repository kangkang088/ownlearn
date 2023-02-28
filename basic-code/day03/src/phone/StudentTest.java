package phone;

public class StudentTest {
    public static void main(String[] args) {
        Student s = new Student();
        Student s1 = new Student("张三",23);
        System.out.println(s1.getAge());
        System.out.println(s1.getName());
    }
}
