#include <stdio.h>
#include <stdlib.h>

#define FILENAME "file.txt"

int main(int argc, char *argv[])
{
    FILE *fp = NULL;

    int count = 0, i = 0;

    fp = fopen(FILENAME, "r");

    if (fp == NULL)
    {
        perror("Error opening file");
        return -1;
    }

    fseek(fp, 0, SEEK_END);

    count = ftell(fp);

    while (i < count)
    {
        i++;
        fseek(fp, -i, SEEK_END);
        printf("%c", fgetc(fp));
    }

    printf("\n");
    fclose(fp);
    fp = NULL;

    return 0;
}