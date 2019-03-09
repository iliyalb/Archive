#include <iostream>
#include <Windows.h>

using namespace std;

void StartProgram(string filename)
{
	ShellExecute(NULL,"open",filename.c_str(),NULL,NULL,SW_SHOWNORMAL);
}

int main()
{
	StartProgram("mspaint");
	return 0;
}