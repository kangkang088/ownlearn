#include "mainwindow.h"
#include <QMenuBar>
#include <QToolBar>
#include <QStatusBar>
#include <QLabel>
#include <QDockWidget>
#include <QTextEdit>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
{
    //重置窗口尺寸
    this->resize(600,400);

//1.菜单栏 最多只有一个
    QMenuBar * bar =  menuBar();

    //菜单栏设置到窗口中
    this->setMenuBar(bar);//如果菜单栏上没有任何菜单，则默认不显示

    //添加菜单
    QMenu * fileMenu =  bar->addMenu("文件");
    QMenu * editMenu =  bar->addMenu("编辑");
    //添加菜单项
    QAction * newAction1 =  fileMenu->addAction("新建");

    //添加分割线
    fileMenu->addSeparator();

    QAction * newAction2 =  fileMenu->addAction("打开");

    //菜单项中添加子菜单
    QMenu * subMenu = new QMenu;
    subMenu->addAction("子菜单1");
    subMenu->addAction("子菜单2");
    newAction1->setMenu(subMenu);

//2.工具栏 可以多个
    QToolBar * toolBar = new QToolBar;

    //将工具栏添加到窗口中
    //this->addToolBar(toolBar);
    this->addToolBar(Qt::LeftToolBarArea,toolBar);//重载版本,默认在左侧
    //设置只允许左右停靠
    toolBar->setAllowedAreas(Qt::LeftToolBarArea|Qt::RightToolBarArea);
    //设置浮动
    toolBar->setFloatable(false);//不浮动，自动回去
    //设置移动
    toolBar->setMovable(false);//不能移动，不能拖动了
    //添加菜单项
    toolBar->addAction(newAction1);

    //添加分割线
    toolBar->addSeparator();

    toolBar->addAction(newAction2);

//3.状态栏 只能一个
    QStatusBar * sBar =  statusBar();
    //设置状态栏到当前窗口
    this->setStatusBar(sBar);

    //标签控件
    QLabel * label1 = new QLabel("左侧信息",this);
    sBar->addWidget(label1);

    //右侧信息
    QLabel * label2 = new QLabel("右侧信息",this);
    sBar->addPermanentWidget(label2);

    //插入
    QLabel * label3 = new QLabel("左侧信息2",this);
    //sBar->addWidget(label3);//在label1的右边挨着
    //插入到开头位置
    //sBar->insertWidget(0,label3);//在label1的左边挨着，数字是下标
    sBar->insertPermanentWidget(0,label3);
//4.铆接部件 浮动窗口 可以多个
    QDockWidget * dock  = new QDockWidget("浮动窗口",this);
    this->addDockWidget(Qt::BottomDockWidgetArea,dock);
    //还是在上面显示，因为没有设置中心部件，这个铆接部件是围绕中心部件的
    //如果没有中心部件，则默认显示在当前窗口上面

    //只允许上或下
    dock->setAllowedAreas(Qt::TopDockWidgetArea|Qt::BottomDockWidgetArea);

//5.核心部件 中心部件 只能一个
    QTextEdit * edit = new QTextEdit(this);
    this->setCentralWidget(edit);//这时，铆接部件就在下面了






}

MainWindow::~MainWindow()
{
}

