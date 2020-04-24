#include <stdio.h>
#include <stdlib.h>

#define FILENAME "file.txt"
#define FILENAME_CONVERTED "file_converted.txt"

int main(int argc, char *argv[])
{
    FILE *fp = NULL;
    FILE *fpc = NULL;

    char ch = '\0';

    fp = fopen(FILENAME, "r");

    if (fp == NULL)
    {
        perror("Error opening file");
        return -1;
    }

    fpc = fopen(FILENAME_CONVERTED, "w");

    if (fpc == NULL)
    {
        return -1;
    }

    while ((ch = fgetc(fp)) != EOF)
    {
        if (islower(ch))
        {
            ch = ch - 32;
        }

        fputc(ch, fpc);
    }

    fclose(fp);
    fclose(fpc);
    fpc = NULL;

    //rename("temp.txt", FILENAME);
    //remove("temp.txt");

    fp = fopen(FILENAME_CONVERTED, "r");

    if (fp == NULL)
    {
        return -1;
    }

    while ((ch = fgetc(fp)) != EOF)
    {
        printf("%c", ch);
    }

    fclose(fp);
    fp = NULL;

    return 0;
}