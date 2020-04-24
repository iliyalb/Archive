#include <stdio.h>

struct date
{
    int month;
    int day;
    int year;
};

int main(int argc, char *argv[])
{
    struct date today;

    today.month = 4;
    today.day = 20;
    today.year = 2020;

    // Same as:
    //struct date today = {4, 20, 2020};
    // Or C11:
    //today = (struct date){4, 20, 2020};

    printf("Today's date is %i/%i/%.2i\n", today.month, today.day, today.year % 100);

    struct date thisYear = {.year = 2020};

    int century = today.year / 100 + 1;

    return 0;
}