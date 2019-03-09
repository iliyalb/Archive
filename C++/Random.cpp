#include <iostream>
#include <cmath>
#include <ctime>
#include <Windows.h>

using namespace std;

int main()
{
	srand(time(NULL)); //randomize the seed for rand to make them unique, once per program

	for (int i = 0; i < 10; i++)
		cout << rand() % 10; //numbers from 0 to 10
		//(rand() % 10) + 5	numbers from 5 to 10

	return 0;
}