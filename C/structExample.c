#include <stdio.h>

struct employee
{
    char name[50];
    char date[15];
    float salary;
};

int main(int argc, char *argv[])
{
    struct employee sEmployee = {"NAME", "MM/DD/YY", 00000.00f};

    printf("Please enter your information: \n");

    printf(" NAME: ");
    scanf("%s", sEmployee.name);

    printf(" DATE: ");
    scanf("%f", sEmployee.date);

    printf(" SALARY: ");
    scanf("%f", &sEmployee.salary);

    printf("\n  NAME: %s    HIRED: %s   INCOME: %.2f\n", sEmployee.name, sEmployee.date, sEmployee.salary);

    return 0;
}