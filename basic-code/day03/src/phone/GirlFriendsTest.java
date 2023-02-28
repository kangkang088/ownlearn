package phone;

public class GirlFriendsTest {
    public static void main(String[] args) {
        GirlFriends[] arr = new GirlFriends[4];
        GirlFriends gfs1 = new GirlFriends("冰冰",19,"女","打篮球");
        GirlFriends gfs2 = new GirlFriends("陌陌",25,"女","踢足球");
        GirlFriends gfs3 = new GirlFriends("露露",29,"女","打羽毛球");
        GirlFriends gfs4 = new GirlFriends("娜娜",18,"女","看电视");
        arr[0] = gfs1;
        arr[1] = gfs2;
        arr[2] = gfs3;
        arr[3] = gfs4;
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum = sum + arr[i].getAge();
        }
        int avg = 0;
        avg = sum / 4;
        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i].getAge() < avg){
                System.out.println(arr[i].getName() + ',' + arr[i].getAge() + ',' + arr[i].getGender() + ',' + arr[i].getHabit());
            }
        }
    }
}
