#include <stdio.h>

int main(int argc, char *argv[])
{
    char str[100];
    int i;

    printf("Enter a value: ");
    scanf("%d %s", &i, str); //int, string

    printf("\nYou have entered: %d , %s", i, str);

    return 0;
}