#include <iostream>

// Formatted string equivalent of C# & Python in C/C++
int main()
{
    // First parameter of snprintf; Must be char
    // P.S: Mind the buffer size
    char buffer[30];

    // snprintf is the successor to sprintf which is deprecated
    // paramteres: (buffer_destination, buffer_length, desired_string, **args)
    snprintf(buffer, 30, "Mahan %d sen dare\n", 12);
    puts(buffer);
}