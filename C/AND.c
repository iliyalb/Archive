#include <stdio.h>

int main(int argc, char *argv[])
{
    unsigned int a = 60; // 0011 1100
    unsigned int b = 13; // 0000 1101
    int result = a & b;  // 0000 1100

    printf("RESULT: %d", result);

    return 0;
}