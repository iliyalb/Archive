/* Write a function that gets two arguments being passed by reference
*	which sets the smaller of the two numbers to zero.
*/

#include <iostream> 

void zero_small(int&, int&);

int main()
{
	int number1, number2;

	std::cout << "\nEnter a 1st number: "; std::cin >> number1;
	std::cout << "Enter a 2nd number: "; std::cin >> number2;

	zero_small(number1, number2);
	std::cout << "Smaller number is now zero: " << number1 << " , " << number2;

	return 0;
}

void zero_small(int &a, int &b)
{
	if (a < b)
		a = 0;
	else
		b = 0;
}