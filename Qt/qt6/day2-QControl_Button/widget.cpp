#include "widget.h"
#include "ui_widget.h"
#include <QDebug>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //单选按钮设置默认状态
    ui->rBtnMen->setChecked(true);
    this->sex = true;

    //选中女的时候，监听这个行为
    connect(ui->rBtnWomen,&QRadioButton::clicked,[=]()
            {
        qDebug() << "选中女";
        this->sex = false;
    });
    connect(ui->rBtnMen,&QRadioButton::clicked,[=](){
        qDebug() << "选中男";
        this->sex = true;
    });

    connect(ui->Btn_commit,&QPushButton::clicked,[=](){
        if(this->sex == true)
        {
            qDebug() << "用户提交的是男";
        }
        else
        {
            qDebug() << "用户提交的是女";
        }
    });


    //复选按钮
    //监听环境优雅是否被选中
    ui->checkBox->setTristate(true);//第三种状态，半选中状态 1

    connect(ui->checkBox,&QCheckBox::stateChanged,[=](int state){

        qDebug() << state;//判断出选中是2，未选中是0 两种状态，可以设置第三种状态
    });


}

Widget::~Widget()
{
    delete ui;
}

