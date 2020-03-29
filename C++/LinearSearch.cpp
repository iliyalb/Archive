#include <iostream>
#include <time.h>

int linearSearch(int[], int, int);

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
	
	int result = linearSearch(newArray, 10, number);

	if (result >= 0)
		std::cout << "Found: " << newArray[result] << " index: " << result;
	else
		std::cout << "Not Found";

	main();

	return 0;
}

int linearSearch(int array[], int size, int searchValue)
{
	for (int i = 0; i < size; i++)
	{
		if (searchValue == array[i])
			return i;
	}
	return -1;
}