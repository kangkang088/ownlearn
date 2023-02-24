package stringJoinerDemo;

import java.util.StringJoiner;

public class StringJoinerDemo2 {
    public static void main(String[] args) {
        //1.
        StringJoiner sj = new StringJoiner("---","[","]");
        sj.add("aaa").add("bbb").add("ccc");
        System.out.println(sj);

        int length = sj.length();
        System.out.println(length);

        String s = sj.toString();
        System.out.println(s);
    }
}
