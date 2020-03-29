#include <iostream>
#include <time.h>

const int size = 10;

int main()
{
	int newArray[size], temp;

	srand(unsigned(time(0)));

	for (int i = 0; i < size; i++)
	{
		newArray[i] = rand() % 100 + 1;
	}

	std::cout << "\nUnReversed: ";

	for (int i = 0; i < size; i++)
	{
		std::cout << newArray[i] << ',';
	}

	// Reverse
	for (int i = 0, j = size - 1; i < size / 2; i++, j--)
	{
		temp = newArray[i];
		newArray[i] = newArray[j];
		newArray[j] = temp;
	}

	std::cout << "\nReversed: ";

	for (int i = 0; i < size; i++)
	{
		std::cout << newArray[i] << ',';
	}

	return 0;
}