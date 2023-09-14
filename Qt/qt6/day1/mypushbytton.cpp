#include "mypushbytton.h"
#include <QDebug>
MyPushBytton::MyPushBytton(QWidget *parent)
    : QPushButton{parent}
{

}
MyPushBytton::~MyPushBytton()
{
    qDebug() << "mypushbutton析构函数调用";
}
