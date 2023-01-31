package test5;

import java.util.Random;

public class GirlFriend {
    private String name;
    private int age;
    private String gender;
    private String habits;
    String[] habit_desc = {
            "看书",
            "学习",
            "打游戏"
    };


    public GirlFriend() {
    }

    public GirlFriend(String name, int age, String gender) {
        this.name = name;
        this.age = age;
        this.gender = gender;
        setHabits(habit_desc);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getHabits() {
        return habits;
    }
    Random r = new Random();
    public void setHabits(String[] habits) {
        int index = r.nextInt(habits.length);
        this.habits = habits[index];
    }
}
