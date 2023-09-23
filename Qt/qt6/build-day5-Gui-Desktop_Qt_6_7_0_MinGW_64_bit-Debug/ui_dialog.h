/********************************************************************************
** Form generated from reading UI file 'dialog.ui'
**
** Created by: Qt User Interface Compiler version 6.7.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_DIALOG_H
#define UI_DIALOG_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QPushButton>

QT_BEGIN_NAMESPACE

class Ui_Dialog
{
public:
    QPushButton *pushButton;
    QPushButton *pushButton_2;
    QPushButton *pushButton_3;
    QPushButton *pushButton_4;
    QPushButton *pushButton_5;
    QPushButton *pushButton_6;

    void setupUi(QDialog *Dialog)
    {
        if (Dialog->objectName().isEmpty())
            Dialog->setObjectName("Dialog");
        Dialog->resize(800, 600);
        pushButton = new QPushButton(Dialog);
        pushButton->setObjectName("pushButton");
        pushButton->setGeometry(QRect(60, 130, 81, 31));
        pushButton_2 = new QPushButton(Dialog);
        pushButton_2->setObjectName("pushButton_2");
        pushButton_2->setGeometry(QRect(60, 180, 75, 23));
        pushButton_3 = new QPushButton(Dialog);
        pushButton_3->setObjectName("pushButton_3");
        pushButton_3->setGeometry(QRect(70, 220, 75, 23));
        pushButton_4 = new QPushButton(Dialog);
        pushButton_4->setObjectName("pushButton_4");
        pushButton_4->setGeometry(QRect(70, 260, 75, 23));
        pushButton_5 = new QPushButton(Dialog);
        pushButton_5->setObjectName("pushButton_5");
        pushButton_5->setGeometry(QRect(70, 300, 75, 23));
        pushButton_6 = new QPushButton(Dialog);
        pushButton_6->setObjectName("pushButton_6");
        pushButton_6->setGeometry(QRect(310, 120, 75, 23));

        retranslateUi(Dialog);

        QMetaObject::connectSlotsByName(Dialog);
    } // setupUi

    void retranslateUi(QDialog *Dialog)
    {
        Dialog->setWindowTitle(QCoreApplication::translate("Dialog", "Dialog", nullptr));
        pushButton->setText(QCoreApplication::translate("Dialog", "\347\254\254\344\270\200\347\247\215\347\224\250\346\263\225", nullptr));
        pushButton_2->setText(QCoreApplication::translate("Dialog", "\347\254\254\344\272\214\347\247\215\347\224\250\346\263\225", nullptr));
        pushButton_3->setText(QCoreApplication::translate("Dialog", "\347\254\254\344\270\211\347\247\215\347\224\250\346\263\225", nullptr));
        pushButton_4->setText(QCoreApplication::translate("Dialog", "\347\254\254\345\233\233\347\247\215\347\224\250\346\263\225", nullptr));
        pushButton_5->setText(QCoreApplication::translate("Dialog", "\347\254\254\344\272\224\347\247\215\347\224\250\346\263\225", nullptr));
        pushButton_6->setText(QCoreApplication::translate("Dialog", "\345\210\244\346\226\255\347\224\250\346\210\267\346\214\211\351\222\256", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Dialog: public Ui_Dialog {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_DIALOG_H
