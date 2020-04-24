#include <stdio.h>
#include <string.h>

int main(int argc, char *argv[])
{
    char myString1[] = "To be ";
    char myString2[] = "or not to be";

    // copy & append
    char myStringAppend[(sizeof(myString1) - 1) + (sizeof(myString2) - 1)];
    strncpy(myStringAppend, myString1, sizeof(myStringAppend) - 1);
    strncat(myStringAppend, myString2, sizeof(myString2) - 1);
    strcat(myStringAppend, ", That is the question");
    printf("%s\n", myStringAppend);

    // length
    int myStrLen = strlen(myString1);

    // finding a character in string
    char lookFor = 'n';
    char *pFound = NULL;
    pFound = strchr(myStringAppend, lookFor);

    // finding string in string
    char lookForStr[] = "to be";
    char *pStrFound = NULL;
    pStrFound = strstr(myStringAppend, lookForStr);

    // token & delimiter
    const char del[2] = ",";
    char *token;
    token = strtok(myStringAppend, del);
    /*while (token != NULL)
    {
        printf(" %s\n", token);
        token = strtok(NULL, del);
    }*/

    return 0;
}