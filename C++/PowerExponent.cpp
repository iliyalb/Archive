/* Write a function called power that takes two arguments:
*	a double value for n
*	and an int value for p
*	return the result as double
*/

#include <iostream> 

double power(double, int = 2);

int main()
{
	int p;
	double number;

	std::cout << "\nEnter a number: "; std::cin >> number;
	std::cout << "Enter an exponent: "; std::cin >> p;

	std::cout << "Result: " << power(number, p) 
		<< " , Square: " << power(number) << std::endl;

	main();

	return 0;
}

double power(double a, int b)
{
	double result = 1;

	for (int i = 1; i <= b; i++)
	{
		result = result * a;
	}

	return result;
}