//#include <iostream>
//#include <fstream>
//using namespace std;
//
//template <class T1=string,class T2 = int>
//class Person
//{
//public:
//    Person(T1 name, T2 age)
//    {
//        this->m_name = name;
//        this->m_age = age;
//    }
//    void showPerson()
//    {
//        cout << "name:" << this->m_name << "," << "age:" << this->m_age << endl;
//    }
//    T1 m_name;
//    T2 m_age;
//};
////1.��ģ��û���Զ������Ƶ�
//void test1()
//{
//    //Person p("�����", 18);//�����޷��Զ������Ƶ�
//    Person<string, int> p("�����", 18);//ֻ���þ��廯
//    p.showPerson();
//}
//
////2.��ģ����ģ������б��п�����Ĭ�ϲ���
//void test2()
//{
//    Person<> p("��˽�", 19);
//    p.showPerson();
//}
//int main()
//{
//    test1();
//    test2();
//}