#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#define _BUFFER_SIZE 128

int main(int argc, char *argv[])
{
    char buffer[_BUFFER_SIZE];
    int alpha = 0, digit = 0, punct = 0, counter = 0;

    printf("Enter a string (no spaces): ");
    scanf("%s", buffer);

    while (buffer[counter])
    {
        if (isalpha(buffer[counter]))
            ++alpha;
        else if (isdigit(buffer[counter]))
            ++digit;
        else if (ispunct(buffer[counter]))
            ++punct;
        counter++;
    }

    printf("Letters: %d , Numbers: %d , Punctuation: %d", alpha, digit, punct);

    return 0;
}