//#include <iostream>
//#include <fstream>
//#include <string>
//using namespace std;
//
//void test1()
//{
//	ifstream is;
//	is.open("text.txt", ios::in);
//	if (!is.is_open())
//	{
//		cout << "打开失败" << endl;
//		return;
//	}
//	//读文件
//	//1.
//	/*char buffer[1024] = { 0 };
//	while (is>>buffer)
//	{
//		cout << buffer << endl;
//	}*/
//
//	//2.
//	/*char buffer[1024] = { 0 };
//	while (is.getline(buffer,sizeof(buffer)))
//	{
//		cout << buffer << endl;
//	}*/
//
//	//3.
//	//string str;
//	//while (getline(is,str))
//	//{
//	//	cout << str << endl;
//	//}
//
//	//4
//	/*char c;
//	while ((c=is.get())!=EOF)
//	{
//		cout << c;
//	}*/
//}
//int main()
//{
//	test1();
//}