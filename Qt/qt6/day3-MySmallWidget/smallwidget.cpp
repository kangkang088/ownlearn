#include "smallwidget.h"
#include "ui_smallwidget.h"

SmallWidget::SmallWidget(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::SmallWidget)
{
    ui->setupUi(this);

    //spinBox改变，slider跟着滑动
    void(QSpinBox:: * signal)(int) = &QSpinBox::valueChanged;
    connect(ui->spinBox,signal,ui->horizontalSlider,&QSlider::setValue);
    //slider移动，spinbox改变
    connect(ui->horizontalSlider,&QSlider::valueChanged,ui->spinBox,&QSpinBox::setValue);

}

SmallWidget::~SmallWidget()
{
    delete ui;
}
//设置数据
void SmallWidget::setData(int val)
{
    ui->horizontalSlider->setValue(val);
}
//获取数据
int SmallWidget::getData()
{
    return ui->horizontalSlider->value();
}
