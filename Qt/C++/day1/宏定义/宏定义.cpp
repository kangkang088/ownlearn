#include <iostream>
using namespace std;
#define EXPR 2+2
#define EXPR_s (2+2)
int main()
{
    cout << EXPR * EXPR << endl;
    cout << EXPR_s * EXPR_s;
}