#include <iostream>
using namespace std;
//����Ӱ��
namespace a {
    int number1 = 10;
    namespace aa {
        int number1 = 35;
    }
}
namespace b {
    int number1 = 20;
}
//�����ռ��ǿ��ŵģ�������ʱ׷��Ԫ��
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
    //ʹ��
    cout << a::aa::number1 << endl;
    cout << a::number1 << endl;
    cout << b::number1 << endl;
    cout << b::number2 << endl;

    //��ǰ�����ռ�����������ռ��д���ͬ����Աʱ��Ĭ��ʹ�õ�ǰ�����ռ�ĳ�Ա
    int number2 = 366;
    using namespace b;
    cout << number2 << endl;
    cout << b::number2 << endl;

    //������õĶ�������ռ������ͬ���ֵĳ�Ա���ҵ�ǰ�����ռ��в�����ͬ����Ա����ʱ���øó�Ա����ڶ����ԣ�����
    //��ʱҪ�������
    cout << c::mm << endl;
    cout << d::mm << endl;
}