#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int stringLength(const char *);
void stringConcat(char *, const char *, const char *);
bool stringEqual(const char *, const char *);

int main(int argc, char *argv[])
{
    const char *sWord1 = "Yeah,";
    const char *sWord2 = "OK!";
    const char *sWord3 = "Have it your way";

    char sWordAppend[sizeof(sWord1) + sizeof(sWord2)];

    printf("LENGTH: %d  %d  %d \n", stringLength(sWord1), stringLength(sWord2), stringLength(sWord3));

    stringConcat(sWordAppend, sWord1, sWord2);

    printf("CONCAT: %s\n", sWordAppend);

    printf("EQUALS: %s , ", (stringEqual("Sure", "Sure") == true ? "TRUE" : "FALSE"));
    printf("EQUALS: %s\n", (stringEqual("sure", "SURE") == true ? "TRUE" : "FALSE"));

    return 0;
}

int stringLength(const char str[])
{
    int count = 0;

    while (str[count] != '\0')
    {
        count++;
    }

    return count;
}

void stringConcat(char result[], const char str1[], const char str2[])
{
    int i = 0, j = 0;

    for (i = 0; str1[i] != '\0'; i++)
    {
        result[i] = str1[i];
    }

    for (j = 0; str2[j] != '\0'; j++)
    {
        result[i + j] = str2[j];
    }

    result[i + j] = '\0';
}

bool stringEqual(const char str1[], const char str2[])
{
    int count = 0;
    bool isEqual = false;

    while (str1[count] == str2[count] && str1[count] != '\0' && str2[count] != '\0')
        count++;

    if (str1[count] == '\0' && str2[count] == '\0')
    {
        isEqual = true;
    }
    else
    {
        isEqual = false;
    }

    return isEqual;
}