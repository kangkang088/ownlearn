//#include <iostream>
//#include <fstream>
//using namespace std;
//
////1.普通函数调用可以发生隐式类型转换
////2.函数模板用自动类型推导，不可以发生隐式类型转换
////3.函数模板用显式指定类型，可以发生隐式类型转换
//
////普通函数
//int myAdd(int a, int b)
//{
//    return a + b;
//}
////函数模板
//template<typename T>
//T myAdd_S(T a, T b)
//{
//    return a + b;
//}
//void test1()
//{
//    int a = 10;
//    int b = 20;
//    cout << myAdd(a, b) << endl;
//    char c = 'c';
//    //隐式类型转换
//    cout << myAdd(a,c) << endl;
//
//    //自动类型推导
//    //cout << myAdd_S(a, c) << endl;//不可以发生隐式类型转换
//    
//    //显式指定类型
//    cout << myAdd_S<int>(a, c) << endl;//可以发生隐式类型转换
//    //如果隐式类型转换不成功，则报错
//}
//int main()
//{
//    test1();
//}