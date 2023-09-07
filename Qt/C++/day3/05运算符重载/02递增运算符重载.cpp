//#include <iostream>
//using namespace std;
//
//class MyInteger
//{
//	friend ostream& operator<< (ostream& cout, MyInteger myInt);
//public:
//	MyInteger()
//	{
//		this->m_num = 0;
//	}
//	//重载++
//	//前置和后置
//	//1.前置
//	MyInteger& operator++ ()
//	{
//		this->m_num++;
//		return *this;
//	}
//	//2.后置
//	MyInteger operator++ (int)
//	{
//		MyInteger temp = *this;
//		this->m_num++;
//		return temp;
//	}
//private:
//	int m_num;
//};
//ostream& operator<< (ostream& cout, MyInteger myInt)
//{
//	cout << ++(++myInt.m_num) << endl;
//	cout << myInt.m_num++ << endl;
//	cout << myInt.m_num << endl;
//	return cout;
//}
//void test1()
//{
//	MyInteger myInteger;
//	cout << myInteger << endl;
//}
//int main()
//{
//	test1();
//}