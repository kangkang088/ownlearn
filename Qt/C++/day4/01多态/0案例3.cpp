#include <iostream>
using namespace std;

class Cpu
{
public:
    virtual void calculator() = 0;
};
class VideoCard
{
public:
    virtual void display () = 0;
};
class Meomory
{
public:
    virtual void storage() = 0;
};
class Computer
{
public:
    Computer(Cpu* c,VideoCard* vc,Meomory* m)
    {
        this->cpu = c;
        this->vc = vc;
        this->m = m;
    }
    void doWork()
    {
        this->cpu->calculator();
        this->vc->display();
        this->m->storage();
    }
    ~Computer()
    {
        if (this->cpu != NULL)
        {
            delete this->cpu;
            this->cpu = NULL;
        }
        if (this->vc != NULL)
        {
            delete this->vc;
            this->vc = NULL;
        }
        if (this->m != NULL)
        {
            delete this->m;
            this->m = NULL;
        }
        
    }
private:
    Cpu* cpu;
    VideoCard* vc;
    Meomory* m;
};
class InterCpu :public Cpu
{
    virtual void calculator()
    {
        cout << "因特尔的cpu开始计算了" << endl;
    }
};
class InterVideoCard :public VideoCard
{
    virtual void display ()
    {
        cout << "因特尔的显卡开始显示了" << endl;
    }
};
class InterMemory :public Meomory
{
    virtual void storage()
    {
        cout << "因特尔的内存开始存储了" << endl;
    }
};
class LenovoCpu :public Cpu
{
    virtual void calculator()
    {
        cout << "联想的cpu开始计算了" << endl;
    }
};
class LenovoVideoCard :public VideoCard
{
    virtual void display()
    {
        cout << "Lenovo的显卡开始显示了" << endl;
    }
};
class LenovoMemory :public Meomory
{
    virtual void storage()
    {
        cout << "Lenovo的内存开始存储了" << endl;
    }
};
void test1()
{
    Cpu* ic = new InterCpu();
    VideoCard* ivc = new InterVideoCard();
    Meomory* m = new InterMemory();
    //第一台
    Computer* com1 = new Computer(ic, ivc, m);
    com1->doWork();
    delete com1;
    //第二台
    Computer* com2 = new Computer(new LenovoCpu(), new LenovoVideoCard(), new LenovoMemory);
    com2->doWork();
    delete com2;
}
int main()
{
    test1();
}