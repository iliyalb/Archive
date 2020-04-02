#include <string>
#include <bitset>
#include <iostream>

using namespace std;

int main()
{
    const int stringLength = 100;
    string myString = "Hello World";
    bitset<8> bitsetArray[stringLength];

    cout << "Text to binary: ";

    for (std::size_t i = 0; i < myString.size(); ++i)
    {

        bitsetArray[i] = bitset<8>(myString.c_str()[i]);


        cout << bitsetArray[i];

    }

    string c;

    cout << "\nBinary to text: ";

    for (std::size_t i = 0; i < myString.size(); ++i)
    {
        c += char(bitsetArray[i].to_ulong());
    }

    cout << c;
}