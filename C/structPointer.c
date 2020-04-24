#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define SLEN 24

struct date
{
    int month;
    int day;
    int year;
};

struct iPointers
{
    int *pointer1;
    int *pointer2;
};

struct pNames
{
    char *first;
    char *last;
    int letters;
};

void getinfo(struct pNames *);

int main(int argc, char *argv[])
{
    // DATE EXAMPLE
    struct date today, *pDate;
    pDate = &today;

    pDate->month = 3;
    pDate->day = 23;
    pDate->year = 2004;

    printf("Today's date is %i/%i/%.2i\n", pDate->month, pDate->day, pDate->year % 100);

    // MEMORY EXAMPLE
    struct iPointers pointers;
    int number1 = 100, number2;

    pointers.pointer1 = &number1;
    pointers.pointer2 = &number2;
    *pointers.pointer2 = -100;

    printf("VALUE1: %i, ADDRESS1: %p\n", *pointers.pointer1, pointers.pointer1);
    printf("VALUE2: %i, ADDRESS2: %p\n", *pointers.pointer2, pointers.pointer2);

    return 0;
}

// NAME EXAMPLE
void getinfo(struct pNames *pst)
{
    char temp[SLEN];
    printf("Please enter your first name: ");
    s_gets(temp, SLEN);

    pst->first = (char *)malloc(strlen(temp) + 1);

    strcpy(pst->first, temp);
    printf("\nPlease enter your last name: ");
    s_gets(temp, SLEN);
    pst->last = (char *)malloc(strlen(temp) + 1);
    strcpy(pst->last, temp);
}