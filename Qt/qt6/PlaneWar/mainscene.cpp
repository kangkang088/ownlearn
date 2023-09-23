#include "mainscene.h"
#include "config.h"
#include <QIcon>
#include <QPainter>
#include <QMouseEvent>
#include <ctime>
#include <QSoundEffect>

MainScene::MainScene(QWidget *parent)
    : QWidget(parent)
{
    //初始化
    this->initScene ();

    //启动游戏
    this->playGame ();
}

MainScene::~MainScene()
{
}

void MainScene::initScene()
{
    //设置窗口固定尺寸和标题
    this->setFixedSize (GAME_WIDTH,GAME_HEIGHT);
    this->setWindowTitle (GAME_TITLE);

    //加载图标
    this->setWindowIcon (QIcon(GAME_ICON));

    //定时器设置
    this->m_timer.setInterval (GAME_RATE);//定时器刷新频率10ms
    
    //敌机出场时间间隔初始化
    this->m_recorder = 0;

    //随机数种子
    srand( (unsigned int)time(NULL) );
}

void MainScene::playGame()
{
    //启动背景音乐
    QSoundEffect * soundBackground = new QSoundEffect(this);
    soundBackground->setSource (QUrl::fromLocalFile (SOUND_BACKGROUND));
    soundBackground->play ();

    //启动定时器
    this->m_timer.start ();

    //监听定时器发送的信号
    connect (&this->m_timer,&QTimer::timeout,[=](){
        //敌机出场
        this->enemyToScene ();

        //更新游戏中元素坐标
        this->updataPosition ();
        //绘制到屏幕中
        update ();

        //碰撞检测
        this->collisionDetection ();
    });
}

void MainScene::updataPosition()
{
    //更新地图坐标
    m_map.mapPosition ();

    //发射子弹
    this->m_hero.shoot ();

    //计算所有非空闲子弹的当前坐标
    for(int i = 0;i<BULLET_NUM;i++)
    {
        //如果非空闲，计算发射的位置
        if(this->m_hero.m_bullets[i].m_Free == false)
        {
            this->m_hero.m_bullets[i].updatePosition ();
        }
    }

    //敌机出场
    for(int i = 0;i < ENEMY_NUM;i++)
    {
        if(this->m_enemys[i].m_Free == false)
        {
            this->m_enemys[i].updatePosition ();
        }
    }

    //计算爆炸的播放图片
    for(int i = 0;i<BOMB_NUM;i++)
    {
        if(this->m_bomb[i].m_Free == false)
        {
            this->m_bomb[i].updateInfo ();
        }
    }

    //测试子弹
//    this->temp_Bullet.m_Free = false;
//    this->temp_Bullet.updatePosition ();
}

void MainScene::paintEvent(QPaintEvent *event)
{
    QPainter painter(this);

    //绘制地图
    painter.drawPixmap (0,m_map.m_map1_posY,m_map.m_map1);
    painter.drawPixmap (0,m_map.m_map2_posY,m_map.m_map2);

    //绘制英雄飞机
    painter.drawPixmap (this->m_hero.m_X,this->m_hero.m_Y,this->m_hero.m_Plane);

    //绘制子弹
    for(int i = 0;i<BULLET_NUM;i++)
    {
        //如果非空闲，计算发射的位置
        if(this->m_hero.m_bullets[i].m_Free == false)
        {
            painter.drawPixmap (this->m_hero.m_bullets[i].m_X,this->m_hero.m_bullets[i].m_Y,this->m_hero.m_bullets[i].m_Bullet);
        }
    }

    //绘制敌机
    for(int i = 0;i < ENEMY_NUM;i++)
    {
        if(this->m_enemys[i].m_Free == false)
        {
            painter.drawPixmap (this->m_enemys[i].m_X,this->m_enemys[i].m_Y,this->m_enemys[i].m_enemy);
        }
    }

    //绘制爆炸
    for(int i = 0;i<BOMB_NUM;i++)
    {
        if(this->m_bomb[i].m_Free == false)
        {
            painter.drawPixmap (this->m_bomb[i].m_X,this->m_bomb[i].m_Y,
                               this->m_bomb[i].m_pixArr[this->m_bomb[i].m_index]);
        }
    }

    //测试子弹
//    painter.drawPixmap (this->temp_Bullet.m_X,this->temp_Bullet.m_Y,this->temp_Bullet.m_Bullet);
}

void MainScene::mouseMoveEvent(QMouseEvent *event)
{
    int x = event->x () - this->m_hero.m_Rect.width () * 0.5;
    int y = event->y () - this->m_hero.m_Rect.height () * 0.5;

    //边界检测
    if(x <= 0 )
    {
        x = 0;
    }
    if(x >= GAME_WIDTH - m_hero.m_Rect.width())
    {
        x = GAME_WIDTH - m_hero.m_Rect.width();
    }
    if(y <= 0)
    {
        y = 0;
    }
    if(y >= GAME_HEIGHT - m_hero.m_Rect.height())
    {
        y = GAME_HEIGHT - m_hero.m_Rect.height();
    }

    this->m_hero.setPosition (x,y);
}

void MainScene::enemyToScene()
{
    this->m_recorder++;
    
    //未达到出场间隔，直接return
    if(this->m_recorder < ENEMY_INTERVAL)
    {
        return;
    }

    //达到出场间隔
    this->m_recorder = 0;
    for(int i = 0;i <ENEMY_NUM;i++)
    {
        if(this->m_enemys[i].m_Free)
        {
            this->m_enemys[i].m_Free = false;

            //坐标
            this->m_enemys[i].m_X = rand() % (GAME_WIDTH - this->m_enemys[i].m_Rect.width ());
            this->m_enemys[i].m_Y = -this->m_enemys[i].m_Rect.height ();
            break;
        }
    }
}

void MainScene::collisionDetection()
{
    //遍历所有非空闲敌机
    for(int i = 0;i < ENEMY_NUM;i++)
    {
        //如果是空闲的，找下一个
        if(this->m_enemys[i].m_Free)
        {
            continue;
        }

        //遍历所有非空闲子弹
        for(int j = 0;j<BULLET_NUM;j++)
        {
            //空闲子弹，执行下一次操作
            if(this->m_hero.m_bullets[i].m_Free)
            {
                continue;
            }

            //子弹和飞机都不是空闲的，执行碰撞检测
            //相交-碰撞发生，同时将飞机和子弹的空闲状态设置为true
            if(this->m_enemys[i].m_Rect.intersects (this->m_hero.m_bullets[i].m_Rect))
            {
                this->m_enemys[i].m_Free = true;
                this->m_hero.m_bullets[i].m_Free = true;

                //播放爆炸效果
                for(int k = 0;k < BOMB_NUM;k++)
                {
                    if(this->m_bomb[k].m_Free)
                    {
                        //播放爆炸音效
                        QSoundEffect * soundBomb = new QSoundEffect(this);
                        soundBomb->setSource (QUrl::fromLocalFile (SOUND_BOMB));
                        soundBomb->play ();
                        //空闲的爆炸
                        this->m_bomb[k].m_Free = false;
                        //更新坐标
                        this->m_bomb[k].m_X = this->m_enemys[i].m_X;
                        this->m_bomb[k].m_Y = this->m_enemys[i].m_Y;
                        break;
                    }
                }
            }
        }


    }
}

