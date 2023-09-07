//#include <iostream>
//using namespace std;
//
//class Base1
//{
//public:
//    int m_a;
//    Base1()
//    {
//        this->m_a = 100;
//    }
//};
//class Base2
//{
//public:
//    int m_a;
//    Base2()
//    {
//        this->m_a = 200;
//    }
//};
//class Son:public Base1,public Base2
//{
//public:
//    Son()
//    {
//        this->m_a = 300;
//        this->m_d = 400;
//    }
//    int m_a;
//    int m_d;
//};
//void test1()
//{
//    Son son;
//    cout << sizeof(son) << endl;
//    cout << "Son中的m_a = " << son.Son::m_a << endl;
//    cout << "Base1中的m_a = " << son.Base1::m_a << endl;
//    cout << "Base2中的m_a = " << son.Base2::m_a << endl;
//}
//int main()
//{
//    test1();
//}