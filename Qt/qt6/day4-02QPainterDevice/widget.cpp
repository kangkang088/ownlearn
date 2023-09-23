#include "widget.h"
#include "ui_widget.h"
#include <QPainter>
#include <QPicture>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //QPixmap做绘图设备
//    QPixmap pix(300,300);
//    pix.fill(QColor(Qt::white));
//    QPainter painter(&pix);

//    painter.setPen(QPen(Qt::green));
//    painter.drawEllipse(QPoint(150,150),100,100);
//    pix.save("F:/pix.png");

    //QImage做绘图设备  专门为像素级别的访问做优化
//    QImage img(300,300,QImage::Format_RGB32);
//    img.fill(QColor(Qt::white));
//    QPainter painter(&img);

//    painter.setPen(QPen(Qt::blue));
//    painter.drawEllipse(QPoint(150,150),100,100);
//    img.save("F:/img.png");


    //QPicture做绘图设备  记录和重现画家的绘图指令
    QPicture pic;
    QPainter painter;
    painter.begin(&pic);
    painter.setPen(QPen(Qt::red));
    painter.drawEllipse(QPoint(150,150),100,100);

    painter.end();
    pic.save("F:/pic.zt");


}
void Widget::paintEvent(QPaintEvent *event)
{
    //QImage重写绘图事件
//    QPainter painter(this);
//    QImage img;
//    img.load(":/Image/Luffy.png");
//    for(int i = 50;i<100;i++)
//    {
//        for(int j =50;j<100;j++)
//        {
//            QRgb val = img.pixel(j,i);//读取像素点
//            //QRgb val = qRgb(255,0,0);
//            img.setPixel(i,j,val);//设置像素点
//        }
//    }
//    painter.drawImage(0,0,img);


    //重现绘图指令
    QPainter painter(this);
    QPicture pic;
    pic.load("F:/pic.zt");
    painter.drawPicture(0,0,pic);
}

Widget::~Widget()
{
    delete ui;
}

