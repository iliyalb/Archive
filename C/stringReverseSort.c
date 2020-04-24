#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[])
{
    char str[100];
    char name[25][50], temp[25];
    int l, n;

    printf("Enter a string (no spaces): ");
    scanf("%s", str);

    l = strlen(str);

    printf("REVERSE: ");

    for (int i = l; i >= 0; i--)
    {
        printf("%c", str[i]);
    }

    printf("\n\nEnter number of strings: ");
    scanf("%d", &n);
    printf("Input %d strings: \n", n);

    for (int i = 0; i < n; i++)
    {
        scanf("%s", name[i]);
    }

    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j <= n - i; j++)
        {
            if (strcmp(name[j], name[j + 1]) > 0)
            {
                strncpy(temp, name[j], sizeof(temp) - 1);
                strncpy(name[j], name[j + 1], sizeof(name[j]) - 1);
                strncpy(name[j + 1], temp, sizeof(name[j] + 1) - 1);
            }
        }
    }

    printf("\nBUBBLE SORT: ");
    for (int i = 0; i <= n; i++)
    {
        printf("%s\n", name[i]);
    }

    return 0;
}