//#include <iostream>
//#include <fstream>
//using namespace std;
//
////1.��ǰ�ñ�����֪����Ĵ��ڣ�������溯������������
//template<class T1, class T2>
//class Person;
//
////2.��ǰ�ú���֪��ȫ�ֺ����Ĵ��� �������ඨ������棬����Ҫ1.����������������������
//template<class T1, class T2>
////��Ϊ��ȫ�ֺ��������Ժ�����ǰ��ʲôҲ����
////����Ϊ��������ģ���������Ҫ�����template����
//void printPerson2(Person<T1, T2> p)
//{
//    cout << "����������" << p.m_name << endl;
//    cout << "�������䣺" << p.m_age << endl;
//}
//
//template<class T1,class T2>
//class Person
//{
//    //ȫ�ֺ��� ����ʵ��
//    friend void printPerson(Person<T1,T2> p)
//    {
//        cout << "������" << p.m_name << endl;
//        cout << "���䣺" << p.m_age << endl;
//    }
//    //ȫ�ֺ��� ����ʵ��
//    //��һ����ģ������б���Ϊȫ�ֺ�������template�����ﺯ��������Ҫ��һ��<>
//    //3.ȫ�ֺ���������ʵ�֣���Ҫ�ñ�������ǰ֪���������� 2.�����
//    friend void printPerson2<>(Person<T1, T2> p);
//public:
//    Person(T1 name, T2 age)
//    {
//        this->m_name = name;
//        this->m_age = age;
//    }
//private:
//    T1 m_name;
//    T2 m_age;
//};
//void test1()
//{
//    Person<string, int> p("Tom", 20);
//    printPerson(p);
//}
//void test2()
//{
//    Person<string, int> p("Jerry", 18);
//    printPerson2(p);
//}
//int main()
//{
//    test1();
//    test2();
//}