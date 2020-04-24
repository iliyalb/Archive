#include <stdio.h>

void swapValue(int, int);
void swapReference(int *, int *);

int main(int argc, char *argv[])
{
    int a = 1, b = 2;
    printf("%d %d\n", a, b);

    swapReference(&a, &b);
    printf("%d %d\n", a, b);

    return 0;
}

void swapValue(int x, int y)
{
    int temp = x;
    x = y;
    y = temp;

    return;
}

// Better performance
void swapReference(int *x, int *y)
{
    int temp = *x;
    *x = *y;
    *y = temp;

    return;
}