#include <iostream>
#include <time.h>

int binarySearch(int[], int, int);

int main()
{
	int number;
	int newArray[10];

	srand(time(0));

	for (int i = 0; i < 10; i++)
	{
		newArray[i] = rand() % 10 + 1;
	}

	std::cout << "\nEnter a number: "; std::cin >> number;
	
	int result = binarySearch(newArray, 10, number);

	if (result >= 0)
		std::cout << "Found: " << newArray[result] << " index: " << result;
	else
		std::cout << "Not Found";

	main();

	return 0;
}

int binarySearch(int array[], int size, int searchValue)
{
	int mid, low = 0, high = size - 1;

	while (low<=high)
	{
		mid = (low+high) / 2;
		if (searchValue == array[mid])
			return mid;
		else if (searchValue > array[mid])
			low = mid + 1;
		else
			high = mid - 1;
	}
	return -1;
}