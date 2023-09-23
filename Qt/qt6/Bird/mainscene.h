#ifndef MAINSCENE_H
#define MAINSCENE_H

#include <QWidget>
#include "bird.h"


QT_BEGIN_NAMESPACE
namespace Ui { class MainScene; }
QT_END_NAMESPACE

class MainScene : public QWidget
{
    Q_OBJECT

public:
    MainScene(QWidget *parent = nullptr);
    ~MainScene();

    //鸟对象
    Bird * m_bird;

    //重写绘图事件
    void paintEvent(QPaintEvent * event);

    //记录自动移动的位置
    QPoint m_auto_pos;

    //自动移动的定时器
    QTimer * timer;




private:
    Ui::MainScene *ui;
};
#endif // MAINSCENE_H
