#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <string>
#include <deque>
#include <stack>
using namespace std;

void test1()
{
    stack<int> s;
    s.push(10);
    s.push(20);
    s.push(30);
    s.push(40);
    
    cout << "ջ�Ĵ�С��" << s.size() << endl;
    //ֻҪջ��Ϊ�գ��鿴ջ������ִ�г�ջ����
    while (!s.empty())
    {
        //�鿴ջ��
        cout << "ջ��Ԫ�أ�" << s.top() << endl;

        //��ջ
        s.pop();
    }

    cout << "ջ�Ĵ�С��" << s.size() << endl;
}
int main()
{
    test1();
}