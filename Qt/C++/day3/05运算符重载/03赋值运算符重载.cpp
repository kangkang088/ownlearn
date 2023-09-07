//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//    Person(int age)
//    {
//        this->m_age = new int(age);
//    }
//    ~Person()
//    {
//        if (m_age != NULL)
//        {
//            delete m_age;
//            m_age = NULL;
//        }
//        
//    }
//    Person& operator= (Person& p)
//    {
//        if (m_age!=NULL)
//        {
//            delete m_age;
//            m_age = NULL;
//        }
//        this->m_age = new int(*p.m_age);
//        return *this;
//    }
//    int* m_age;
//
//};
//void test1()
//{
//    Person p1(18);
//    Person p2(20);
//    p2 = p1;
//    cout << *p1.m_age << endl;
//    cout << *p2.m_age << endl;
//}
//int main()
//{
//    test1();
//}