package stringDemo;

public class StringDemo1 {
    public static void main(String[] args) {
        //1.直接赋值的方式获取字符串
        String s1 = "abc";
        System.out.println(s1);

        //2.new的方式
        //空参构造
        String s2 = new String();
        System.out.println(s2);

        //传递一个字符串，根据传递的字符串内容创建一个新的字符串对象
        String s3 = new String("abc");
        System.out.println(s3);

        //传递一个字符数组
        //应用场景：字符串内容不可改变，但我们可以先通过改变数组内容的方式，再传递过去，实现更改
        char[] chs = {'a','b','c'};
        String s4 = new String(chs);
        System.out.println(s4);

        //传递字节数组
        //网络中传递的数据都是字节信息
        //一般要把字节信息进行转换，转成字符串
        byte[] bytes = {97,98,99,100};//先通过数字在ASCII码表中找到对应字母，再拼接
        String s5 = new String(bytes);
        System.out.println(s5);//abcd
    }
}
