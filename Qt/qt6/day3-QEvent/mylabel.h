#ifndef MYLABEL_H
#define MYLABEL_H

#include <QLabel>

class MyLabel : public QLabel
{
    Q_OBJECT
public:
    explicit MyLabel(QWidget *parent = nullptr);

    //捕获鼠标进入
    void enterEvent(QEnterEvent *event);
    //捕获鼠标离开
    void leaveEvent(QEvent *event);
    //捕获鼠标按下
    void mousePressEvent(QMouseEvent *ev);
    //捕获鼠标释放
    void mouseReleaseEvent(QMouseEvent *ev);
    //捕获鼠标移动
    void mouseMoveEvent(QMouseEvent *ev);

    //时间分发器
    bool event(QEvent *e);

signals:

};

#endif // MYLABEL_H
