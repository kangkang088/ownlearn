#include "mywidget.h"
#include <QPushButton>
#include "mypushbytton.h"
#include <QDebug>
//命名规范
//类：首字母大写，单词之间首字母大写
//函数名，变量名：首字母小写，单词之间首字母大写

//快捷键
//CTRL + R  运行
//CTRL + B  编译
//CTRL + /  注释
//CTRL + shift + ↑或↓  整行移动
//CTRL + i  自动对齐
//F4  同名h和cpp切换
//CTRL + l  查找关键字
//F1  帮助文档

MyWidget::MyWidget(QWidget *parent)
    : QWidget(parent)
{
    //按钮控件
    QPushButton * btn = new QPushButton;
    //btn->show();//顶层方式显示（自己独立显示）

    //如果想显示的时候依赖在当前窗口中，需要设置父窗口
    btn->setParent(this);
    //btn->show();
    //设置文本
    btn->setText("你好");

    //创建第二个按钮
    QPushButton * btn2 = new QPushButton("你好!",this);
    //btn2->show();
    btn2->resize(100,100);//按钮也可以设置尺寸

    //移动按钮
    btn2->move(100,0);
    connect(btn2,&QPushButton::clicked,this,&MyWidget::close);

    //重置窗口大小  可以拖拽
    //this->resize(600,400);

    //设置固定的窗口尺寸
    this->setFixedSize(600,400);

    //设置窗口的标题
    this->setWindowTitle("第一个窗口");

    //自定义自己的按钮，捕获析构函数
    MyPushBytton * mbtn = new MyPushBytton;
    mbtn->setParent(this);
    mbtn->move(0,100);
    mbtn->setText("我的按钮");

    //QT中的坐标系
    //左上角：（0，0） 向右x正，向下y正

    //点击 我的按钮 实现关闭窗口
    //1.信号的发送者（指针）2.发送的信号（地址）3.信号的接收者（指针）4.槽函数（地址）
    connect(mbtn,&MyPushBytton::clicked,this,&MyWidget::close);

    //自定义信号和槽
    //day1-1
}

MyWidget::~MyWidget()
{
    qDebug() << "mywidget析构函数调用";
}

