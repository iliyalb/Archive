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

	//Friend for output
	friend std::ostream & operator<<(std::ostream & o, Dummy obj)
	{
		o << obj.value;

		return o;
	}

	//Friend for input
	friend std::istream & operator>>(std::istream & i, Dummy & obj)
	{
		i >> obj.value;

		return i;
	}
};

int main()
{
	Dummy a(5);

	//Get value with a function
	std::cout << a.getValue() << std::endl;

	//Get value with a friend
	std::cout << a << std::endl;

	//Set value with a friend
	std::cout << "\nEnter the new value of a: ";
	std::cin >> a;
	std::cout << "\nValue changed to a: " << a << std::endl;

	system("pause");
	getchar();
	return 0;
}