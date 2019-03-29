#include <iostream>

template <class T>
class Sum
{
	T value;

	//template <class T, class M> T value; M value2;

public:
	Sum(T a, T b)
	{
		value = a + b;
	}

	T Result()
	{
		return value;
	}
};


int main()
{
	Sum<int> isum(1, 4);
	Sum<float> fsum(1.5, 4.2);

	std::cout << "Result 1: " << isum.Result() << std::endl;
	std::cout << "Result 2: " << fsum.Result() << std::endl;

	getchar();
	return 0;
}