#include<iostream> 

int main()
{
	int number, days, months, years;
	std::cout << "Enter number of days: ";
	std::cin >> number;

	years = number / 365;
	number = number % 365; 
	months = number / 30;
	days = number % 30;

	std::cout << std::endl << "Years: " << years << " months: " << months << " days: " << days;
	return 0;
}