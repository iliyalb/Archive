#include<iostream> 

int main()
{
	int n, t, r, sum = 0;
	std::cout << "Enter a number: "; std::cin >> n;
	t = n;

	while (t > 0) //123
	{
		r = t % 10; // 123 -> 3
		sum += r;
		t = t / 10; // 123 -> 12
	}

	std::cout << sum << std::endl;

	main();

	return 0;
}