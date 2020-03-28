#include <iostream>

int main()
{
	// Array location in memory
	int SimpleArray[10];

	int* pLocation0 = &SimpleArray[0];
	int* pLocation5 = &SimpleArray[5];

	// Alocated memory varies by type
	std::cout << "pLocation0: " << pLocation0 << " = " << (int)pLocation0 << std::endl;
	std::cout << "pLocation5: " << pLocation5 << " = " << (int)pLocation5 << std::endl;
	std::cout << "Difference: " << pLocation5 - pLocation0 << std::endl;

	// Initializing Array
	for (int i = 0; i < 10; i++)
	{
		SimpleArray[i] = i;
	}

	std::cout << "\nLocation of stored values: " << std::endl;

	// Array value locations
	for (int i = 0; i < 10; i++)
	{
		std::cout << SimpleArray + i << " = " << *(SimpleArray + i) << std::endl;
		// Same as:
		// std::cout << pLocation0 << " = " << *pLocation0++ << std::endl;
	} 

	return 0;
}