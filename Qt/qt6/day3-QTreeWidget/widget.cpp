#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //TreeWidget 树控件

    //1.设置头标签
    ui->treeWidget->setHeaderLabels(QStringList()<<"英雄" << "英雄介绍");

    //2.创建item
    QTreeWidgetItem * liItem = new QTreeWidgetItem(QStringList() << "力量");
    //添加顶层级别的item
    ui->treeWidget->addTopLevelItem(liItem);

    QTreeWidgetItem * minItem = new QTreeWidgetItem(QStringList() << "敏捷");
    ui->treeWidget->addTopLevelItem(minItem);
    QTreeWidgetItem * zhiItem = new QTreeWidgetItem(QStringList() << "智力");
    ui->treeWidget->addTopLevelItem(zhiItem);

    //3.创建子Item，挂载到顶层item上
    QStringList herol1;
    herol1 << "刚背猪" << "前排坦克，能吸收伤害的同时造成可观的范围伤害";
    QTreeWidgetItem * l1 = new QTreeWidgetItem(herol1);
    liItem->addChild(l1);
    QStringList herol2;
    herol2 << "刚背猪2号" << "前排坦克，能吸收伤害的同时造成可观的范围伤害";
    QTreeWidgetItem * l2 = new QTreeWidgetItem(herol2);
    liItem->addChild(l2);

}

Widget::~Widget()
{
    delete ui;
}

