/*
* Armstrong number example:
* 153 = (1*1*1) + (5*5*5) + (3*3*3) equals itself
*/

#include<iostream> 

int main()
{
	int number, digit1, digit2, digit3;
	std::cout << "\nEnter a number: "; std::cin >> number;
	std::cout << "Armstrong numbers from 1 to " << number << " are: " << std::endl;

	for (int i = 1; i < number; i++)
	{
		digit1 = i / 100;
		digit2 = i / 10 - digit1 * 10;
		digit3 = i % 10;

		if (digit1 * digit1 * digit1 +
			digit2 * digit2 * digit2 +
			digit3 * digit3 * digit3 == i)
		{
			std::cout << i << std::endl;
		}
	}

	main();

	return 0;
}