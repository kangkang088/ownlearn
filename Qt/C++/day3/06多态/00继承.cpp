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
//        m_a = 10;//��������Ȼ�ǹ���Ȩ��
//        m_b = 20;//��������Ȼ�Ǳ���Ȩ��
//        //m_c = 30;//���ɷ��ʸ���˽�г���
//    }
//};
//void test1()
//{
//    Son1 son1;
//    son1.m_a = 100;//��������Ȼ�ǹ���Ȩ��
//    //son1.m_b = 200;//��������Ȼ�Ǳ���Ȩ�ޣ�������ʲ���
//}
//class Son2 :protected Base
//{
//    void func()
//    {
//        m_a = 100;//�����б�Ϊ����Ȩ��
//        m_b = 100;//��������Ȼ�Ǳ���Ȩ��
//        //m_c = 200;//���ɷ��ʸ���˽�г�Ա
//    }
//};
//void test2()
//{
//    Son2 son2;
//    //son2.m_a = 100;//�����б�Ϊ����Ȩ��
//    //son2.m_b = 200;//��������Ȼ�Ǳ���Ȩ��
//}
//class Son3 :private Base
//{
//    void func()
//    {
//        m_a = 12;//�����б�Ϊ˽��Ȩ��
//        m_b = 12;//�����б�Ϊ˽��Ȩ��
//        //m_c = 12;//���ɷ��ʸ���˽�г�Ա
//
//    }
//};
//void test3()
//{
//    Son3 son3;
//    //son3.m_a = 100;//�����б�Ϊ˽��Ȩ��
//    //son3.m_b = 100;//�����б�Ϊ˽��Ȩ��
//}
//class GrandSon :public Son3
//{
//    //m_a = 100;//����Son3�е��Ѿ���Ϊ˽�г�Ա��
//};
//int main()
//{
//    
//}