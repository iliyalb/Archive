#include <stdio.h>
#include <stdlib.h>

struct item
{
    char *itemName;
    int qty;
    float price;
    float amount;
};

void readItem(struct item *);
void printItem(struct item *);

int main(int argc, char *argv[])
{
    struct item sItem;
    struct item *pItem;

    pItem = &sItem;
    pItem->itemName = (char *)malloc(30 * sizeof(char));

    if (pItem == NULL)
        exit(-1);

    readItem(pItem);

    printItem(pItem);

    free(pItem->itemName);

    return 0;
}

void readItem(struct item *i)
{
    printf("Enter product name: ");
    scanf("%s", i->itemName);

    printf("Enter price: ");
    scanf("%f", &i->price);

    printf("Enter quantity: ");
    scanf("%d", &i->qty);

    i->amount = (float)i->qty * i->price;
}

void printItem(struct item *i)
{
    printf("\nName: %s   Price: %.2f   Quantity: %d   Amount: %2.f", i->itemName, i->price, i->qty, i->amount);
}