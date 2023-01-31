package test6;

public class StudentTest {
    public static void main(String[] args) {
        Student[] arr = new Student[3];
        Student stu1 = new Student(2,"张三",23);
        Student stu2 = new Student(3,"李四",24);
        Student stu3 = new Student(4,"王五",25);
        arr[0] = stu1;
        arr[1] = stu2;
        arr[2] = stu3;
        //1.
        Student stu4 = new Student(1,"赵六",26);
        //唯一性判断，写在添加的前面
        //重复，不用添加
        //不重复，添加
        boolean flag = contains(arr, stu4.getId());
        if (flag){
            System.out.println("当前id重复，请修改id后再进行添加");
        }else {
            //添加到数组
            //数组已经存满，创建一个新的数组
            //数组没有存满，直接添加
            int count = getCount(arr);
            if (count == arr.length){
                //已经存满
                //写一个方法，长度=老数组长度+1
                Student[] newArr = creantNewArr(arr);
                newArr[count] = stu4;
                print(newArr);
                int index1 = getIndex(newArr,4);
                if (index1 >= 0){
                    //存在这个id，要删除相应的学生信息
                    newArr[index1] = null;
                    //删除完了再遍历
                    print(newArr);
                }else {
                    //不存在，不用删除
                    System.out.println("删除失败");
                }
                int index3 = getIndex(newArr,2);
                if (index3 >= 0){
                    Student stu = newArr[index3];
                    int age = stu.getAge() + 1;
                    stu.setAge(age);
                    System.out.println(age);
                }else {
                    System.out.println("当前id不存在");
                }
            }else {
                //没有存满
                arr[count] = stu4;
                print(arr);
                int index2 = getIndex(arr,2);
                if (index2 >= 0){
                    arr[index2] = null;
                    //删除完了再遍历
                    print(arr);
                }else {
                    System.out.println("删除失败");
                }
                int index4 = getIndex(arr,1);
                if (index4 >= 0){
                    Student stu = arr[index4];
                    int age = stu.getAge() + 1;
                    stu.setAge(age);
                    System.out.println(age);
                }else {
                    System.out.println("当前id不存在");
                }
            }
        }
    }
    ////写一个方法，长度=老数组长度+1
    public static Student[] creantNewArr(Student[] arr){
        Student[] newArr = new Student[arr.length + 1];
        for (int i = 0; i < arr.length; i++) {
            newArr[i] = arr[i];
        }
        return newArr;
    }
    //定义一个方法，判断数组中已经存了几个元素
    public static int getCount(Student[] arr){
        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != null){
                count++;
            }
        }
        return count;
    }
    //定义一个方法，唯一性判断
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

    //2.添加完毕后，遍历所有学生信息
    //两种情况，一种是没有新数组建立
    //一种是有新数组建立
    public static void print(Student[] arr){
        for (int i = 0; i < arr.length; i++) {
            Student stu = arr[i];
            if (stu != null){
                System.out.println("id是" + stu.getId() + '，' +  stu.getName() +'，' +  stu.getAge());
            }
        }
    }

    //3.通过id删除学生信息，存在就删除，不存在就不删除
    public static int getIndex(Student[] arr,int id){
        for (int i = 0; i < arr.length; i++) {
            Student stu = arr[i];
            if (stu != null){}
            int sid = stu.getId();
            if(sid == id){
                return i;
            }
        }
        return -1;
    }

    //4.查询数组id为2的学生，如果有，年龄+1
    //通过getIndex就可以

}
