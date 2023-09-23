#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //设置主窗口标题
    this->setWindowTitle ("第一个窗口");
}

Widget::~Widget()
{
    delete ui;
}

