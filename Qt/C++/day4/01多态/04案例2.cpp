//#include <iostream>
//using namespace std;
//
//class AbstractDrink
//{
//public:
//    virtual void boil() = 0;
//    virtual void brew() = 0;
//    virtual void pourInCup() = 0;
//    virtual void addSomethingInCup() = 0;
//    virtual void makeDrink()
//    {
//        boil();
//        brew();
//        pourInCup();
//        addSomethingInCup();
//    }
//};
//class Coffee :public AbstractDrink
//{
//    virtual void boil()
//    {
//        cout << "��ũ��ɽȪˮ" << endl;
//    }
//    virtual void brew()
//    {
//        cout << "���뿧��" << endl;
//    }
//    virtual void pourInCup()
//    {
//        cout << "���ȵ��뱭��" << endl;
//    }
//    virtual void addSomethingInCup()
//    {
//        cout << "�ӵ��Ǻ�ţ��" << endl;
//    }
//};
//class Tea :public AbstractDrink
//{
//    virtual void boil()
//    {
//        cout << "��ˮ" << endl;
//    }
//    virtual void brew()
//    {
//        cout << "�����Ҷ" << endl;
//    }
//    virtual void pourInCup()
//    {
//        cout << "��Ҷ���뱭��" << endl;
//    }
//    virtual void addSomethingInCup()
//    {
//        cout << "�ӵ����" << endl;
//    }
//};
//void doWork(AbstractDrink* abs)
//{
//    abs->makeDrink();
//    delete abs;
//}
//void test1()
//{
//    doWork(new Coffee);
//}
//void test2()
//{
//    doWork(new Tea);
//}
//int main()
//{
//    test1();
//    test2();
//}