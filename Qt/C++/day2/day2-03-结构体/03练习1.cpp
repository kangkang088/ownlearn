//#include <iostream>
//using namespace std;
//
//struct Student
//{
//	string name;
//	int scores;
//};
//struct Teacher
//{
//	string name;
//	Student s[5];
//};
//void setInfo(Teacher teacher[], int len, int size)
//{
//	string name = "ABCDEF";
//	/*int score = 15;*/
//	for (int i = 0; i < len; i++)
//	{
//		teacher[i].name = "Teacher";
//		teacher[i].name += name[i];
//		for (int j = 0; j < size; j++)
//		{
//			teacher[i].s[j].name = "Student";
//			teacher[i].s[j].name += name[j];
//			int random = rand() % 61 + 40;
//			teacher[i].s[j].scores = random;
//		}
//	}
//}
//void printInfo(Teacher teacher[], int len, int size)
//{
//	for (int i = 0; i < len; i++)
//	{
//		cout << teacher[i].name << endl;
//		for (int j = 0; j < size; j++)
//		{
//			cout << teacher[i].s[j].name << ',' << teacher[i].s[j].scores << endl;
//		}
//	}
//}
//int main()
//{
//	Teacher t[3];
//	srand((unsigned int)time(NULL));
//	int len = sizeof(t) / sizeof(t[0]);
//	int size = sizeof(t->s) / sizeof((t->s)[0]);
//	cout << size << endl;
//	setInfo(t, len, size);
//	printInfo(t, len, size);
//}