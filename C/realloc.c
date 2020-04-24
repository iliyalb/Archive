#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[])
{
    char *str;

    /* Initial memory allocation */
    str = (char *)malloc(15 * sizeof(char));
    strcpy(str, "example");
    printf("ADDRESS: %p , VALUE: %s\n", str, str);

    /* Reallocation */
    str = (char *)realloc(str, 25 * sizeof(char));
    strcat(str, ".net");
    printf("ADDRESS: %p , VALUE: %s\n", str, str);

    /* Freeing up memory */
    free(str);
    str = NULL;

    return 0;
}