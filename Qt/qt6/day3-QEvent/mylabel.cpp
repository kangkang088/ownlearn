#include "mylabel.h"
#include <QMouseEvent>

MyLabel::MyLabel(QWidget *parent)
    : QLabel{parent}
{
    //设置鼠标追踪
    //this->setMouseTracking(true);//鼠标不用按下
}
void MyLabel::enterEvent(QEnterEvent *event)
{
    qDebug() << "鼠标进入了";

}
void MyLabel::leaveEvent(QEvent *event)
{

    qDebug() << "鼠标离开了";
}
//捕获鼠标按下
void MyLabel::mousePressEvent(QMouseEvent *ev)
{
    //如果是鼠标按下去，打印下面的信息
    if (ev->button() == Qt::LeftButton)
    {
        QString str = QString("鼠标按下,x = %1,y = %2").arg(ev->x()).arg(ev->y());
        qDebug() << str;
    }

}
//捕获鼠标离开
void MyLabel::mouseReleaseEvent(QMouseEvent *ev)
{
    if(ev->button() == Qt::LeftButton)
    {
    qDebug() << "鼠标离开";
    }
}
//捕获鼠标移动
void MyLabel::mouseMoveEvent(QMouseEvent *ev)
{
    if(ev->buttons() & Qt::LeftButton)
    {
    qDebug() << "鼠标移动";
    }
}
//事件分发器
bool MyLabel::event(QEvent *e)
{
    if(e->type() == QEvent::MouseButtonPress)
    {
        QMouseEvent * ev = static_cast<QMouseEvent*>(e);
        QString str = QString("在event中，鼠标按下,x = %1,y = %2").arg(ev->x()).arg(ev->y());
        qDebug() << str;
        return true;//拦截事件，不向下分发
    }

    //其他事件交给父类
    return QLabel::event(e);

}
