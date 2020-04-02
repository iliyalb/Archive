#include <iostream>
#include <math.h> 

class ValueCalculator; // For Rectangle class to see

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
		
	friend class ValueCalculator;
};

//FRIEND CLASS:
class ValueCalculator
{
public:
	double getPowerValue(Rectangle rectangle)
	{
		double value;
		value = pow(rectangle.length, rectangle.width);
		return value;
	}
};


int main()
{
	Rectangle rectangle;

	rectangle.setData(2, 10);

	ValueCalculator vc;

	std::cout << "Result: " << vc.getPowerValue(rectangle) << std::endl;

	return 0;
}