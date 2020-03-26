/*
* Write a program to calculate the sume of following series:
* 1 + 1/2 + 1/3 + 1/4 + 1/5 + ... + 1/n
*	where n is given by user.
*/

#include<iostream> 

int main()
{
	int number, i;
	float sum = 0;
	std::cout << "\nEnter a number: "; std::cin >> number;

	for (i = 1; i <= number; i++)
	{
		sum = sum + 1.0 / i;
		std::cout << "1/" << i << " + ";
	}

	std::cout << "... + 1/n = " << sum;

	main();

	return 0;
}