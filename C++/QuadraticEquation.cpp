#include<iostream> 
#include <math.h>

int main()
{
	float a, b, c, d, r1, r2;

	std::cout << "Enter value of a: "; std::cin >> a;
	std::cout << "Enter value of b: "; std::cin >> b;
	std::cout << "Enter value of c: "; std::cin >> c;

	d = (b * b) - 4 * a * c;

	if (d == 0)
	{
		r1 = (-b) / (2 * a);
		r2 = r1;
		std::cout << "Equal roots: " << r2 << std::endl;
	}
	else if (d > 0)
	{
		r1 = -(b + sqrt(d)) / (2 * a);
		r2 = -(b - sqrt(d)) / (2 * a);
		std::cout << "Distinct roots: " << r1 << " and " << r2 << std::endl;
	} 
	else
	{
		r1 = (-b) / (2 * a);
		r2 = sqrt(-d) / (2 * a);
		std::cout << "Imaginary roots: " << r1 << " and " << r2 << std::endl;
	}

	return 0;
}