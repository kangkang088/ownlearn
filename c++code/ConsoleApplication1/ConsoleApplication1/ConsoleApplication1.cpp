#include <iostream>
using namespace std;
#define MONTHS 12   //宏常量
#define PI 3.14159
int main()
{
    cout << "我是一只啥啥鸟\n";
    cout << 5 << endl;
    cout << 10.2 << endl;
    cout << 'a' << endl;
    //超女基本信息，姓名，年龄，体重，性别，颜值
    string name;
    int age;
    double weight;
    char sex;
    bool face;

    name = "西施";
    weight = 78.5;
    age = 25;
    sex = 'Y';
    face = true;

    cout << "姓名：" << name << "，年龄：" << age << "，体重："
        << weight << "，性别：" << sex << "，颜值：" << face << endl;

    name = "冰冰";
    weight = 76.5;
    age = 24;
    sex = 'Y';
    face = false;

    cout << "姓名：" << name << "，年龄：" << age << "，体重："
        << weight << "，性别：" << sex << "，颜值：" << face << endl;

    cout << "一年有" << MONTHS <<"个月" << endl;

    const int days = 7;
    cout << "一个星期有" << days << "天" << endl;

    cout << "请示如超女的姓名：";
    //string name1;
    cin >> name;
    cout << "已输入超女的姓名是：" << name << endl;

    cout << "请输入超女的年龄：";
    cin >> age;
    cout << "已输入超女的年龄是：" << age << endl;

    cout << "请输入超女的颜值（0-不漂亮，1-漂亮）：";
    cin >> face;
    cout << "已输入超女的颜值是：" << face << endl;
}
