//MUST INCLUDE HEADER:
#include "Constructor_Cat.h"

//Default constructor:
Cat::Cat()
{
	this->name = "Unnamed";
	this->age = 0;
}

Cat::Cat(std::string name, int age)
{
	this->age = age;
	this->name = name;
	Introduce();
}

int Cat::GetAge()
{
	return age;
}

std::string Cat::GetName()
{
	return name;
}

void Cat::Meow()
{
	std::cout << "Meow!" << std::endl;
}

void Cat::Introduce()
{
	Meow();
	std::cout << "My name is " << name << " and I'm " << age << " years old!" << std::endl;
}

//Example of Main.cpp to work with this class:

/*

#include "Constructor_Cat.h"

int main()
{
	Cat cat1("Sparky", 3);
	Cat cat2("Fluffy", 2);

	//Default constructor:
	Cat cat3;

	//Public call:
	cat1.Purr();

	system("pause");
	return 0;
}

*/