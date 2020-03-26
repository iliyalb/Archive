#include<iostream> 

int main()
{
	char ch;
	std::cout << "Enter a character: "; std::cin >> ch;

	if (ch >= 65 && ch <= 90)
	{
		std::cout << static_cast<int>(ch) << " is Capital letter" << std::endl;
	}
	else if (ch >= 97 && ch <= 122)
	{
		std::cout << static_cast<int>(ch) << " is Small letter" << std::endl;
	}
	else if (ch >= 48 && ch <= 57)
	{
		std::cout << static_cast<int>(ch) << " is Digit" << std::endl;
	}
	else if ((ch > 0 && ch <= 96) || (ch >= 58 && ch <= 64) || 
		(ch >= 91 && ch <= 96) || (ch >= 123 && ch <= 127))
	{
		std::cout << static_cast<int>(ch) << " is Special" << std::endl;
	}

	main();

	return 0;
}