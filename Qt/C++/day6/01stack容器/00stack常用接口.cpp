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
    
    cout << "栈的大小：" << s.size() << endl;
    //只要栈不为空，查看栈顶，并执行出栈操作
    while (!s.empty())
    {
        //查看栈顶
        cout << "栈顶元素：" << s.top() << endl;

        //出栈
        s.pop();
    }

    cout << "栈的大小：" << s.size() << endl;
}
int main()
{
    test1();
}