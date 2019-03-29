#pragma once

#include <iostream>
#include <string>

class Cat
{
private:
	int age;

	std::string name;

	void Meow();

public:
	//Default constructor:
	Cat();

	//Define constructor prototype:
	Cat(std::string name, int age);

	int GetAge();

	std::string GetName();

	void Introduce();

	//single-line statement:
	void Purr() { std::cout << "Purrr...\n"; };
};