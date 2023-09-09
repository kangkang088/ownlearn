#pragma once
#include<iostream>
#include<fstream>
using namespace std;

template<class T>
class MyArray
{
public:
	//����
	MyArray(int capacity)
	{
		cout << "MyArray���вι������" << endl;
		this->m_capacity = capacity;
		this->m_size = 0;
		this->pAddress = new T[this->m_capacity];
	}
	//��������
	MyArray(const MyArray& arr)
	{
		cout << "MyArray�Ŀ����������" << endl;
		this->m_capacity = arr.m_capacity;
		this->m_size = arr.m_size;
		//���
		this->pAddress = new T[arr.m_capacity];
		for (int i = 0; i < this->m_size; i++)
		{
			this->pAddress[i] = arr.pAddress[i];
		}
	}
	//operator =
	MyArray& operator= (const MyArray& arr)
	{
		cout << "MyArray��=�������" << endl;
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
	//β�巨 ������
	void pushBack(const T& value)
	{
		//�ж������ʹ�С�Ĺ�ϵ
		if (this->m_capacity==this->m_size)
		{
			return;
		}
		this->pAddress[this->m_size] = value;
		this->m_size++;//�������´�С
	}
	//βɾ��
	void popBack()
	{
		//���û����ʲ������һ��Ԫ�أ���βɾ���߼��ϣ�
		if (this->m_size==0)
		{
			return;
		}
		this->m_size--;
	}
	//�û�ͨ���±����
	// //����[]
	T& operator[](int index)
	{
		return this->pAddress[index];
	}
	//�������������
	int getCapacity()
	{
		return this->m_capacity;
	}
	// ��������Ĵ�С
	int getSize()
	{
		return this->m_size;
	}
	//����
	~MyArray()
	{
		if (this->pAddress!=NULL)
		{
			cout << "MyArray����������" << endl;
			delete[] pAddress;
			pAddress = NULL;
		}
	}
private:
	T* pAddress;//��������ĵ�ַ
	int m_capacity;
	int m_size;
};