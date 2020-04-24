#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>

int main(int argc, char *argv[])
{
    int number, guess, lives;
    time_t t;
    bool flag = false;

    srand((unsigned)time(&t));

    number = rand() % 101;

    printf("Welcome! Let's play a game, shall we?\n");

    for (lives = 7; lives > 0; lives--)
    {
        printf("You have %d tr%s left. ", lives, lives == 1 ? "y" : "ies");
        printf("Guess the number (1-100): ");
        scanf("%d", &guess);

        if (guess == number)
        {
            flag = true;
            break;
        }
        else if (guess < 0 || guess > 100)
        {
            printf("It's between 0 and 100. ");
        }
        else if (guess < number && lives > 1)
        {
            printf("Try higher. ");
        }
        else if (guess > number && lives > 1)
        {
            printf("Try lower. ");
        }
    }

    printf("The number was %d and %s Thanks for playing.", number, flag == true ? "you guessed it!" : "you didn't get it.");
    return 0;
}