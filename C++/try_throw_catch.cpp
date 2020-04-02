#include <iostream>
#include <string>

int division(int a, int b)
{
	if (b == 0)
		throw 1; //catch will get this value
	return a / b;
}

int main()
{
	int a, b;
	std::cout << "Enter 1st number: "; std::cin >> a;
	std::cout << "Enter 2nd number: "; std::cin >> b;

	try
	{
		std::cout << division(a, b) << std::endl;
	}
	catch (int& code)
	{
		std::cout << "ERROR CODE: " << code << std::endl;
	}
	catch (...)
	{
		std::cout << "UNKNOWN ERROR" << std::endl;
	}

	main();

	return 0;
}