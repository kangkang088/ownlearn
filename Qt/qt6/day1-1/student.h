#ifndef STUDENT_H
#define STUDENT_H

#include <QObject>

class Student : public QObject
{
    Q_OBJECT
public:
    explicit Student(QObject *parent = nullptr);
    //槽函数 写到public slots下，在高级版本下，public、全局函数、或者lambda表达式下都可以
    //返回值 void
    //可以有参数，可以重载
signals:
public slots:
    void treat();

    void treat(QString foodName);
};

#endif // STUDENT_H
