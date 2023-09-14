#include "student.h"
#include <QDebug>

Student::Student(QObject *parent)
    : QObject{parent}
{

}
void Student::treat()
{
    qDebug() << "请老师吃饭";

}
void Student::treat(QString foodName)
{
    //QString 输出自带“”。
    //转为char* ，就没有双引号
    //先调用 toUtf8 转为 QByteArray
    //再调用 data 转为char *
    qDebug() << "老师要吃" << foodName.toUtf8().data();
}
