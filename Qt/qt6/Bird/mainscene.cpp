#include "mainscene.h"
#include "ui_mainscene.h"
#include <QPainter>

MainScene::MainScene(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::MainScene)
{
    ui->setupUi(this);

    //设置图标
    this->setWindowIcon (QIcon(":/Bird/birdIcon.ico"));

    //创建鸟对象
    this->m_bird = new Bird;
    //显示到当前窗口中
    this->m_bird->setParent (this);
    //设置窗口尺寸
    this->setFixedSize (this->m_bird->width (),this->m_bird->height ());

    //启动定时器
    this->m_bird->running ();

    //监听抛出的自定义切图的信号
    connect (this->m_bird,&Bird::changePix,[=](){
        //手动调用绘图事件
        update ();
    });

    //监听拖拽移动的信号
    connect (this->m_bird,&Bird::moveing,[=](QPoint point){
        this->move (point);

        this->m_auto_pos = point;//鼠标拖拽时更新当前窗口的位置
    });

    //定时器对象
    this->timer = new QTimer(this);

    //启动定时器
    this->timer->start (30);

    //获取屏幕信息
    QRect rec = QApplication::primaryScreen ()->geometry ();

    //监听定时器
    connect (this->timer,&QTimer::timeout,[=](){

        //如果鼠标没有按下，才自动向前移动
        if(this->m_bird->mouseDown != true)
        {
            this->m_auto_pos.setX (this->m_auto_pos.x () + 5);
        }

        if(this->m_auto_pos.x () > rec.width ())
        {
            this->m_auto_pos.setX (-this->m_bird->width ());
        }

        //窗口同步移动
        this->move (this->m_auto_pos);


    });

    //去掉标题栏
    this->setWindowFlags (Qt::FramelessWindowHint);

    //设置透明窗体
    this->setAttribute (Qt::WA_TranslucentBackground);

    //设置窗口顶层
    this->setWindowFlags (this->windowFlags () | Qt::WindowStaysOnTopHint);

    //设置起始Y的位置
    this->m_auto_pos.setY (rec.height () * 0.5 - this->m_bird->height ());
}

MainScene::~MainScene()
{
    delete ui;
}

void MainScene::paintEvent(QPaintEvent * event)
{
    QPainter painter(this);
    painter.drawPixmap (0,0,this->m_bird->m_bird_pix);
}

