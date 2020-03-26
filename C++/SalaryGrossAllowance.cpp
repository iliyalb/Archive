/* Write a program that checks the basic salary of an employee
* If basic salary is less than 1500 then output:
*	HRD = 10% of basic salary 
*	DA = 90% of basic salary
* If this salary is either equal or above 1500 then output:
*	HRA = 500 
*	DA = 98%
* HRA (House Rent Allowance)
* DA (Dearness Allowance)
*/

#include<iostream> 

int main()
{
	float basic_salary, gross_salary, HRA, DA;

	std::cout << "Enter salary: "; std::cin >> basic_salary;

	if (basic_salary < 1500)
	{
		HRA = (basic_salary * 0.1);
		DA = (basic_salary * 0.9);
		std::cout << "HRA is: " << HRA << std::endl;
		std::cout << "DA is: " << DA << std::endl;
	}
	else
	{
		HRA = 500;
		DA = (basic_salary * 0.98);
		std::cout << "HRA is: " << HRA << std::endl;
		std::cout << "DA is: " << DA << std::endl;
	}

	gross_salary = basic_salary + HRA + DA;

	std::cout << "Gross salary: " << gross_salary << std::endl;

	return 0;
}