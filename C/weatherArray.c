#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MONTHS 12
#define YEARS 5

int main(int argc, char *argv[])
{
    int year, month;
    float total, subTotal;

    time_t t;
    srand((unsigned)time(&t));

    float rain[YEARS][MONTHS];

    for (int i = 0; i < YEARS; i++)
    {
        for (int j = 0; j < MONTHS; j++)
        {
            rain[i][j] = (float)rand() / (float)(RAND_MAX / 5.0);
        }
    }

    printf("\nYEAR\t\tRAINFALL (inches)\n");

    for (year = 0, total = 0; year < YEARS; year++)
    {
        for (month = 0, subTotal = 0; month < MONTHS; month++)
        {
            subTotal += rain[year][month];
        }
        printf("%5d\t%15.1f\n", 2020 + year, subTotal);
        total += subTotal;
    }

    printf("\nThe yearly average is %.1f inches.\n", total / YEARS);
    printf("\nThe monthly average is:\n\n");
    printf("    Jan     Feb     Mar     Apr     May     Jun     Jul     Aug     Sep     Oct     Nov     Dec\n");

    for (month = 0; month < MONTHS; month++)
    {
        for (year = 0, subTotal = 0; year < YEARS; year++)
        {
            subTotal += rain[year][month];
        }
        printf("   %4.1f ",subTotal/YEARS);
    }

    printf("\n\n");

    return 0;
}