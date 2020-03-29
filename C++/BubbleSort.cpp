#include <iostream>
#include <time.h>

int main()
{
	int temp;
	int newArray[10];

	srand(time(0));

	for (int i = 0; i < 10; i++)
	{
		newArray[i] = rand() % 10 + 1;
	}

	std::cout << "\nUnsorted: ";

	for (int i = 0; i < 10; i++)
	{
		std::cout << newArray[i] << ',';
	}

	// Bubble Sort (Nobody ever uses this inefficient sort)
	for (int i = 0; i < 10; i++)
	{
		for (int j = i + 1; j < 10; j++)
		{
			if (newArray[i] > newArray[j])
			{
				temp = newArray[i];
				newArray[i] = newArray[j];
				newArray[j] = temp;
			}
		}
	}

	std::cout << "\nSorted: ";

	for (int i = 0; i < 10; i++)
	{
		std::cout << newArray[i] << ',';
	}

	return 0;
}