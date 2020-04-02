#include <iostream>
#include <math.h> 

class Rectangle
{
private:
	int length;
	int width;
public:
	void setData(int length, int width)
	{
		this->length = length;
		this->width = width;
	}

	int getArea()
	{
		return length * width;
	}
		
	friend double getPowerValue(Rectangle);
};

//FRIEND:
double getPowerValue(Rectangle rectangle)
{
	double value;
	value = pow(rectangle.length, rectangle.width);
	return value;
}


int main()
{
	Rectangle rectangle;

	rectangle.setData(2, 10);

	std::cout << "Result: " << getPowerValue(rectangle) << std::endl;

	return 0;
}