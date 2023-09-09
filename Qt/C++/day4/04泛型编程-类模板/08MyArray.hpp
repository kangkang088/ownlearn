#pragma once
#include<iostream>
#include<fstream>
using namespace std;

template<class T>
class MyArray
{
public:
	//容量
	MyArray(int capacity)
	{
		cout << "MyArray的有参构造调用" << endl;
		this->m_capacity = capacity;
		this->m_size = 0;
		this->pAddress = new T[this->m_capacity];
	}
	//拷贝构造
	MyArray(const MyArray& arr)
	{
		cout << "MyArray的拷贝构造调用" << endl;
		this->m_capacity = arr.m_capacity;
		this->m_size = arr.m_size;
		//深拷贝
		this->pAddress = new T[arr.m_capacity];
		for (int i = 0; i < this->m_size; i++)
		{
			this->pAddress[i] = arr.pAddress[i];
		}
	}
	//operator =
	MyArray& operator= (const MyArray& arr)
	{
		cout << "MyArray的=构造调用" << endl;
		if (this->pAddress!=NULL)
		{
			delete[] pAddress;
			pAddress = NULL;
			this->m_capacity = 0;
			this->m_size = 0;
		}
		this->m_capacity = arr.m_capacity;
		this->m_size = arr.m_size;
		this->pAddress = new T[arr.m_capacity];
		for (int i = 0; i < this->m_size; i++)
		{
			this->pAddress[i] = arr.pAddress[i];
		}
		return *this;

	}
	//尾插法 插入书
	void pushBack(const T& value)
	{
		//判断容量和大小的关系
		if (this->m_capacity==this->m_size)
		{
			return;
		}
		this->pAddress[this->m_size] = value;
		this->m_size++;//插入后更新大小
	}
	//尾删法
	void popBack()
	{
		//让用户访问不到最后一个元素，即尾删（逻辑上）
		if (this->m_size==0)
		{
			return;
		}
		this->m_size--;
	}
	//用户通过下标访问
	// //重载[]
	T& operator[](int index)
	{
		return this->pAddress[index];
	}
	//返回数组的容量
	int getCapacity()
	{
		return this->m_capacity;
	}
	// 返回数组的大小
	int getSize()
	{
		return this->m_size;
	}
	//析构
	~MyArray()
	{
		if (this->pAddress!=NULL)
		{
			cout << "MyArray的析构调用" << endl;
			delete[] pAddress;
			pAddress = NULL;
		}
	}
private:
	T* pAddress;//堆区数组的地址
	int m_capacity;
	int m_size;
};