#include <stdio.h>

int main(int argc, char *argv[])
{
    int number = 0;
    int *pNumber = NULL; // Always initialize pointer with null

    number = 10;

    printf("\nNUMBER VALUE: %d\n", number);
    printf("NUMBER ADDRESS: %p\n\n", &number);

    if (!pNumber) // Prevent uninitialized pointer
        pNumber = &number;

    printf("POINTER VALUE: %p\n", pNumber);              // Outputs number's address
    printf("POINTER ADDRESS: %p\n\n", (void *)&pNumber); // Outputs pointer's address

    printf("SIZE: %zd\n", sizeof(pNumber)); // Outputs pointer's size
    printf("VALUE: %d\n\n", *pNumber);      // Outputs pointer's value

    *pNumber += 15; // Changes the value not the address, because of *
    printf("NEW VALUE: %d\n\n", *pNumber);

    const int *pPointerExample1 = &number; // Value cannot be modified but Address can be changed to another value
    int *const pPointerExample2 = &number; // Address can't be changed
    void* pPointerExample3 = &number; // Type-independent flexible pointer

    return 0;
}