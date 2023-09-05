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
        {"Áõ±¸",23,"ÄÐ"},
        {"¹ØÓð",22,"ÄÐ"},
        {"ÕÅ·É",20,"ÄÐ"},
        {"ÕÔÔÆ",21,"ÄÐ"},
        {"õõ²õ",19,"Å®"},
    };
    bubbleSort(h, sizeof(h) / sizeof(h[0]));
    for (int i = 0; i < 5; i++)
    {
        cout << h[i].name << h[i].age << h[i].gender << endl;
    }
}