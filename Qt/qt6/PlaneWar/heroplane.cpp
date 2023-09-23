#include "heroplane.h"
#include "config.h"

HeroPlane::HeroPlane()
{
    //初始化加载飞机图片资源
    this->m_Plane.load (HERO_PATH);

    //初始化飞机坐标
    this->m_X = (GAME_WIDTH - this->m_Plane.width ()) * 0.5;
    this->m_Y = GAME_HEIGHT - this->m_Plane.height ();

    //初始化矩形边框
    this->m_Rect.setWidth (this->m_Plane.width ());
    this->m_Rect.setHeight (this->m_Plane.height ());
    this->m_Rect.moveTo (this->m_X,this->m_Y);

}

void HeroPlane::shoot()
{
    //累加时间间隔记录变量

    this->m_recorder++;

    //记录变量未达到发射子弹的时间间隔，子弹不发射，return
    if(this->m_recorder<BULLET_INTERVAL)
    {
        return;
    }

    //达到了发射时间间隔
    this->m_recorder = 0;//重置
    //发射子弹
    for(int i = 0;i < BULLET_NUM;i++)
    {
        //如果是空闲子弹，发射
        if(this->m_bullets[i].m_Free)
        {
            //空闲状态修改
            this->m_bullets[i].m_Free = false;
            //设置子弹坐标
            m_bullets[i].m_X = m_X + m_Rect.width()*0.5 - 10;
            m_bullets[i].m_Y = m_Y - 25 ;
            break;
        }
    }
}

void HeroPlane::setPosition(int x, int y)
{
    this->m_X = x;
    this->m_Y = y;
    this->m_Rect.moveTo (this->m_X,this->m_Y);
}
