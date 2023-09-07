//#include <iostream>
//using namespace std;
//
//class Calculator
//{
//public:
//    Calculator(){}
//    int getResult(string oper)
//    {
//        if (oper == "+")
//        {
//            return this->m_number1 + this->m_number2;
//        }
//        else if(oper == "-")
//        {
//            return this->m_number1 - this->m_number2;
//        }
//        else if (oper == "*")
//        {
//            return this->m_number1 * this->m_number2;
//        }
//        else if (oper == "/")
//        {
//            return this->m_number1 / this->m_number2;
//        }
//    }
//    int m_number1;
//    int m_number2;
//};
//void test1()
//{
//    Calculator c1;
//    c1.m_number1 = 10;
//    c1.m_number2 = 10;
//    cout << "+ =" << c1.getResult("+") << endl;
//    cout << "- =" << c1.getResult("-") << endl;
//    cout << "* =" << c1.getResult("*") << endl;
//    cout << "/ =" << c1.getResult("/") << endl;
//}
////¶àÌ¬
//class AbstractCalculator
//{
//public:
//    virtual int getResult()
//    {
//        return 0;
//    }
//    int m_num1;
//    int m_num2;
//};
//class AddCalculator :public AbstractCalculator
//{
//public:
//    virtual int getResult()
//    {
//        return m_num1 + m_num2;
//    }
//};
//class SubCalculator :public AbstractCalculator
//{
//public:
//    virtual int getResult()
//    {
//        return m_num1 - m_num2;
//    }
//};
//class MulCalculator :public AbstractCalculator
//{
//public:
//    virtual int getResult()
//    {
//        return m_num1 * m_num2;
//    }
//};
//void test2()
//{
//    AbstractCalculator *ac = new AddCalculator();
//    ac->m_num1 = 10;
//    ac->m_num2 = 10;
//    cout << ac->getResult() << endl;
//    delete ac;
//    ac = new SubCalculator();
//    ac->m_num1 = 10;
//    ac->m_num2 = 10;
//    cout << ac->getResult() << endl;
//    delete ac;
//    ac = new MulCalculator();
//    ac->m_num1 = 10;
//    ac->m_num2 = 10;
//    cout << ac->getResult() << endl;
//    delete ac;
//}
//int main()
//{
//    test1();
//    test2();
//}