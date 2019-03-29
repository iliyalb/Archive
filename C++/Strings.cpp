#include <iostream>
#include <string>

using namespace std;

int main()
{
	char *str = "Hello,"; //C style string

	cout << str;

	char str2[64] = "World!"; //Array of chars

	cout << str2 << endl;

	string s = "I'm "; //C++ string class

	cout << s.at(0) << endl;

	string word;

	cout << "Type something: ";
	cin >> word;

	s += word; //Concatenate

	cout << s << endl;

	cout << s.replace(0, s.length(), "You're not") << endl;

	return 0;
}