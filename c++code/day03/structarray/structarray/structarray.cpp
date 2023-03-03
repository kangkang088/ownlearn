// structarray.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
using namespace std;
struct st_girl
{
    char name[21];
    int age;
    double weight;
    char sex;
    bool yz;
};
int main()
{
    st_girl girls[3];
    memset(girls, 0, sizeof(girls));
    strcpy_s(girls[0].name, "西施"); girls[0].age = 25; girls[0].weight = 65.5; girls[0].sex = 'X'; girls[0].yz = true;
    girls[1] = {"冰冰",26,100.6,'x',false};
    //指针表示法   *（girls + 1） = {"冰冰",26,100.6,'x',false};
    girls[2] = {"爱爱",26,100.6,'x',false};
    for (int i = 0; i < 3; i++)
    {
        //数组表示法
        cout << girls[i].name << " " << girls[i].age << " " << girls[i].weight << " " << girls[i].sex << " " << girls[i].yz << endl;
        //指针表示法
        cout << (girls+i)->name << " " << (girls + i)->age << " " << (girls + i)->weight << " " << (girls + i)->sex << " " << (girls + i)->yz << endl;
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
