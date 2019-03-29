#include <iostream>
#include <string>

namespace TextTools
{
	void PrintReverse(const char* text)
	{
		std::string temp = text;
		std::reverse(temp.begin(), temp.end());
		std::cout << temp << std::endl;
	}
}

int main()
{
	TextTools::PrintReverse("REVERSE");

	std::cin.get();
	return 0;
}