#include "Author.h"
#include <iostream>

Author::Author(std::string name, std::string email, char gender)
{
	this->name = name;
	setEmail(email);

	if (!islower(gender))
	{
		gender = char(tolower(gender));
	}

	if (gender == 'm' || gender == 'f')
		this->gender = gender;
	else
	{
		this->gender = 'u';
		std::cout << "Unknown gender" << std::endl;
	}
}

std::string Author::getName() const
{
	return name;
}

std::string Author::getEmail() const
{
	return email;
}

void Author::setEmail(std::string email)
{
	size_t atIndex = email.find('@');
	if (atIndex != std::string::npos && atIndex != 0 && atIndex != email.length() - 1)
	{
		this->email = email;
	}
	else
	{
		std::cout << "Invalid Email" << std::endl;
		this->email = "";
	}
}

char Author::getGender() const
{
	return gender;
}

void Author::print()
{
	std::cout 
		<< std::endl << "Name: " << name 
		<< std::endl << "Gender: " << gender 
		<< std::endl << "Email: " << email 
		<< std::endl;
}
