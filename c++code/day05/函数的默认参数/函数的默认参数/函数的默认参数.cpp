#include <iostream>
using namespace std;
void func(const string& message = "我喜欢你")
{
	cout << "亲爱的：" << message << endl;
}
int main()
{
	func("我是一只小小鸟");
	func();//需要指定默认参数
	//声明和定义分开时，在声明中写默认参数
}
