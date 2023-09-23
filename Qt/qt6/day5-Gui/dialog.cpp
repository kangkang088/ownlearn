#include "dialog.h"
#include "ui_dialog.h"

Dialog::Dialog(QWidget *parent)
    : QDialog(parent)
    , ui(new Ui::Dialog)
{
    ui->setupUi(this);
}

Dialog::~Dialog()
{
    delete ui;
}


void Dialog::on_pushButton_clicked()
{
    QMessageBox::information (NULL,"infomation","是否退出此系统",QMessageBox::Yes|QMessageBox::No,QMessageBox::Yes);
}


void Dialog::on_pushButton_2_clicked()
{
    QMessageBox::critical (NULL,"critical","错误信息",QMessageBox::Yes|QMessageBox::No,QMessageBox::Yes);
}


void Dialog::on_pushButton_3_clicked()
{
    QMessageBox::warning (NULL,"warning","警告信息",QMessageBox::Yes|QMessageBox::No,QMessageBox::Yes);
}


void Dialog::on_pushButton_4_clicked()
{
    QMessageBox::question (NULL,"question","问题信息",QMessageBox::Yes|QMessageBox::No,QMessageBox::Yes);
}


void Dialog::on_pushButton_5_clicked()
{
    QMessageBox::about (NULL,"about","默认提示消息框");
}


void Dialog::on_pushButton_6_clicked()
{
    QMessageBox messageBox(QMessageBox::NoIcon,"登录","用户和密码验证是否成功",QMessageBox::Yes|QMessageBox::No,NULL);

    int iresult = messageBox.exec ();

    switch (iresult) {
    case QMessageBox::Yes:
        QMessageBox::about (NULL,"提示","您已经点击yes按钮");
        break;
    case QMessageBox::No:
        QMessageBox::about (NULL,"提示","您已经点击no按钮");
        break;
    default:
        break;
    }
}

