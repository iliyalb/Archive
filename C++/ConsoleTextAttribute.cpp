#include <iostream>
#include <Windows.h>

using namespace std;

int main()
{
	//HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),FOREGROUND_GREEN|FOREGROUND_INTENSITY);
	cout << "Hello World\n";
	system("pause");
	return 0;
}