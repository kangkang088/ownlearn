// 引用用于函数参数denmo.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
struct st_girl
{
    int no;
    string str;
};
//传值
void func1(st_girl girl)
{
    girl.no = 8;
    girl.str = "我有一只小小鸟";
    cout << "亲爱的" << girl.no << "号：" << girl.str << endl;
}
//传地址
void func2(st_girl* girl)
{
    girl->no = 8;
    girl->str = "我有一只小小鸟";
    cout << "亲爱的" << girl->no << "号：" << girl->str << endl;
}
//传引用
void func3(st_girl& girl)
{
    girl.no = 8;
    girl.str = "我有一只小小鸟";
    cout << "亲爱的" << girl.no << "号：" << girl.str << endl;
}
int main()
{
    st_girl girl;
    girl.no = 3;
    girl.str = "我有一只傻傻鸟";
    func1(girl);
    cout << girl.no << girl.str << endl;
    func2(&girl);
    func3(girl);
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
