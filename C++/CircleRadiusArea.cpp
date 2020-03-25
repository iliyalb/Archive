#include <iostream>

int main()
{
    float r, area;

    std::cout << "\nEnter radius of circle : ";
    std::cin >> r;
    area = 3.14 * r * r;
    std::cout << "Area of circle : " << area;

    return 0;
}