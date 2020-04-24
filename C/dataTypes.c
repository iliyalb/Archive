/*
Author: NAME
Purpose: DESCRIPTION
Date: NOW

*/

#include <stdio.h>
#include <stdbool.h>

int main(int argc, char *argv[])
{
    char myCharacter = '\n';
    int myInteger = 24;
    signed short int mySignedShortInteger = -25;
    unsigned long int myUnsignedLongInteger = 1510751100L;
    float myFloat = 24.5;
    double myDouble = 55.5555555555e+10;
    long double myLongDouble = 1.50e+10L;
    _Bool myBoolean = 1;          //C89
    bool myAnotherBoolean = true; //C99

    printf("%c Result: %d", myCharacter, myBoolean);
    return 0;
}