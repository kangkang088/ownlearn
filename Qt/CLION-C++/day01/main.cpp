#include <iostream>

using namespace std;
int main() {
    std::cout << "Hello, World!" << std::endl;
    int num1 = 5;
    cin >> num1;

    cout << num1 << endl;
    cout << cin.good() << cin.fail() << endl;
    int num2;
    cin.clear();
    cin.ignore('\n');
    cin >> num2;
    cout << num2 << endl;
    return 0;

}
