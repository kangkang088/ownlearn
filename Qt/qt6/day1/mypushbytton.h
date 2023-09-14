#ifndef MYPUSHBYTTON_H
#define MYPUSHBYTTON_H

#include <QPushButton>

class MyPushBytton : public QPushButton
{
    Q_OBJECT
public:
    explicit MyPushBytton(QWidget *parent = nullptr);
    ~MyPushBytton();
signals:

};

#endif // MYPUSHBYTTON_H
