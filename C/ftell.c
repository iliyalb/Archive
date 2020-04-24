#include <stdio.h>

int main(int argc, char *argv[])
{
    FILE *fp;
    int len;

    fp = fopen("file.txt", "r");

    if (fp == NULL)
    {
        perror("Error opening file");
        return -1;
    }

    fseek(fp, 0, SEEK_END);

    len = ftell(fp);
    fclose(fp);
    fp = NULL;

    printf("Total size of the file: %d bytes\n", len);

    return 0;
}