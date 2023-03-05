#include <iostream>
using namespace std;
class CGirl   //类，把class改为struct，再去掉第一行的public，c++中结构体就是类
{
    //缺省为私有的
public:
    string        name;
private: //私有的，只有类中可以访问
    int             age;
public:
    double      height;
    double      weight;
    bool          yz;
    string        special;
    string        memo;
    void show()//结构体函数可以直接在结构体中访问成员变量，不用传参数
    {
        cout << "姓名：" << name << ", 年龄：" << age << ",身高："
            << height << "，体重：" << weight << "，颜值："
            << yz << "，特长：" << "\"" << special << "\"" << "，备注：" << memo << endl;

    }
    //代码太长，可以定义在类的外面
    //在类中只写函数的声明
    /*void setvalue(string name1, int age1, double height1, double weight1,
        bool yz1, string special1, string memo1)；*/
    void setvalue(string name1, int age1, double height1, double weight1,
        bool yz1, string special1, string memo1)
    {
        name = name1;
        age = age1;
        height = height1;
        weight = weight1;
        yz = yz1;
        special = special1;
        memo = memo1;
    }
};
//定义在外面
//void CGirl::setvalue(string name1, int age1, double height1, double weight1,
//    bool yz1, string special1, string memo1)
//{
//    name = name1;
//    age = age1;
//    height = height1;
//    weight = weight1;
//    yz = yz1;
//    special = special1;
//    memo = memo1;
//}

int main()
{
    CGirl girl;

    girl.setvalue("西施", 26, 170, 50.5, 1, "唱歌，跳舞，洗衣服", "春秋第一美女，四大美女之一。");

    girl.show();
}
