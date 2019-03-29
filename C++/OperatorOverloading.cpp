#include <iostream>

class Dummy
{
private:
	int value;
public:
	Dummy()
	{
		value = 0;
	}

	Dummy(int value)
	{
		this->value = value;
	}

	//Inline tells compiler to call return directly
	inline int getValue()
	{
		return value;
	}

	Dummy operator+(Dummy obj)
	{
		return Dummy(this->value + obj.value);
	}

	Dummy operator-(Dummy obj)
	{
		return Dummy(this->value - obj.value);
	}
};

int main()
{
	//Both are using the same constructor
	Dummy a(5);
	Dummy b = 15;

	//Operator overload
	Dummy c = a + b;
	Dummy d = a.operator-(b);

	std::cout << c.getValue() << std::endl;
	std::cout << d.getValue() << std::endl;

	getchar();
	return 0;
}