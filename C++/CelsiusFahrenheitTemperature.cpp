#include<iostream> 

int main()
{
	char T;
	float Temp, F, C;
	std::cout << "Enter F for Celsius to Fahrenheit" << std::endl;
	std::cout << "Enter C for Fahrenheit to Celsius" << std::endl;
	std::cout << "Type: ";
	std::cin >> T;
	std::cout << std::endl << "Temp: ";
	std::cin >> Temp;

	char Type = static_cast<char>(T);
	F = Temp;
	C = Temp;

	if (Type == 'c' || Type == 'C')
	{
		C = 5 * (F - 32) / 9;
		std::cout << F << "F is " << C << "C" << std::endl;
	}
		
	else if (Type == 'f' || Type == 'F')
	{
		F = (C * 9/5) + 32;
		std::cout << C << "C is " << F << "F" << std::endl;
	}
	else
		std::cout << "Something went wrong!" << std::endl;

}