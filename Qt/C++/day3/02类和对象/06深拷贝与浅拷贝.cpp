//#include <iostream>
//using namespace std;
//
//class Person
//{
//public:
//    Person()
//    {
//        cout << "Person的默认构造函数" << endl;
//    }
//    Person(int age,int height)
//    {
//        this->m_age = age;
//        this->m_height = new int(height);
//        cout << "Person的有参构造函数" << endl;
//    }
//    //解决浅拷贝
//    Person(const Person& p)
//    {
//        cout << "Person的拷贝构造函数" << endl;
//        this->m_age = p.m_age;
//        //深拷贝
//        this->m_height = new int(*p.m_height);
//    }
//    ~Person()
//    {
//        if (m_height != NULL)
//        {
//            delete m_height;
//            m_height = NULL;
//        }
//        cout << "Person的析构函数" << endl;
//    }
//    int m_age;
//    int* m_height;
//};
//void test1()
//{
//    Person p1(18,160);
//    cout << "p1的年龄为：" << p1.m_age << "身高是：" << *(p1.m_height) << endl;
//    //浅拷贝，存在内存堆区重复释放的违法操作
//    Person p2(p1);
//    cout << "p2的年龄为：" << p2.m_age << "身高是：" << *(p2.m_height) << endl;
//}
//int main()
//{
//    test1();
//}