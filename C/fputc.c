#include <stdio.h>

int main(int argc, char *argv[])
{
    FILE *fp;

    fp = fopen("file.txt", "w+");

    for (int ch = 0; ch <= 100; ch++)
    {
        fputc(ch, fp);
    }

    fclose(fp);
    fp = NULL;

    return 0;
}