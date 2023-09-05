#include "circle.h"
double Circle::getR()
{
	return this->m_r;
}
void Circle::setR(double r)
{
	this->m_r = r;
}
void Circle::setCenter(Point center)
{
	this->m_center = center;
}
Point Circle::getCenter()
{
	return this->m_center;
}
