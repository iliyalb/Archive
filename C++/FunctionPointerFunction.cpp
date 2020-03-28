#include <iostream>
#include <string>

int arithmetic(int, int, int(*)(int, int));
int add(int, int);
int sub(int, int);

int main()
{
	int number1, number2;
	std::string func;
	std::cout << "Enter 1st value: "; std::cin >> number1;
	std::cout << "Enter 2nd value: "; std::cin >> number2;
	std::cout << "Enter function (add/sub): "; std::cin >> func;

	if (func == "add")
		std::cout << "RESULT: " << arithmetic(number1, number2, add);
	else
		std::cout << "RESULT: " << arithmetic(number1, number2, sub);

	return 0;
}

int arithmetic(int n1, int n2, int(*operation)(int,int))
{
	return (*operation)(n1, n2);
}

int add(int n1, int n2)
{
	return n1 + n2;
}

int sub(int n1, int n2)
{
	return n1 - n2;
}