#include "widget.h"
#include "ui_widget.h"
#include <QPainter>
#include <QTimer>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);
    this->posX = 0;
    //监听点击信号
    connect(ui->BtnMove,&QPushButton::clicked,[=](){
        this->posX += 10;
        //手动调用绘图事件
        update();
    });

    QTimer * timer = new QTimer(this);
    timer->start(50);
    connect(timer,&QTimer::timeout,[=](){
        this->posX++;
        update();
    });
}

Widget::~Widget()
{
    delete ui;
}
void Widget::paintEvent(QPaintEvent *event)
{
    //////////////////////////高级绘图/////////////////////////////
    QPainter painter1(this);
//    painter1.drawEllipse(QPoint(100,100),50,50);

//    //设置抗锯齿效果
//    painter1.setRenderHint(QPainter::Antialiasing);
//    painter1.drawEllipse(QPoint(250,100),50,50);

//    painter1.drawRect(QRect(20,20,50,50));
//    //移动画家（原点）
//    painter1.translate(100,0);
//    painter1.save();//保存状态
//    painter1.drawRect(QRect(20,20,50,50));
//    //再次移动
//    painter1.translate(100,0);
//    painter1.restore();//恢复状态
//    painter1.drawRect(QRect(20,20,50,50));

    //画成品图案
    QPixmap pix;
    pix.load(":/Image/Luffy.png");
    if(this->posX > this->width())
    {
        this->posX = -pix.width();
    }
    painter1.drawPixmap(this->posX,0,pix);



    //////////////////////////基本绘图/////////////////////////////
//    //QPaintDevice * = this；this指的是绘画设备，即在当前窗口画画，不是添加到对象树
//    QPainter * painter = new QPainter(this);

//    //设置画笔，要在开始画之前设置，可以设置画笔的颜色...
//    QPen pen(QColor(255,0,0));//设置画笔的颜色
//    pen.setWidth(3);//设置笔的宽度
//    pen.setStyle(Qt::DashLine);//设置画笔的风格
//    painter->setPen(pen);//拿起画笔

//    //画刷，可以填充封闭的图案
//    QBrush brush(Qt::cyan);//设置画刷的颜色
//    brush.setStyle(Qt::Dense1Pattern);//设置画刷的样式
//    painter->setBrush(brush);//拿起画刷

//    //画线
//    painter->drawLine(QPoint(0,0),QPoint(100,100));
//    //画圆
//    painter->drawEllipse(QPoint(100,100),100,50);
//    //画矩形
//    painter->drawRect(QRect(20,20,50,50));
//    //画字
//    painter->setFont(QFont("楷体",20));//设置字体
//    painter->drawText(QRect(0,200,200,200),"好好学习，天天向上");//宽度不够会自动换行
}
