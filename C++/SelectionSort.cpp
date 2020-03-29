#include <iostream>
#include <time.h>

void selectionSort(int[], int);

int main()
{
	int newArray[10];

	srand(unsigned(time(0)));

	for (int i = 0; i < 10; i++)
	{
		newArray[i] = rand() % 100 + 1;
	}

	std::cout << "\nUnsorted: ";

	for (int i = 0; i < 10; i++)
	{
		std::cout << newArray[i] << ',';
	}

	selectionSort(newArray, 10);

	std::cout << "\nSorted: ";

	for (int i = 0; i < 10; i++)
	{
		std::cout << newArray[i] << ',';
	}

	return 0;
}

void selectionSort(int unsortedArray[], int size)
{
	for (int i = size - 1; i > 0; --i)
	{
		int temp, first = 0;
		for (int j = 1; j <= i; ++j)
		{
			if (unsortedArray[j] > unsortedArray[first])
				first = j;
			temp = unsortedArray[first];
			unsortedArray[first] = unsortedArray[i];
			unsortedArray[i] = temp;
		}
	}
}