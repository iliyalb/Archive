#include<iostream> 

int main()
{
	int n;
	bool flag = false;
	std::cout << "Enter a number: "; std::cin >> n;

	for (int i = 2;i<n;i++)
	{
		if (n % i == 0)
		{
			flag = true;
			break;
		}
	}

	if(flag == false && n > 1)
		std::cout << "Prime" << std::endl;
	else
		std::cout << "Not Prime" << std::endl;


	main();

	return 0;
}