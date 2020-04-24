#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
    float minutes, days, years;

    printf("Enter minutes: ");
    scanf("%f", &minutes);

    years = (minutes / (60 * 24 * 365));
    days = ((minutes / 60.0) / 24.0);

    printf("Approximately %f years and %f days", years, days);

    return 0;
}