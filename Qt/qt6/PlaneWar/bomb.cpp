#include "bomb.h"

Bomb::Bomb()
{
    //将所有爆炸pixmap放入数组
    for(int i = 1;i <= BOMB_MAX;i++)
    {
        QString str = QString(BOMB_PATH).arg (i);
        this->m_pixArr.push_back (str);
    }
    
    //坐标设置
    this->m_X = 0;this->m_Y = 0;
    
    //空闲状态
    this->m_Free = true;

    //当前播放的图片下标
    this->m_index = 0;

    //播放爆炸间隔的记录
    this->m_Recoder = 0;
}

void Bomb::updateInfo()
{
    //空闲状态下，直接return
    if(this->m_Free)
    {
        return;
    }

    this->m_Recoder++;
    //如果爆炸时间未到达爆炸间隔，不需要换图
    if(this->m_Recoder < BOMB_INTERVAL)
    {
        return;
    }

    //重置记录
    this->m_Recoder = 0;

    //切换播放的爆炸图片 下标
    this->m_index++;

    //播放到最后一张后，重置为零，将爆炸重置为空闲
    if(this->m_index > BOMB_MAX - 1)
    {
        this->m_index = 0;
        this->m_Free = true;
    }
}
