#include "mywidget.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    //应用程序的对象 a
    QApplication a(argc, argv);
    //窗口对象 w 默认不显示
    MyWidget w;
    //显示窗口对象
    w.show();
    //进到消息循环  起到阻塞的功能
    return a.exec();
}
