//#include <iostream>
//using namespace std;
//void changeNumber1(int n) {
//    n = 200;
//}
//
//void changeNumber2(int& n) {
//    n = 200;
//}
//
//int main() {
//    int number = 10;
//
//    changeNumber1(number);
//    cout << "值传递的number = " << number << endl;	// 值传递，因此这里的number并没有发生变化
//
//    changeNumber2(number);
//    cout << "引用传递的number = " << number << endl;	// 引用传递，因此这里的number也会发生变化
//
//    return 0;
//}