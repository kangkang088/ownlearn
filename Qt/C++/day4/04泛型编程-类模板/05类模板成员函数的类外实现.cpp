//#include <iostream>
//#include <fstream>
//using namespace std;
//
//template <class T1,class T2>
//class Person
//{
//public:
//    //���캯������shixian
//    Person(T1 name, T2 age);
//  /*  {
//        this->m_name = name;
//        this->m_age = age;
//    }*/
//    void showPerson();
//   /* {
//        cout << "������" << this->m_name << "," << "���䣺" << this->m_age << endl;
//    }*/
//    T1 m_name;
//    T2 m_age;
//};
////��ģ���Ա��������ʵ��
//template<class T1,class T2>
//Person<T1, T2>::Person(T1 name, T2 age)
//{
//    this->m_name = name;
//    this->m_age = age;
//}
//
////�����Ա����û���õ�������ҲҪ��������,ָ��������ģ��ĳ�Ա����
//template <class T1,class T2>
//void Person<T1, T2>::showPerson()
//{
//    cout << "������" << this->m_name << "," << "���䣺" << this->m_age << endl;
//}
//void test1()
//{
//    Person<string, int> p("Tom", 18);
//    p.showPerson();
//}
//int main()
//{
//    test1();
//}