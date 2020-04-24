#include <stdio.h>

#define MONTHS 12

int main(int argc, char *argv[])
{
    int monthDays[MONTHS] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    for (int i = 0; i < MONTHS; i++)
    {
        printf("Month %d has %2d days.\n", i+1, monthDays[i]);
    }

    return 0;
}