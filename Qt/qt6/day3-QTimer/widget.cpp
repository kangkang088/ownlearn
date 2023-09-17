#include "widget.h"
#include "ui_widget.h"
#include <QTimer>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);
    //启动定时器
    this->m_id1 = startTimer(1000);

    this->m_id2 = startTimer(2000);

    //定时器类
    QTimer * timer = new QTimer(this);
    timer->start(500);//每隔0.5秒，定时器对象会发一个信号
    //监听定时器对象的信号
    connect(timer,&QTimer::timeout,[=](){
        static int num = 1;
        ui->label_3->setText(QString::number(num++));
    });

    //点击按钮，停止计时
    connect(ui->BtnStop,&QPushButton::clicked,[=](){
        timer->stop();
    });
}

Widget::~Widget()
{
    delete ui;
}
//定时器事件
void Widget::timerEvent(QTimerEvent *event)
{
    if(event->timerId() == m_id1)
    {
        static int num = 1;
        ui->label->setText(QString::number(num++));
    }
    if(event->timerId() == m_id2)
    {
        static int num2 = 1;
        ui->label_2->setText(QString::number(num2++));
    }
}

