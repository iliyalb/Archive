#include <stdio.h>
#include <stdlib.h>

#define PAYRATE 12.00
#define TAXRATE_300 .15
#define TAXRATE_150 .20
#define TAXRATE_REST .25
#define OVERTIME 40

int main(int argc, char *argv[])
{
    int hours;
    double grossPay, taxes, netPay;

    printf("Enter hours of work for this week: ");
    scanf("%d", &hours);

    if (hours <= 40)
    {
        grossPay = hours * PAYRATE;
    }
    else
    {
        grossPay = 40 * PAYRATE;
        grossPay += (hours - 40) * (PAYRATE * 1.5);
    }

    if (grossPay <= 300)
    {
        taxes = grossPay * TAXRATE_300;
    }
    else if (grossPay > 300 && grossPay <= 450)
    {
        taxes = 300 * TAXRATE_300;
        taxes += (grossPay - 300) * TAXRATE_150;
    }
    else if (grossPay > 450)
    {
        taxes = 300 * TAXRATE_300;
        taxes += 150 * TAXRATE_150;
        taxes += (grossPay - 450) * TAXRATE_REST;
    }

    netPay = grossPay - taxes;

    printf("Gross: %.2f \t Tax: %.2f \t Net: %.2f", grossPay, taxes, netPay);

    return 0;
}