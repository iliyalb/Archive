#include <iostream>

class Number
{
public:
	int number;

	Number()
	{
		number = 0;
	}

	~Number(){}

	Number& add(int number)
	{
		this->number += number;
		return *this;
	}

	Number& sub(int number)
	{
		this->number -= number;
		return *this;
	}
};

int main()
{
	// We Are :p
	Number One;

	One.add(10).sub(5).add(100);

	std::cout << One.number;
	
	return 0;
}