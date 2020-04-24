#include <stdio.h>

int main(int argc, char *argv[])
{
    FILE *fp;
    int c;
    int lines = 0;
    //char str[100];

    fp = fopen("file.txt", "r");

    if (fp == NULL)
    {
        perror("Error in opening file(s)");
        return (-1);
    }

    while ((c = fgetc(fp)) != EOF)
    {
        if (c == '\n')
            lines++;
        printf("%c", c);
    }

    /*if (fgets(str, 100, fp) != NULL)
    {
        printf("%s", str);
    }*/

    fclose(fp);
    fp = NULL;

    printf("\nTotal number of lines: %d\n", ++lines);

    return 0;
}