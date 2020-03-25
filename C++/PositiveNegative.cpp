#include<iostream> 

int main()
{
	int a;
	std::cout << "Enter any non-zero Number : ";
	std::cin >> a;
	
	if(a != 0)
		(a > 0) ? std::cout << "Number is positive" : std::cout << "Number is negative";
	else
	{
		std::cout << "I said a non-zero number!\n";
		main();
	}

	return 0;
}