#include "bird.h"

Bird::Bird(QWidget *parent)
    : QWidget{parent}
{
    //加载鸟的所有图片资源
    for(int i = 0;i<this->max;i++)
    {
        QString str = QString(":/Bird/bird%1").arg (i+1);
        this->m_bird_pix.load (str);
    }

    //设置鸟尺寸
    this->setFixedSize (this->m_bird_pix.width (),this->m_bird_pix.height ());

    //创建定时器对象
    this->timer = new QTimer(this);

    //启动定时器

    //监听定时器信号
    connect (timer,&QTimer::timeout,[=](){
        QString str = QString(":/Bird/bird%1").arg (this->min++);
        this->m_bird_pix.load (str);
        if(this->min > this->max)
        {
            this->min = 1;
        }

        //每一次切图，抛出自定义信号
        emit this->changePix ();
    });

    //创建菜单对象
    this->menu = new QMenu();

    //链接信号槽
    connect (this->menu->addAction("退出"),&QAction::triggered,[=](){
        exit (0);
    });
}

void Bird::running()
{
    //启动定时器
    this->timer->start (50);
}

void Bird::mousePressEvent(QMouseEvent *event)
{
    //鼠标按下，状态为真
    this->mouseDown = true;

    //鼠标按下时记录分量
    //event->globalPos () 鼠标点击位置的坐标
    //((QWidget)this->parent ()).frameGeometry ().topLeft () 当前窗口左上角坐标
    this->m_pos = event->globalPos () - ((QWidget*)this->parent ())->frameGeometry ().topLeft ();

    //如果是鼠标右键，弹出菜单
    if (event->button () == Qt::RightButton)
    {
        //弹出菜单  弹出位置和鼠标当前位置一致
        this->menu->popup (QCursor::pos ());
    }
    
    //如果退出菜单通过别的方式消失，小鸟应该继续向前飞
    connect (this->menu,&QMenu::aboutToHide,[=](){
        this->mouseDown = false;
    });
}

void Bird::mouseMoveEvent(QMouseEvent *event)
{
    //在移动过程中，反向获取窗口最终移动的位置
    emit this->moveing (event->globalPos () - this->m_pos);

}

void Bird::mouseReleaseEvent(QMouseEvent *event)
{
    //鼠标释放
    this->mouseDown = false;

}

