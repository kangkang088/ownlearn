package test6;

public class StudentTest_1 {
    public static void main(String[] args) {
        Student[] arr = new Student[3];
        Student stu1 = new Student(1,"zahngsan",22);
        Student stu2 = new Student(2,"lisi",23);
        Student stu3 = new Student(3,"wangwu",24);
        arr[0] = stu1;
        arr[1] = stu2;
        arr[2] = stu3;

        Student stu4 = new Student(4,"zhaoliu",25);
        //定义一个方法，进行学号唯一性判断
        boolean flag = contains(arr, stu4.getId());
        if (flag){
            System.out.println("学生id重复，请修改");
        }else {
            //添加
            //第一种情况，数组满了，创建一个新的数组，再添加
            //定义一个方法判断数组满没满，根据null
            int count = getCount(arr);
            //根据count判断怎么添加
            if (count == arr.length){
                //说明满了
                //要新数组
                //定义一个方法
                Student[] newArr = newCreantArr(arr);
                newArr[count] = stu4;
                //打印信息
                studentInfo(newArr);
                //通过id删除角色信息，并遍历
                //先判断有没有id
                //定义一个方法
                int index1 = index(newArr,4);
                //如果有(>0)，删除
                if (index1 >= 0){
                    newArr[index1] = null;
                    studentInfo(newArr);
                }else {
                    System.out.println("没有这个id，删除失败");
                }
                //再查询id为某一个数字的学生，如果有，则使其年龄+1
                int index3 = index(newArr,3);
                if (index3 >= 0){
                    Student stu = newArr[index3];
                    int age = stu.getAge() + 1;
                    stu.setAge(age);
                }else {
                    System.out.println("当前id不存在");
                }
            }else {
                //第二种情况，数组没满，直接添加
                arr[count] = stu4;
                studentInfo(arr);
                int index2 = index(arr,2);
                if (index2 >= 0){
                    arr[index2] = null;
                    studentInfo(arr);
                }else {
                    System.out.println("删除失败");
                }
                int index4 = index(arr,1);
                if (index4 >= 0){
                    Student stu = arr[index4];
                    int age = stu.getAge() + 1;
                    stu.setAge(age);
                }else {
                    System.out.println("当前id不存在");
                }
            }
        }
    }
    public static int index(Student[] arr,int id){
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != null){
                Student stu = arr[i];
                int sid = stu.getId();
                if (sid == id){
                    return i;
                }
            }
        }
        return -1;
    }
    public static void studentInfo(Student[] arr){
        //打印null会出错
        for (int i = 0; i < arr.length; i++) {
            Student stu = arr[i];
            if (stu != null){
                System.out.println("id是" + stu.getId() + "," + stu.getName() +  "," + stu.getAge());
            }
        }
    }
    public static Student[] newCreantArr(Student[] arr){
        Student[] newArr = new Student[arr.length + 1];
        for (int i = 0; i < arr.length; i++) {
            newArr[i] = arr[i];
        }
        return newArr;
    }
    public static int getCount(Student[] arr){
        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != null){
                count++;
            }
        }
        return count;
    }
    public static boolean contains(Student[] arr,int id){
        for (int i = 0; i < arr.length; i++) {
            Student stu = arr[i];
            if (stu != null){
                int sid = stu.getId();
                if (sid == id){
                    return true;
                }
            }
        }
        return false;
    }
}
