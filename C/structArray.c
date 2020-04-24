#include <stdio.h>

struct date
{
    int month;
    int day;
    int year;
};

int main(int argc, char *argv[])
{
    struct date customDates[5] = {{11, 1, 2004}, {11, 16, 2004}, {11, 23, 2004}, [4] = {12, 24, 2004}};
    return 0;
}