//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//    int m_age;
//    Person()
//    {
//        cout << "person()���캯���ĵ���" << endl;
//    }
//    Person(int a)
//    {
//        this->m_age = a;
//        cout << "person(int)���캯���ĵ���" << endl;
//    }
//    //�������캯��
//    Person(const Person &p)
//    {
//        this->m_age = p.m_age;
//        cout << "�����˿������캯��" << endl;
//    }
//    ~Person()
//    {
//        cout << "person���������ĵ���" << endl;
//    }
//};
//int main()
//{
//    //���ŷ�
//    Person p;//Ĭ�Ϲ��캯���ĵ��ã���Ҫ�ӣ�������Ȼ�ɺ��������ˣ���Ҫ�ã���Person p = Person().
//    Person p2(10);//���ŷ����вε�
//    Person p3(p2);
//    //��ʾ��
//    Person p4 = Person();
//    Person p5 = Person(5);
//    //��ʽת����
//    Person p6 = 10;
//}