package stringDemo1;

public class StringDemoTest9 {
    public static void main(String[] args) {
        //敏感词屏蔽
        String talk = "你玩的真好，以后不要再玩了，TMD";

        //定义一个敏感词库
        String[] arr = {"TMD","CNM","MD","SB"};
        for (int i = 0; i < arr.length; i++) {
            talk = talk.replace(arr[i],"***");
        }

        System.out.println(talk);
    }
}
