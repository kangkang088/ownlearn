package test5;

public class GirlFriendTest {
    public static void main(String[] args) {
        GirlFriend[] girlFriend = new GirlFriend[4];
        GirlFriend girlFriend1 = new GirlFriend("小丽",18,"女");
        GirlFriend girlFriend2 = new GirlFriend("小蜜",19,"女");
        GirlFriend girlFriend3 = new GirlFriend("小小",25,"女");
        GirlFriend girlFriend4 = new GirlFriend("小薇",22,"女");
        girlFriend[0] = girlFriend1;
        girlFriend[1] = girlFriend2;
        girlFriend[2] = girlFriend3;
        girlFriend[3] = girlFriend4;
        int avg = (girlFriend1.getAge() + girlFriend2.getAge() + girlFriend3.getAge() + girlFriend4.getAge()) / 4;
        int count = 0;
        for (int i = 0; i < girlFriend.length; i++) {
            GirlFriend girl = girlFriend[i];
            if (girl.getAge() < avg){
                count++;
            }
            System.out.println("第" + (i + 1) + "位女朋友的名字是：" + girl.getName() + '，' + "年龄是：" + girl.getAge() + '，' + "性别是：" + girl.getGender() + '，' + "爱好是" + girl.getHabits());
        }
        System.out.println("平均年龄是" + avg);
        System.out.println("年龄比平均值低的有" + count + "个");
    }
}
