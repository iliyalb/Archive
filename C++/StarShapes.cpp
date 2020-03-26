#include<iostream> 

int main()
{
	int i, j,k;

	for (i = 1; i <= 4; i++)
	{
		for (j = 1; j <= 10; j++)
			std::cout << '*';
		std::cout << std::endl;
	}

	std::cout << std::endl;

	for (i = 1; i <= 5; i++)
	{
		for (j = 1; j <= i; j++)
			std::cout << '*';
		std::cout << std::endl;
	}

	std::cout << std::endl;

	for (i = 1; i <= 5; i++)
	{
		for (k=5;k>i;k--)
		{
			std::cout << ' ';
		}

		for (j = 1; j <= i; j++)
			std::cout << '*';
		std::cout << std::endl;
	}

	std::cout << std::endl;

	for (i = 1; i <= 5; i++)
	{
		for (k = 5; k > i; k--)
		{
			std::cout << ' ';
		}

		for (j = 1; j < 2*i; j++)
			std::cout << '*';
		std::cout << std::endl;
	}

	std::cout << std::endl;

	for (i = 1; i <= 5; i++)
	{
		for (k = 5; k > i; k--)
		{
			std::cout << ' ';
		}

		for (j = 1; j < 2 * i; j++)
			std::cout << i;
		std::cout << std::endl;
	}

	std::cout << std::endl;

	for (i = 1; i <= 5; i++)
	{
		for (k = 5; k > i; k--)
		{
			std::cout << ' ';
		}

		for (j = i; j >= 1; j--)
			std::cout << j;

		for (int l = 2; l <= i; l++)
			std::cout << l;

		std::cout << std::endl;
	}

	return 0;
}