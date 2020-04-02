#include <iostream>

class SomeClass
{
private:
	double real;
	double imaginary;
public:
	SomeClass() {};
	SomeClass(double, double);
	SomeClass operator+(SomeClass);
	void print();
};

SomeClass::SomeClass(double real, double imaginary)
{
	this->real = real;
	this->imaginary = imaginary;
}

SomeClass SomeClass::operator+(SomeClass param)
{
	SomeClass temp;
	temp.real = real + param.real;
	temp.imaginary = imaginary + param.imaginary;
	return temp;
}

void SomeClass::print()
{
	std::cout << "a" << real << " + b" << imaginary << std::endl;
}

int main()
{
	SomeClass a(5.1, 1.5);
	SomeClass b(2.5, 5.3);
	SomeClass c;

	c = a + b; // Will use overloaded operator

	a.print();
	b.print();
	c.print();

	return 0;
}