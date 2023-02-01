package stringDemo1;

public class StringDemoTest7_1 {
    public static void main(String[] args) {
        String phoneNumber = "17333837785";
        String str1 = phoneNumber.substring(0,3);
        System.out.println(str1);
        String str2 = phoneNumber.substring(7,11);
        System.out.println(str2);
        int count = phoneNumber.length() - str1.length() - str2.length();
        String str3 = "";
        for (int i = 0; i < count; i++) {
           str3 = str3 + '*';
        }
        System.out.println(str3);
        System.out.println(str1 + str3 + str2);
    }
}
