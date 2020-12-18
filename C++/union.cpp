#include <iostream>

// Provides shared memory location structure
typedef union type
{
    int i;
    bool baz;
    char c;
} foo;

int main(int argc, char **argv)
{
    foo bar;
    bar.baz = true;
    std::cout << std::boolalpha << bar.baz << std::endl;
    return 0;
}