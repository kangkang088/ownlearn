#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //点击设置
    connect(ui->BtnSet,&QPushButton::clicked,[=](){
        ui->widget->setData(50);
    });
    //点击获取
    connect(ui->BtnGet,&QPushButton::clicked,[=](){
        qDebug() << ui->widget->getData();
    });
}

Widget::~Widget()
{
    delete ui;
}

