#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QToolBar>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
//    QToolBar * tBar = new QToolBar;
//    this->addToolBar(tBar);
//    tBar->setAllowedAreas(Qt::TopToolBarArea);

    //ui->actionnew1->setIcon(QIcon("D:\\QT资料\\Qt_基础教程\\其他\\Image\\Luffy.png"));

    //导入资源
    //1.将资源放入到项目下
    //2.添加资源文件
    //2.1 右键项目，添加新文件，选择QT resourcefile，起名，生成后缀名为.qrc的文件
    //3.编辑资源文件
    //3.1右键，选择Open in editor
    //3.2添加前缀
    //3.3添加文件
    //4.使用资源
    //4.1语法："： + 前缀名 + 文件名"

    ui->actionnew1->setIcon(QIcon(":/Image/Luffy.png"));
    ui->actionopen->setIcon(QIcon(":/Image/LuffyQ.png"));



}

MainWindow::~MainWindow()
{
    delete ui;
}

