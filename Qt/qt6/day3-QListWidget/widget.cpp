#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //ListWidget的使用
    QListWidgetItem * item = new QListWidgetItem("锄禾日当午");
    ui->listWidget->addItem(item);
    //设置文本对齐方式
    item->setTextAlignment(Qt::AlignHCenter|Qt::AlignVCenter);

    //一次性添加
    QStringList list;
    list << "锄禾日当午" << "汗滴禾下土" << "谁之盘中餐" << "粒粒皆辛苦";
    ui->listWidget->addItems(list);
}

Widget::~Widget()
{
    delete ui;
}

