#include <iostream>
using namespace std;
//互不影响
namespace a {
    int number1 = 10;
    namespace aa {
        int number1 = 35;
    }
}
namespace b {
    int number1 = 20;
}
//命名空间是开放的，可以随时追加元素
namespace b {
    int number2 = 355;
}
namespace c {
    int mm = 5;
}
namespace d {
    int mm = 10;
}
int main()
{
    //使用
    cout << a::aa::number1 << endl;
    cout << a::number1 << endl;
    cout << b::number1 << endl;
    cout << b::number2 << endl;

    //当前命名空间和引用命名空间中存在同名成员时，默认使用当前命名空间的成员
    int number2 = 366;
    using namespace b;
    cout << number2 << endl;
    cout << b::number2 << endl;

    //如果引用的多个命名空间存在相同名字的成员，且当前命名空间中不存在同名成员，这时引用该成员会存在二义性，报错，
    //此时要具体访问
    cout << c::mm << endl;
    cout << d::mm << endl;
}