#include "bullet.h"

Bullet::Bullet()
{
    //加载子弹资源
    this->m_Bullet.load (BULLET_PATH);

    //子弹坐标
    this->m_X = GAME_WIDTH * 0.5 - this->m_Bullet.width ();
    this->m_Y = GAME_HEIGHT;

    //子弹状态 默认空闲
    this->m_Free = true;

    //子弹速度
    this->m_Speed = BULLET_SPEED;

    //子弹边框
    this->m_Rect.setWidth (this->m_Bullet.width ());
    this->m_Rect.setHeight (this->m_Bullet.height ());
    this->m_Rect.moveTo (this->m_X,this->m_Y);

}

void Bullet::updatePosition()
{
    //空闲状态下，子弹不需要计算坐标
    if(this->m_Free)
    {
        return;
    }

    //非空闲状态，子弹向上移动
    this->m_Y -=this->m_Speed;
    this->m_Rect.moveTo (this->m_X,this->m_Y);

    //子弹位置超出屏幕，重新变为空闲状态
    if(this->m_Y<=this->m_Rect.height ())
    {
        this->m_Free = true;
    }
}
