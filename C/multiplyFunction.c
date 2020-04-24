#include <stdio.h>

int multiply(int, int);

int main(int argc, char *argv[])
{
    int result = multiply(10, 50);
    printf("%d", result);
    return 0;
}

int multiply(int x, int y)
{
    return x * y;
}