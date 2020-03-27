#include<iostream> 
#include<cctype>
#include<stdio.h>

int main()
{
	char ch;

	std::cout << "Enter a character: ";
	ch = getchar();

	if (isalpha(ch))
	{
		std::cout << "Alphabet" << std::endl;
	}
	else if (isdigit(ch))
	{
		std::cout << "Digit" << std::endl;
	}
	else
	{
		std::cout << "Special" << std::endl;
	}

	return 0;
}