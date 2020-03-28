#include <iostream>
#include <string>

struct person
{
	char name[100];
	int age;
	float salary;
};

void displayPerson(person);

int main()
{
	person p;

	std::cout << "Enter Name: "; std::cin.get(p.name, 100);
	std::cout << "Enter Age: "; std::cin >> p.age;
	std::cout << "Enter Salary: "; std::cin >> p.salary;

	displayPerson(p);

	return 0;
}

void displayPerson(person p)
{
	std::cout << "\nInfo: " << std::endl;
	std::cout << "Name: " << p.name << std::endl;
	std::cout << "Age: " << p.age << std::endl;
	std::cout << "Salary: " << p.salary << std::endl;
}