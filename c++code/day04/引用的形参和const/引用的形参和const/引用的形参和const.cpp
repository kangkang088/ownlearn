#include <iostream>
using namespace std;
void func1(const int no, const string str)
{
	
	cout << "亲爱的" << no << "号：" << str << endl;
}
void func2(const int* no,const string* str)
{
	
	cout << "亲爱的" << *no << "号：" << *str << endl;
}
void func3(const int& no,const string& str)
{
	
	cout << "亲爱的" << no << "号：" << str << endl;
}
void weiwei(int a)
{
	cout << "我喜欢你" << a << endl;
}
void biaobaishenqi(void(*p)(int))
{
	int a = 4;
	p(a);
}
int main()
{
	int bh = 3;
	string message = "我是一只傻傻鸟";
	func1(bh, message);  //传值
	//func2(8, "我是一只小小鸟");  //传地址，不能用常量，函数形参加const也不行
	func3(8, "我是一只小小鸟");  //传引用，引用是const，可以传常量，相当于先int a = 8，再int& ra = a；等于一步const int& ra
	cout << "亲爱的" << bh << "号：" << message << endl;
	biaobaishenqi(weiwei);
	void(*p)(int);
	p = weiwei;
	(*p)(bh);
}