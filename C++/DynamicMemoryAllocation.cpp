#include <iostream>

int main()
{
	//Check memory reserved:
	std::cout << "Size of int: " << sizeof(int) << " bytes" << std::endl;

	//Memory reserved in compile time:
	int a = 10;

	//Memory reserved in runtime:
	int * p = new int;
	*p = 100;

	/*
	Delete allocated memory or the pointer
	will lose 100 in heap and cause a leak,
	a memory leak which affects the program
	*/

	//Point to another location
	delete p;
	p = &a;

	/* -------------------------------------------------- */

	//Reserves 400 bytes
	int A[100];

	//All static elements of array will be freed:
	delete[] A;

	//Proficient way to reserve memory in runtime:
	int input;
	std::cout << "\nEnter a number (eg. 10): "; std::cin >> input;

	//Dynamic Memory Allocation:
	int * B = new int[input];

	getchar();
	return 0;
}