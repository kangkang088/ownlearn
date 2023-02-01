package stringDemo1;

public class StringDemoTest7 {
    public static void main(String[] args) {
        //11位手机号
        //屏蔽中间四位
        String phoneNumber = "17333837785";
        String s1 = "";
        for (int i = 0; i < 3; i++) {
            char c = phoneNumber.charAt(i);
            s1 = s1 + c;
        }
        for (int i = 3; i < 7; i++) {
            char c = phoneNumber.charAt(i);
            c = '*';
            s1 = s1 + c;
        }
        for (int i = 7; i < phoneNumber.length(); i++) {
            char c = phoneNumber.charAt(i);
            s1 = s1 + c;
        }
        System.out.println(s1);
    }
}
