#include <iostream>
using namespace std;
int f(int x)
{
	
	if (x == 0)  return 0;
	
	return x + f(x - 1);
}
int main()
{
	cout << "f（3）=" << f(3) << endl;
}