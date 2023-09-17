#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QDebug>
#include <QDialog>
#include <QMessageBox>
#include <QColorDialog>
#include <QFontDialog>
#include <QFileDialog>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    //点击新建，弹出对话框
    connect(ui->actionnew,&QAction::triggered,[=](){

        //对话框分类
        //1.模态对话框  弹出后，不可以对其他窗口进行操作 起到阻塞的效果
        //2.非模态对话框  相反效果

        //创建模态对话框
//        QDialog dlg(this);
//        dlg.resize(120,30);
//        dlg.exec();//阻塞下面的qDebug语句，关闭时才会打印

        //创建非模态对话框
//        QDialog *dlg = new QDialog(this);//创建在堆区。QDialog dlg（this）是创建在栈区，对话框不会出现而是一闪而过立即被释放
//        dlg->resize(120,30);
//        dlg->show();
//        //设置属性 55号
//        //原因：上面的代码在堆区开辟内存，树结构中，我们在程序结束时才释放内存
//        //存在一种清空，一直new QDialog申请内存，然后关闭模态对话框，循环进行，而不关闭主窗口。
//        //一定时间后可能会造成内存溢出

//        //make Qt delete this widget when the widget accepted the close event.
//        dlg->setAttribute(Qt::WA_DeleteOnClose);

//        qDebug() << "弹出对话框";


        //QMessageBox 对话框

        //1.错误提示
//        QMessageBox::critical(this,"critical","错误");
        //2.信息提示
//        QMessageBox::information(this,"info","信息提示！");
        //3.询问提示
        //第五个参数是默认关联回车的按键
        //返回值都是StandardButton类型的，可以直接判断
//        if(QMessageBox::Save ==  QMessageBox::question(this,"question","询问！",QMessageBox::Save|QMessageBox::Cancel,QMessageBox::Cancel))
//        {
//            qDebug() << "选择的是保存";
//        }else
//        {
//            qDebug() << "选择的是取消";
//        }

        //4.警告提示
//        QMessageBox::warning(this,"warning","警告");

        //颜色对话框
        QColor color = QColorDialog::getColor(QColor(255,0,0));
        //获取颜色的分量
        qDebug() << color.red() << color.blue() << color.green();

        //字体对话框
        bool* ok;
        QFont font = QFontDialog::getFont(ok,QFont("楷体",36));
        qDebug() << "字体：" << font.family() << "字号：" << font.pointSize()
                 << "加粗：" << font.bold() << "倾斜：" << font.italic();

        //文件对话框
        QString string = QFileDialog::getOpenFileName(this,"打开文件","C:\\Users\\Administrator\\Desktop","(*.txt *.doc)");
        qDebug() << string;
    });
}

MainWindow::~MainWindow()
{
    delete ui;
}

