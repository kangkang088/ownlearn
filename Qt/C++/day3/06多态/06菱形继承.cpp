#include <iostream>
using namespace std;

class Animal
{
public:
    int m_age;
};
class Sheep :virtual public Animal
{
public:
    int m_a;
};
class Tuo:virtual public Animal
{
    int m_b;
};
class SheepTuo :public Sheep, public Tuo 
{
    int m_c;
};
void test1()
{
    SheepTuo sheepTuo;
    sheepTuo.Sheep::m_age = 18;
    sheepTuo.Tuo::m_age = 18;
    cout << "sheepTuo.Sheep::m_age = " << sheepTuo.Sheep::m_age << endl;
    cout << "sheepTuo.Tuo::m_age = " << sheepTuo.Tuo::m_age << endl;
    cout << sizeof(sheepTuo) << endl;
}
int main()
{
    test1();
}