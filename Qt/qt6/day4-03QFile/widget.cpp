#include "widget.h"
#include "ui_widget.h"
#include <QFileDialog>
#include <QMessageBox>
#include <QFile>
#include <QFileInfo>
#include <QDateTime>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);

    //点击选择文件按钮，弹出文件对话框，读取桌面文件，将文件路径放入lineEdit中，将内容放到textEdit中
    connect(ui->pushButton,&QPushButton::clicked,[=](){
        QString filePath = QFileDialog::getOpenFileName(this,"打开文件","C:\\Users\\Administrator\\Desktop","*.txt");
        if(filePath.isEmpty())
        {
            QMessageBox::warning(this,"警告","路径不能为空");
        }
        else
        {
            ui->lineEdit->setText(filePath);



            //读取文件信息
            QFile file(filePath);
            file.open(QIODeviceBase::ReadOnly);

            QByteArray arr;
//            arr = file.readAll();//读取全部信息


            while(!file.atEnd())//判断文件尾
            {
                arr += file.readLine();//按行读
            }

            ui->textEdit->setText(arr);

            //关闭文件
            file.close();



            ///////////////写文件//////////////
//            file.open(QIODeviceBase::Append);
//            file.write ("啊啊啊啊啊");
//            file.close ();

            //文件信息类  获取文件的信息
            QFileInfo fileInfo(filePath);
            qDebug() << "后缀名：" << fileInfo.suffix ().toUtf8 ().data ()<< "大小：" << fileInfo.size ()
                     << "文件名：" << fileInfo.fileName () << "文件路径：" << fileInfo.filePath ();
                        qDebug() << "创建时间：" << fileInfo.birthTime ().toString ("yyyy.MM.dd hh:mm:ss.zzz");
        }
    });
}

Widget::~Widget()
{
    delete ui;
}

