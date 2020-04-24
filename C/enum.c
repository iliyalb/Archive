#include <stdio.h>
#include <stdbool.h>

int main(int argc, char *argv[])
{
    enum gender
    {
        unknown,
        male = 110,
        female
    }; //unknown = 0, male = 110, female = 111

    enum gender myGender = male;

    bool isMale = (myGender == female);

    printf("%s", isMale ? "true" : "false");

    return 0;
}