#include <iostream>
#include <random>
#include <time.h>

using namespace std;

class Point
{
private:
	int x, y;

public:
	int getX() 
	{
		return x;
	}

	int getY()
	{
		return y;
	}

	void set(int a, int b)
	{
		x = a;
		y = b;
	}

	void rnd()
	{
		srand((unsigned int)time(NULL));
		x = rand() % 10;
		y = rand() % 10;
	}

	void print()
	{
		cout << x << " " << y << endl;
	}
};

int main()
{
	//Declare
	Point p1, p2, p3;

	//Use
	p1.set(5, 2);
	p1.print(); //cout << p1.getX() << " " << p1.getY() << endl;

	p2.rnd();
	p2.print();

	p3 = p1;
	p3.print();

	cin.get();
	return 0;
}