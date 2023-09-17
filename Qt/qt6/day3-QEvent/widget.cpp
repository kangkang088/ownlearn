#include "widget.h"
#include "ui_widget.h"
#include <QMouseEvent>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //利用事件过滤器，拦截label鼠标按下事件
    ui->label->installEventFilter(this);
    //重写过滤器事件
}

Widget::~Widget()
{
    delete ui;
}
 //重写过滤器事件
//参数1-判断控件 参数2-判断事件
bool Widget::eventFilter(QObject * watched, QEvent * event)
{
    if(ui->label == watched)
    {
        if(event->type() == QEvent::MouseButtonPress)
        {
            QMouseEvent * ev = static_cast<QMouseEvent*>(event);
            QString str = QString("在事件过滤器中，鼠标按下,x = %1,y = %2").arg(ev->x()).arg(ev->y());
            qDebug() << str;
            return true;//拦截事件，不向下分发
        }
    }
    return QWidget::eventFilter(watched,event);
}

