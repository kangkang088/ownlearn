//#include <iostream>
//using namespace std;
//
//class Base
//{
//public:
//    int m_a;
//protected:
//    int m_b;
//private:
//    int m_c;
//};
//class Son1 :public Base
//{
//public:
//    void func()
//    {
//        m_a = 10;//子类中依然是公共权限
//        m_b = 20;//子类中依然是保护权限
//        //m_c = 30;//不可访问父类私有成岩
//    }
//};
//void test1()
//{
//    Son1 son1;
//    son1.m_a = 100;//子类中依然是公共权限
//    //son1.m_b = 200;//子类中依然是保护权限，类外访问不到
//}
//class Son2 :protected Base
//{
//    void func()
//    {
//        m_a = 100;//子类中变为保护权限
//        m_b = 100;//子类中依然是保护权限
//        //m_c = 200;//不可访问父类私有成员
//    }
//};
//void test2()
//{
//    Son2 son2;
//    //son2.m_a = 100;//子类中变为保护权限
//    //son2.m_b = 200;//子类中依然是保护权限
//}
//class Son3 :private Base
//{
//    void func()
//    {
//        m_a = 12;//子类中变为私有权限
//        m_b = 12;//子类中变为私有权限
//        //m_c = 12;//不可访问父类私有成员
//
//    }
//};
//void test3()
//{
//    Son3 son3;
//    //son3.m_a = 100;//子类中变为私有权限
//    //son3.m_b = 100;//子类中变为私有权限
//}
//class GrandSon :public Son3
//{
//    //m_a = 100;//父类Son3中的已经变为私有成员了
//};
//int main()
//{
//    
//}