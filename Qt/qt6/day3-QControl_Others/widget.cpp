#include "widget.h"
#include "ui_widget.h"
#include <QMovie>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);
    //stack widget
    //设置默认选中第一个
    ui->stackedWidget->setCurrentIndex(0);

    connect(ui->BtnScroll,&QPushButton::clicked,[=](){
       //设置当前索引
        ui->stackedWidget->setCurrentIndex(0);
    });
    connect(ui->BtnTB,&QPushButton::clicked,[=](){
        ui->stackedWidget->setCurrentIndex(2);
    });
    connect(ui->BtnTw,&QPushButton::clicked,[=](){
        ui->stackedWidget->setCurrentIndex(1);
    });

    //ComboBox 下拉框
    ui->comboBox->addItem("奔驰");
    ui->comboBox->addItem("宝马");
    ui->comboBox->addItem("保时捷");
    //点击按钮，定位到对应选项
    connect(ui->BtnSelected,&QPushButton::clicked,[=](){
        //ui->comboBox->setCurrentIndex(2);
        ui->comboBox->setCurrentText("保时捷");
    });


    //利用QLabel显示图片

    QPixmap pixmap;
    pixmap.load(":/Image/butterfly.png");
    ui->label_img->setPixmap(QPixmap(pixmap));
    ui->label_img->setFixedSize(pixmap.width(),pixmap.height());

    QMovie * movie = new QMovie(":/Image/mario.gif");
    ui->label_movie->setMovie(movie);
    movie->start();//默认无限循环播放

    movie->setSpeed(300);

    connect(movie,&QMovie::frameChanged,[=](int franmId){
        if(franmId == movie->frameCount() - 1)
        {
            movie->stop();
        }
    });


}

Widget::~Widget()
{
    delete ui;
}

