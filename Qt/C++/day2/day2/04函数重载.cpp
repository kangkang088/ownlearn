//#include <iostream>
//using namespace std;
//// 重载函数的定义
//int add(int num1, int num2) {
//    return num1 + num2;
//}
//double add(int num1, double num2) {
//    return num1 + num2;
//}
//double add(double num1, int num2) {
//    return num1 + num2;
//}
//double add(double num1, double num2) {
//    return num1 + num2;
//}
//
//int main() {
//
//    // 区分调用不同的重载方法，应该从实参入手
//    cout << add(10, 20) << endl;		// 调用的是add(int, int)的方法 
//    cout << add(10, 11.3) << endl;		// 调用的是add(int, double)的方法
//    cout << add(11.2, 10) << endl;		// 调用的是add(double, int)的方法
//    cout << add(11.1, 22.2) << endl;	// 调用的是add(double, double)的方法
//
//    return 0;
//}