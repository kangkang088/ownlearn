#ifndef MAINSCENE_H
#define MAINSCENE_H

#include <QWidget>
#include <QTimer>
#include "map.h"
#include "heroplane.h"
#include "bullet.h"
#include "enemyplane.h"
#include "bomb.h"

class MainScene : public QWidget
{
    Q_OBJECT

public:
    MainScene(QWidget *parent = nullptr);
    ~MainScene();

    
    //初始化场景
    void initScene();
    
    //启动游戏
    void playGame();
    //更新所有游戏的坐标
    void updataPosition();
    //绘制到屏幕中 qt的事件，不可更改函数名
    void paintEvent (QPaintEvent *event);

    //重写鼠标移动事件 用来控制飞机
    void mouseMoveEvent (QMouseEvent *event);

    //敌机出场
    void enemyToScene();

    //敌机数组
    EnemyPlane m_enemys[ENEMY_NUM];

    //敌机出场间隔记录
    int m_recorder;

    //地图对象
    Map m_map;

    //飞机对象
    HeroPlane m_hero;
    
    //定时器信息
    QTimer m_timer;

    //子弹对象(测试)
//    Bullet temp_Bullet;

    //碰撞检测
    void collisionDetection();

    //爆炸数组
    Bomb m_bomb[BOMB_NUM];

};
#endif // MAINSCENE_H
