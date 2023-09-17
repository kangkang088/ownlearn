#include "widget.h"
#include "ui_widget.h"
#include <QMessageBox>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //1.设置列数
    ui->tableWidget->setColumnCount(3);
    ui->tableWidget->resize(900,500);
    //2.设置水平表头标签
    ui->tableWidget->setHorizontalHeaderLabels(QStringList() << "姓名" << "性别"<< "年龄");
    //3.设置行数
    ui->tableWidget->setRowCount(5);

    //设置正文
    //ui->tableWidget->setItem(0,0,new QTableWidgetItem("亚瑟"));

    QStringList list;
    list << "亚瑟" << "妲己" << "韩信" << "孙悟空" << "梦琪";
    QList<QString> sexList;
    sexList << "男" << "女" << "男" << "男" << "男";
    for(int i = 0; i < 5; i++)
    {
        int col = 0;

        ui->tableWidget->setItem(i,col++,new QTableWidgetItem(list[i]));

        ui->tableWidget->setItem(i,col++,new QTableWidgetItem(sexList.at(i)));

        //int转QString
        ui->tableWidget->setItem(i,col++,new QTableWidgetItem(QString::number(18+i)));
    }

    //点击添加赵云实现添加功能
    connect(ui->BtnAdd,&QPushButton::clicked,[=](){
        //如果有赵云，不添加
        bool isEmptys = ui->tableWidget->findItems("赵云",Qt::MatchExactly).isEmpty();
        if(!isEmptys)
        {
            QMessageBox::warning(this,"警告","已经有赵云了");
        }
        else
        {
            ui->tableWidget->insertRow(0);
            ui->tableWidget->setItem(0,0,new QTableWidgetItem(QString("赵云")));
            ui->tableWidget->setItem(0,1,new QTableWidgetItem(QString("男")));
            ui->tableWidget->setItem(0,2,new QTableWidgetItem(QString::number(28)));
        }
    });
    //点击删除赵云实现删除功能
    connect(ui->BtnDelete,&QPushButton::clicked,[=](){
        bool isEmptyss = ui->tableWidget->findItems("赵云",Qt::MatchExactly).isEmpty();
        if(isEmptyss)
        {
            QMessageBox::warning(this,"警告","没有赵云");
        }
        else
        {
            //找到第一个赵云所在的行号
            int rowNum = ui->tableWidget->findItems("赵云",Qt::MatchExactly).first()->row();
            ui->tableWidget->removeRow(rowNum);

        }
    });

}

Widget::~Widget()
{
    delete ui;
}

