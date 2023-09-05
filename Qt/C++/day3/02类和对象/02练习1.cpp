//#include <iostream>
//using namespace std;
//
//class Cube
//{
//    double m_l;
//    double m_w;
//    double m_h;
//public:
//    double getL()
//    {
//        return this->m_l;
//    }
//    double getW()
//    {
//        return this->m_w;
//    }
//    double getH()
//    {
//        return this->m_h;
//    }
//    void setLWH(double length, double width, double height)
//    {
//        this->m_l = length;
//        this->m_w = width;
//        this->m_h = height;
//    }
//    double getArea()
//    {
//        return (m_h * m_l + m_h * m_w + m_l * m_w) * 2;
//    }
//    double getV()
//    {
//        return m_h * m_l * m_w;
//    }
//    //成员函数判断是否相等
//    void compare(Cube c)
//    {
//        if (this->getH()==c.getH()&& this->getL() == c.getL()&& this->getW() == c.getW())
//        {
//            cout << "两个立方体相等" << endl;
//        }
//        else
//        {
//            cout << "两个立方体不相等" << endl;
//        }
//    }
//};
//double getArea(Cube c)
//{
//    return c.getArea();
//}
//double getV(Cube c)
//{
//    return c.getV();
//}
////全局函数判断是否相等
//void compare(Cube& c1, Cube& c2)
//{
//    if (c1.getW() == c2.getW()&& c1.getH() == c2.getH()&& c1.getL() == c2.getL())
//    {
//        cout << "两个立方体相等" << endl;
//    }
//    else
//    {
//        cout << "两个立方体不相等" << endl;
//    }
//}
//int main()
//{
//    Cube c1;
//    c1.setLWH(1.5, 2.8, 3.7);
//    Cube c2;
//    c2.setLWH(1.5, 2.8, 3.7);
//    cout << c1.getArea() << endl;
//    cout << c1.getV() << endl;
//    cout << getArea(c1) << endl;
//    cout << getV(c1) << endl;
//    compare(c1, c2);
//    c1.compare(c2);
//}