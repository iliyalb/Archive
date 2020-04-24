#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
    double width, height, perimeter, area;

    printf("Enter width: ");
    scanf("%lf", &width);

    printf("Enter height: ");
    scanf("%lf", &height);

    perimeter = 2.0 * (width + height);
    area = width * height;

    printf("Perimeter: %.2f \t Area: %.2f", perimeter, area);

    return 0;
}