package stringDemo2;

public class StringBuilderDemo1_1 {
    public static void main(String[] args) {
        StringBuilder sb = new StringBuilder();

        sb.append("aaa");
        sb.append("bbb");
        sb.append("ccc");
        sb.append("ddd");

        //StringBuilder只是一个容器，需要变回字符串
        String str = sb.toString();
        System.out.println(str);
    }
}
