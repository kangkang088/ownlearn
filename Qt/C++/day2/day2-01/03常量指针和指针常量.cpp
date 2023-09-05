//#include <iostream>
//using namespace std;
//
//int main()
//{
//	//常量指针
//	//指向的值不可以改变，指针的值可以改变使其指向别的地方（不建议，可能造成内存泄露）
//	int a = 10;
//	int aa = 100;
//	const int* p = &a;
//	p = &aa;
//	cout << *p << endl;
//	//指针常量
//	//指针指向的内存的地址（即指针值）不可以改变，指向内存的内容可以改变
//	int b = 20;
//	int* const pp = &b;
//	*pp = 200;
//	cout << b << endl;
//}