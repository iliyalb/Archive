#include <stdio.h>

#define FUNDLEN 50

struct funds
{
    char bank[FUNDLEN];
    double bankfund;
    char save[FUNDLEN];
    double savefund;
};

double sum(struct funds moolah)
{
    return (moolah.bankfund + moolah.savefund);
}

int main(int argc, char *argv[])
{
    struct funds V = {"Night Central Bank", 71902020.77, "V's Savings and Loan", 1975.55};

    printf("TOTAL: $%.2f\n", sum(V));

    return 0;
}