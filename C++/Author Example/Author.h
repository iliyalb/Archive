#pragma once
#include <string>

class Author
{
private:
	std::string name;
	std::string email;
	char gender;
public:
	Author(std::string name, std::string email, char gender);
	std::string getName() const;
	std::string getEmail() const;
	void setEmail(std::string email);
	char getGender() const;
	void print();
};

