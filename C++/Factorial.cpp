#include <iostream> 

int factorial(int);

int main()
{
	int number;
	std::cout << "Enter a number: "; std::cin >> number;

	std::cout << factorial(number) << std::endl;

	main();

	return 0;
}

int factorial(int n)
{
	int fact = 1;
	while (n >= 1)
	{
		fact = fact * n;
		n--;
	}
	return fact;
}