package phone;

public class StudentsTest {
    public static void main(String[] args) {
        Students[] arr = new Students[3];
        Students stu1 = new Students(1,"张三",23);
        Students stu2 = new Students(2,"李四",24);
        //Students stu3 = new Students(3,"王五",25);
        arr[0] = stu1;
        arr[1] = stu2;
        //arr[2] = stu3;
        Students stu4 = new Students(4,"赵六",26);
        boolean flag = true;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != null) {
                if (stu4.getId() == arr[i].getId()) {
                    flag = false;
                }
            }
        }
        if (flag){

            int count = getCount(arr);
            if (count == arr.length){
                //1.数组存满
                Students[] newArr = creatNewArr(arr);
                newArr[count] = stu4;
                printArr(newArr);
                int index = getIndex(newArr,2);
                if (index >= 0){
                    newArr[index] = null;
                }else {
                    System.out.println("id不存在");
                }
                printArr(newArr);
            }else {
                //2.数组没存满
                //count其实就是该从下一个位置添加的该位置索引
                arr[count] = stu4;
                printArr(arr);
                int index = getIndex(arr,2);
                if (index >= 0){
                    arr[index] = null;
                }else {
                    System.out.println("id不存在");
                }
                printArr(arr);
            }


        }else {
            System.out.println("当前id重复");
        }
    }
    public static int getIndex(Students[] arr,int id){
        for (int i = 0; i < arr.length; i++) {
            Students stu = arr[i];
            if (stu != null){
                int sid = stu.getId();
                if (sid == id){
                    return i;
                }
            }
        }
        return -1;
    }
    public static void printArr(Students[] arr){
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != null){
                System.out.println(arr[i].getId() + arr[i].getName() + ',' + arr[i].getAge());
            }
        }
    }
    public static Students[] creatNewArr(Students[] arr){
        Students[] newArr = new Students[arr.length + 1];
        for (int i = 0; i < arr.length; i++) {
            newArr[i] = arr[i];
        }
        return newArr;
    }
    public static int getCount(Students[] arr){
        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != null){
                count++;
            }
        }
        return count;
    }
}
