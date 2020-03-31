#include <iostream>

class Shape
{
protected:
	double width, height;
public:
	void set_data(double a, double b)
	{
		width = a;
		height = b;
	}

	// virtual function:
	//virtual double area(){return 0;}

	// pure virtual function (abstract):
	virtual double area() = 0;
};

class Rectangle :public Shape
{
public:
	double area()
	{
		return (width * height);
	}
};

class Triangle : public Shape
{
public:
	double area()
	{
		return (width * height) / 2;
	}
};

int main()
{
	Shape* shapePointer;
	Rectangle rectangle;
	Triangle triangle;

	shapePointer = &rectangle;

	shapePointer->set_data(2, 5);

	std::cout << "Area of rectangle: " << shapePointer->area() << std::endl;
	// Without virtual member:
	//std::cout << static_cast<Rectangle*>(shapePointer)->area();

	shapePointer = &triangle;

	shapePointer->set_data(3, 4);

	std::cout << "Area of triangle: " << shapePointer->area() << std::endl;

	return 0;
}