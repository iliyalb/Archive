#include <iostream>

using namespace std;

int main()
{
	int *p, n = 0;

	p = &n; //Points to n

	cout << p << endl; //Outputs address

	cout << *p << endl; //Outputs value

	*p = 1;

	cout << n << endl; //*p changes original value

	(*p)++; //*p++ increments address instead of value

	system("pause");

	return 0;
}