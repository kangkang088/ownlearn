package stringJoinerDemo;

public class StringJoinerDemo3 {
    public static void main(String[] args) {

        //容量:最多装多少
        //长度：已经装了多少

        StringBuilder sb = new StringBuilder();
        System.out.println(sb.length());
        System.out.println(sb.capacity());


        sb.append("abcdefghijklmnopqrstuvwxyz0123456789");
        System.out.println(sb.length());
        System.out.println(sb.capacity());

    }
}
