#include <iostream>
using namespace std;

struct Hero
{
    string name;
    int age;
    string gender;
};
void bubbleSort(Hero h[],int len)
{
    for (int i = 0; i < len-1; i++)
    {
        for (int j = 0; j < len - 1 - i; j++) {
            if (h[j].age>h[j+1].age)
            {
                Hero temp = h[j];
                h[j] = h[j + 1];
                h[j + 1] = temp;
            }
        }
    }
}
int main()
{
    Hero h[5] = {
        {"����",23,"��"},
        {"����",22,"��"},
        {"�ŷ�",20,"��"},
        {"����",21,"��"},
        {"����",19,"Ů"},
    };
    bubbleSort(h, sizeof(h) / sizeof(h[0]));
    for (int i = 0; i < 5; i++)
    {
        cout << h[i].name << h[i].age << h[i].gender << endl;
    }
}