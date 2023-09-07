//#include <iostream>
//using namespace std;
//
//class Animal
//{
//public:
//    virtual void speak()
//    {
//        cout << "动物在说话" << endl;
//    }
//};
//class Cat :public Animal
//{
//public:
//    void speak()
//    {
//        cout << "小猫在说话" << endl;
//    }
//};
////我们希望传入什么对象，那么就调用什么对象的函数
////如果函数地址在编译阶段就能确定，那么静态联编
////如果函数地址在运行阶段才能确定，就是动态联编
//void doSpeak(Animal& animal)
//{
//    animal.speak();
//}
//int main()
//{
//    Cat cat;
//    doSpeak(cat);
//}