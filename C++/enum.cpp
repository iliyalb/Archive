#include <iostream>

enum Week
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
};

int main(int argc, char **argv)
{
    Week day = Wednesday;
    std::cout << day << std::endl;
    return 0;
}