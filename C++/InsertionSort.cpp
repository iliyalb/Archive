#include <iostream>
#include <time.h>

void insertionSort(int[], int);

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

	insertionSort(newArray, 10);

	std::cout << "\nSorted: ";

	for (int i = 0; i < 10; i++)
	{
		std::cout << newArray[i] << ',';
	}

	return 0;
}

void insertionSort(int unsortedArray[], int size)
{
	int temp, j;
	for (int i = 0; i < size; i++)
	{
		j = i;
		while (j>0 && (unsortedArray[j - 1] > unsortedArray[j]))
		{
			temp = unsortedArray[j];
			unsortedArray[j] = unsortedArray[j - 1];
			unsortedArray[j - 1] = temp;
			j--;
		}
	}
}