#include <iostream>
#include <string> 

class Circle
{
private:
	double radius;
	std::string color;
public:
	//ctor
	Circle(double r = 1.0, std::string c = "red")
	{
		radius = r;
		color = c;
	}

	double getArea()
	{
		return radius * radius * 3.14;
	}

	double getRadius()
	{
		return radius;
	}

	std::string getColor()
	{
		return color;
	}
};

int main()
{
	Circle circle1();
	Circle circle2(4);
	Circle circle3(3, "green");

	std::cout << circle2.getRadius() << std::endl;
	std::cout << circle2.getArea() << std::endl;
	std::cout << circle3.getColor() << std::endl;

	return 0;
}