#include <iostream>

int main(int argc, char **argv)
{
    int previous = 0, current = 1, next = 0, limit = 50;

    std::cout << previous << "  " << current << "  ";

    while (next <= limit)
    {
        next = previous + current;
        if (next >= limit)
            break;
        std::cout << next << "  ";
        previous = current;
        current = next;
    }

    return 0;
}