/* Write a program to ask user to enter numbers
* and display the amount of positive, negative and zeros
*/

#include<iostream> 

int number, positive = 0, negative = 0, zero = 0;

int main()
{
	std::cout << "\nEnter a number: "; std::cin >> number;

	if (number > 0)
	{
		positive++;
	}
	else if (number < 0)
	{
		negative++;
	}
	else
	{
		zero++;
	}

	std::cout << "Positive: " << positive << std::endl;
	std::cout << "Negative: " << negative << std::endl;
	std::cout << "Zero: " << zero << std::endl;

	main();

	return 0;
}