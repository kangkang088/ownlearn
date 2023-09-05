#include <iostream>
using namespace std;

//void changeNumber(int number) {
//    number = 100;
//}
//
//void changeNumber(int* number) {
//    *number = 100;
//}
//
//int main() {
//
//    int num = 10;
//
//    // 这里是值传递，传递到函数changeNumber中的是10，因此在函数中修改参数number的值，对这里的变量num没有影响
//    changeNumber(num);
//    cout << "num = " << num << endl;
//
//    // 这里是地址传递，传递到函数changeNumber中的是变量num的地址，在函数中通过地址修改指向空间的值，这里的num会受到影响
//    changeNumber(&num);
//    cout << "num = " << num << endl;
//
//    return 0;
//}