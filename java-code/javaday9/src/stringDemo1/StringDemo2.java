package stringDemo1;

public class StringDemo2 {
    public static void main(String[] args) {
        String s1 = new String("abc");
        String s2 = "Abc";

        //==号比较
        System.out.println(s2 == s1);//false

        //比较字符串对象中的内容是否相等,必须完全一样
        boolean result1 = s1.equals(s2);
        System.out.println(result1);

        //忽略大小写
        //但是中文的大小写不行，例如一和壹，只能是英文状态下
        boolean result2 = s1.equalsIgnoreCase(s2);
        System.out.println(result2);

    }
}
