#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main(int argc, char *argv[])
{
    int primesIndex, primes[50];
    bool isPrime;

    primesIndex = 2;
    primes[0] = 2;
    primes[1] = 3;

    //Finding prime numbers algorithm
    for (int i = 5; i <= 100; i += 2)
    {
        isPrime = true;

        for (int j = 1; i / primes[j] >= primes[j] && isPrime; ++j)
        {
            if (i % primes[j] == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime == true)
        {
            primes[primesIndex] = i;
            ++primesIndex;
        }
    }

    for (int i = 0; i < primesIndex; i++)
    {
        printf("%i ", primes[i]);
    }

    return 0;
}