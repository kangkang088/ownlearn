//#include <iostream>
//using namespace std;
//#include "circle.h"
//#include "point.h"
//void isInCenter(Circle c, Point p)
//{
//	double distance = (c.getCenter().getX() - p.getX()) * (c.getCenter().getX() - p.getX()) +
//		(c.getCenter().getY() - p.getY()) * (c.getCenter().getY() - p.getY());
//	double rDistance = c.getR() * c.getR();
//	if (distance == rDistance)
//	{
//		cout << "点在圆上" << endl;
//	}
//	else if(distance > rDistance)
//	{
//		cout << "点在园外" << endl;
//	}
//	else
//	{
//		cout << "点在园内" << endl;
//	}
//}
//int main()
//{
//	Circle c;
//	c.setR(10);
//	Point center;
//	center.setX(10);
//	center.setY(0);
//	c.setCenter(center);
//	Point p;
//	p.setX(21);
//	p.setY(0);
//	isInCenter(c, p);
//}