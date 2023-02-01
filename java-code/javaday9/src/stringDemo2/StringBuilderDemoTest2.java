package stringDemo2;

public class StringBuilderDemoTest2 {
    public static void main(String[] args) {
        //定义一个方法，把int数组中的数据按照指定格式拼接成一个字符串返回
        //调用该方法，并在控制台输出结果
        //例如
        //数组为int[] arr = {1,2,3};
        //执行方法后输出的结果为：[1,2,3]

        //1.定义一个int数组
        int[] arr = {1,2,3};

        //2.定义一个方法
        String s = newString(arr);
        System.out.println(s);

    }
    public static String newString(int[] arr){
        StringBuilder sb = new StringBuilder("[");
        for (int i = 0; i < arr.length; i++) {
            if (i < arr.length - 1){
                sb.append(arr[i]).append(",");
            }else {
                sb.append(arr[i]).append("]");
            }
        }
        String s = sb.toString();
        return s;
    }
}
