#include <iostream>
#include <fstream>
#include "08MyArray.hpp"
using namespace std;

void printIntArray(MyArray<int>& arr)
{
	for (int i = 0; i < arr.getSize(); i++)
	{
		cout << arr[i] << endl;
	}
}
void test1()
{
	MyArray<int> arr1(5);
	for (int i = 0; i < 5; i++)
	{
		//利用尾插法向数组中插入数据
		arr1.pushBack(i);
	}
	cout << "arr1中数组中的数据：" << endl;
	printIntArray(arr1);
	cout << "arr1的容量是：" << arr1.getCapacity() << endl;
	cout << "arr1的大小是：" << arr1.getSize() << endl;
	
	MyArray<int> arr2(arr1);
	cout << "arr2中数组中的数据：" << endl;
	printIntArray(arr2);

	//尾删
	arr2.popBack();
	cout << "arr2尾删后：" << endl;
	cout << "arr2的容量是：" << arr2.getCapacity() << endl;
	cout << "arr2的大小是：" << arr2.getSize() << endl;
	/*MyArray<int> arr3(100);
	arr3 = arr2;*/
}
//测试自定义数据类型
class Person
{

public:
	Person() {}
	Person(string name, int age)
	{
		this->m_name = name;
		this->m_age = age;
	}
	string m_name;
	int m_age;
};
void printPerson(MyArray<Person>& arr)
{
	for (int i = 0; i < arr.getSize(); i++)
	{
		cout << "姓名：" << arr[i].m_name << endl;
		cout << "年龄：" << arr[i].m_age << endl;
	}
}
void test2()
{
	MyArray<Person> arr(10);
	Person p1("孙悟空", 10000);
	Person p2("韩信", 20);
	Person p3("妲己", 2000);
	Person p4("赵云", 25);
	Person p5("刘邦", 35);

	//插入
	arr.pushBack(p1);
	arr.pushBack(p2);
	arr.pushBack(p3);
	arr.pushBack(p4);
	arr.pushBack(p5);
	//打印
	printPerson(arr);
	//容量
	cout << "自定义类型的arr容量：" << arr.getCapacity() << endl;
	cout << "自定义类型的arr大小：" << arr.getSize() << endl;
	//大小
}
int main()
{

	//test1();
	test2();
}