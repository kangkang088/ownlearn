#include "widget.h"
#include <QPushButton>
#include <QDebug>

//老师 Teacher  学生 Student
//下课后，老师发送饿了信号，学生进行响应，请老师吃饭

Widget::Widget(QWidget *parent)
    : QWidget(parent)
{
    this->zt = new Teacher(this);
    this->st = new Student(this);

    //链接信号和槽
    //connect(this->zt,&Teacher::hungry,this->st,&Student::treat);

    //链接有参数的信号和槽
    //函数指针，指向函数的地址
    //避免二义性，使其指向带参数的函数
                                                 //& 高版本不加也可以，建议加
//    void (Teacher:: * teacherSingnal)(QString) = &Teacher::hungry;
//    void (Student:: * studentSingnal)(QString) = &Student::treat;
//    connect(this->zt,teacherSingnal,this->st,studentSingnal);
//上面的一运行就饿，固定显示,没有注释classIsOver，用来触发信号


//点击下课按钮后再显示饿了
    QPushButton * btn = new QPushButton;
    btn->setParent(this);
    btn->setText("下课");

    void (Teacher:: * teacherSingals)() =&Teacher::hungry;
    void (Student:: * studentSingals)() = &Student::treat;
    connect(this->zt,teacherSingals,this->st,studentSingals);



    //信号和槽的扩展
    //信号链接信号
    //一个信号可以链接多个槽函数
    //多个信号可以绑定同一个槽函数
    //信号和槽的参数类型必须一一对应
    //参数个数不一定要相等，信号参数可以多于槽参数，反之不可以;对应的参数类型也要一样
    //可以利用 disconnect 断开信号链接
    connect(btn,&QPushButton::clicked,this->zt,teacherSingals);

    //链接有参数的
    connect(btn,&QPushButton::clicked,[=](){this->st->treat("宫保鸡丁");});

    connect(btn,&QPushButton::clicked,this,&Widget::close);

    disconnect(btn,&QPushButton::clicked,this,&Widget::close);

//注释classIsOver，用点击按钮来触发信号

    //下课调用函数
    //classIsOver();


    //QT4版本 信号和槽的写法
    //优点：参数直观，写法简单
    //缺点：编译器不检测参数的类型
    connect(this->zt,SIGNAL(hungry(QString)),this->st,SLOT(treat(QString)));


    //下课调用函数
    classIsOver();



    //lambda表达式
    QPushButton * btn2 = new QPushButton;
    btn2->move(100,0);
    btn2->setParent(this);


//    QPushButton * btn3 = new QPushButton;
//    btn3->move(300,0);
//    btn3->setParent(this);


    btn2->setText("aaa");
    //btn3->setText("aaa");

    //[](){}

    // = 函数体内可以使用lambda所在范围内所有可见的局部变量（值传递）
    // & 引用传递
    // this 可以使用所在范围的成员变量

    [=](){
        btn2->setText("bbb");

    }();
    // a 将a值传递，就是只有a可以用
//    [btn2](){
//        btn2->setText("bbb");
//        //btn3->setText("bbb");//报错
//    }();


    //mutable
    QPushButton* myBtn1 = new QPushButton(this);
    QPushButton* myBtn2 = new QPushButton(this);
    myBtn1->move(0,100);
    myBtn2->move(100,100);
    int m = 10;
    connect(myBtn1,&QPushButton::clicked,this,[m]()mutable{m = 20;qDebug() << m;});
    connect(myBtn2,&QPushButton::clicked,this,[=](){qDebug() << m;});

    qDebug() << m;

    //返回值类型
    int num = []()->int{return 1000;}();
    qDebug() << "num = " << num;

    //拓展
    //[=](){} 推荐使用
    QPushButton* btn3 = new QPushButton;
    btn3->setParent(this);
    btn3->move(300,300);
    btn3->setText("aaa");
    connect(btn3,&QPushButton::clicked,[=](){btn3->setText("bbb");});

}
void Widget::classIsOver()
{
    //触发自定义信号
    //emit this->zt->hungry();

    //触犯有参的信号
    emit this->zt->hungry("宫保鸡丁");
}
Widget::~Widget()
{
}

