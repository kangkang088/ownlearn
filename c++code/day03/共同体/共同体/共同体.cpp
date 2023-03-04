// 共同体.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
union udata
{
    int a;
    double b;
    char c[25];
};
int main()
{
    udata data;
    cout << "sizeof(data) = " << sizeof(data) << endl;//共同体的大小和其成员占用的最大内存的大小一样 ，在vs中默认对齐到8字节的整数倍 1-7->8 , 9-15->16 , 17-23->24 ...
    cout << (void*)&data.a << endl;//共用一块内存
    cout << (void*)&data.b << endl;
    cout << (void*)&data.c << endl;


    data.a = 3;
    data.b = 8.8;
    strcpy_s(data.c, "我是一只傻傻鸟");
    cout << data.a << endl;
    cout << data.b << endl;
    cout << data.c << endl;


}

// 运行程序: Ctrl + F5 或调试 >“开始执行(不调试)”菜单
// 调试程序: F5 或调试 >“开始调试”菜单

// 入门使用技巧: 
//   1. 使用解决方案资源管理器窗口添加/管理文件
//   2. 使用团队资源管理器窗口连接到源代码管理
//   3. 使用输出窗口查看生成输出和其他消息
//   4. 使用错误列表窗口查看错误
//   5. 转到“项目”>“添加新项”以创建新的代码文件，或转到“项目”>“添加现有项”以将现有代码文件添加到项目
//   6. 将来，若要再次打开此项目，请转到“文件”>“打开”>“项目”并选择 .sln 文件
