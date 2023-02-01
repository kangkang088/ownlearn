package stringDemo;

public class StringDemoTest4 {
    public static void main(String[] args) {
        //定义一个方法，把int数组中的数据按照指定格式拼接成一个字符串返回
        //调用该方法，并输出结果
        //例如：
        //数组为int[] arr = {1,2,3};
        //执行方法后，输出结果为[1，2，3]

        int[] arr = {1,2,3};

        String s = stringReturn(arr);
        System.out.println(s);



    }
    public static String stringReturn(int[] arr){
        if (arr == null){
            return "";
        }
        if (arr.length == 0){
            return "[]";
        }
        String str = "[";
        for (int i = 0; i < arr.length; i++) {
            if (i < arr.length - 1) {
                str = str + arr[i] + ",";
            }else {
                str = str + arr[i] + "]";
            }
        }
        return str;
    }
}
