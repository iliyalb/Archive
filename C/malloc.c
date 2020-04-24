#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
    int *pNumber_ = (int *)malloc(100);             // not optimal, will not work on all systems
    int *pNumber = (int *)malloc(25 * sizeof(int)); // better version because int is not 4 bytes in all systems

    if (!pNumber)
    {
        // check whether if there was a memory allocation failure
    }

    // Always release allocated memory when done using it to prevent leaks
    free(pNumber);
    pNumber = NULL;

    // There is a better function which allocates memory and initializes it
    int *pNumber2 = (int *)calloc(25, sizeof(int));

    // Reuse memory to allocate data
    realloc(pNumber2, 25);

    return 0;
}