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
//        cout << "煮农夫山泉水" << endl;
//    }
//    virtual void brew()
//    {
//        cout << "加入咖啡" << endl;
//    }
//    virtual void pourInCup()
//    {
//        cout << "咖啡倒入杯中" << endl;
//    }
//    virtual void addSomethingInCup()
//    {
//        cout << "加点糖和牛奶" << endl;
//    }
//};
//class Tea :public AbstractDrink
//{
//    virtual void boil()
//    {
//        cout << "煮井水" << endl;
//    }
//    virtual void brew()
//    {
//        cout << "加入茶叶" << endl;
//    }
//    virtual void pourInCup()
//    {
//        cout << "茶叶倒入杯中" << endl;
//    }
//    virtual void addSomethingInCup()
//    {
//        cout << "加点枸杞" << endl;
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