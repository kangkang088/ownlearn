// 链表.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
struct st_girl //超女单链表
{
    int no;                            //超女编号
    string name;                  //超女姓名  
    struct st_girl* next;        //下一个超女节点的地址，如果是最后一条记录，则nullptr；
};
int main()
{
    st_girl* head = nullptr, *tail = nullptr, *tmp = nullptr;
    //  c++写法  tmp = new st_girl = ({1,"西施",nullptr});
   /* tmp->no = 1;
    tmp->name = "西施";
    tmp->next = nullptr;*/   //传统写法

    //c11标准
    tmp = new st_girl({ 1, "西施", nullptr });//第一个节点
    head = tail = tmp;

    tmp = new st_girl({ 6,"冰冰",nullptr });//第二个节点
    tail->next = tmp;
    tail = tmp;

    tmp = new st_girl({ 3,"蜜蜜",nullptr });//第三个节点
    tail->next = tmp;
    tail = tmp;

    tmp = head;
    while (tmp != nullptr)
    {
        cout << "no=" << tmp->no << " " << "name=" << tmp->name << " " << "tmp->next=" << tmp->next << endl;
        tmp = tmp->next;
    }
    while (head != nullptr)
    {
        tmp = head;
        head = head->next;
        delete tmp;
    }

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
