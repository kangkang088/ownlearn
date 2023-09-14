#ifndef MYWIDGET_H
#define MYWIDGET_H

#include <QWidget>

class MyWidget : public QWidget
{
    Q_OBJECT  //Q_OBJECT宏 支持QT中的信号和槽机制

public:
    MyWidget(QWidget *parent = nullptr);
    ~MyWidget();
};
#endif // MYWIDGET_H
