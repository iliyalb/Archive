#include <cmath>
#include <iostream>
#include <windows.h>

float position(float x, float y)
{
	COORD cd;
	cd.X = x + 60; cd.Y = y + 30;
	return SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), cd);
}

int main(int argc, char** argv)
{
	float x, y, angle = 0.0f;

	for (float i = 0; i < 200; i+=0.75)
	{
		angle = 0.1 * i;
		x = (angle)*cos(angle);
		y = (angle)*sin(angle);
		position(x, y);
		std::cout << "*";
		Sleep(1);
	}

}