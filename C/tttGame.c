#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

char square[10] = {
    'o',
    '1',
    '2',
    '3',
    '4',
    '5',
    '6',
    '7',
    '8',
    '9',
};

int choice, player;

int check();
void display();
void mark(char);

int main(int argc, char *argv[])
{
    int status;
    char move;
    player = 1;

    do
    {
        display();

        player = (player % 2) ? 1 : 2;
        printf("Player %d, choose: ", player);
        scanf("%d", &choice);

        move = (player == 1) ? 'X' : 'O';
        mark(move);

        status = check();

        player++;

    } while (status == -1);

    if (status == 1)
    {
        printf("\n PLAYER %d WON!", --player);
    }
    else
    {
        printf("\n GAME DRAW!");
    }

    return 0;
}

int check()
{
    int value = 0;
    if (square[1] == square[2] && square[2] == square[3])
    {
        value = 1;
    }
    else if (square[4] == square[5] && square[5] == square[6])
    {
        value = 1;
    }
    else if (square[7] == square[8] && square[8] == square[9])
    {
        value = 1;
    }
    else if (square[1] == square[4] && square[4] == square[7])
    {
        value = 1;
    }
    else if (square[2] == square[5] && square[5] == square[8])
    {
        value = 1;
    }
    else if (square[3] == square[6] && square[6] == square[9])
    {
        value = 1;
    }
    else if (square[1] == square[5] && square[5] == square[9])
    {
        value = 1;
    }
    else if (square[3] == square[5] && square[5] == square[7])
    {
        value = 1;
    }
    else if (square[1] != '1' && square[2] != '2' && square[3] != '3' && square[4] != '4' && square[5] != '5' && square[6] != '6' && square[7] != '7' && square[8] != '8' && square[9] != '9')
    {
        value = 0;
    }
    else
    {
        value = -1;
    }

    return value;
}

void display()
{
    printf("\n\nTic Tac Toe\n\n");

    printf("Player 1 (X)    -   Player 2 (O) \n\n");

    printf("    |   |   \n");
    printf(" %c  | %c | %c  \n", square[1], square[2], square[3]);

    printf("____|___|___\n");
    printf("    |   |   \n");

    printf(" %c  | %c | %c  \n", square[4], square[5], square[6]);

    printf("____|___|___\n");
    printf("    |   |   \n");

    printf(" %c  | %c | %c  \n", square[7], square[8], square[9]);

    printf("    |   |   \n\n");
}

void mark(char m)
{
    if (choice == 1 && square[1] == '1')
    {
        square[1] = m;
    }
    else if (choice == 2 && square[2] == '2')
    {
        square[2] = m;
    }
    else if (choice == 3 && square[3] == '3')
    {
        square[3] = m;
    }
    else if (choice == 4 && square[4] == '4')
    {
        square[4] = m;
    }
    else if (choice == 5 && square[5] == '5')
    {
        square[5] = m;
    }
    else if (choice == 6 && square[6] == '6')
    {
        square[6] = m;
    }
    else if (choice == 7 && square[7] == '7')
    {
        square[7] = m;
    }
    else if (choice == 8 && square[8] == '8')
    {
        square[8] = m;
    }
    else if (choice == 9 && square[9] == '9')
    {
        square[9] = m;
    }
    else
    {
        printf("Invalid move, Press any key to continue... ");
        player--;
        getch();
    }
}