//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//    Person()
//    {
//        cout << "Person��Ĭ�Ϲ��캯��" << endl;
//    }
//    Person(int age,int height)
//    {
//        this->m_age = age;
//        this->m_height = new int(height);
//        cout << "Person���вι��캯��" << endl;
//    }
//    //���ǳ����
//    Person(const Person& p)
//    {
//        cout << "Person�Ŀ������캯��" << endl;
//        this->m_age = p.m_age;
//        //���
//        this->m_height = new int(*p.m_height);
//    }
//    ~Person()
//    {
//        if (m_height != NULL)
//        {
//            delete m_height;
//            m_height = NULL;
//        }
//        cout << "Person����������" << endl;
//    }
//    int m_age;
//    int* m_height;
//};
//void test1()
//{
//    Person p1(18,160);
//    cout << "p1������Ϊ��" << p1.m_age << "����ǣ�" << *(p1.m_height) << endl;
//    //ǳ�����������ڴ�����ظ��ͷŵ�Υ������
//    Person p2(p1);
//    cout << "p2������Ϊ��" << p2.m_age << "����ǣ�" << *(p2.m_height) << endl;
//}
//int main()
//{
//    test1();
//}