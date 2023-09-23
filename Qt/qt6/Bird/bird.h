#ifndef BIRD_H
#define BIRD_H

#include <QWidget>
#include <QPixmap>
#include <QTimer>
#include <QPoint>
#include <QMouseEvent>
#include <QMenu>

class Bird : public QWidget
{
    Q_OBJECT
public:
    explicit Bird(QWidget *parent = nullptr);

    //鸟显示的图片资源
    QPixmap m_bird_pix;

    //最小值下标
    int min = 1;
    //最大值小标
    int max = 8;

    //定时器
    QTimer * timer;

    //执行动画
    void running();

    //记录分量坐标
    QPoint m_pos;

    //重写鼠标按下事件
    void mousePressEvent (QMouseEvent *event);
    //重写鼠标移动事件
    void mouseMoveEvent (QMouseEvent *event);

    //鼠标释放事件
    void mouseReleaseEvent (QMouseEvent *event);

    //鼠标按下的状态
    bool mouseDown = false;

    //右键菜单
    QMenu * menu;

signals:
    //自定义信号提示painter正在切换图片
    void changePix();
    //自动有信号，代表拖拽后主窗口应该移动的位置
    void moveing(QPoint point);

};

#endif // BIRD_H
