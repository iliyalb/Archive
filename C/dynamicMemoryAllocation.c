#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
    int size;
    char *text = NULL;

    printf("Enter desired text size (int): ");
    scanf("%d", &size);

    text = (char *)malloc(size * sizeof(char));

    if (text != NULL)
    {
        printf("Enter text: ");
        scanf(" ");
        gets(text);
        printf("RECEIVED: %s\n", text);
    }

    free(text);
    text = NULL;

    return 0;
}