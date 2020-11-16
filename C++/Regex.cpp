#include <iostream>
#include <regex>

using namespace std;

int main(int argc, char **argv)
{
    string source = "Lorem ipsum";
    regex pattern("(ipsum)[^ ]?");
    smatch doesMatch;

    if (regex_search(source, doesMatch, pattern) == true)
    {
        cout << "Found " << doesMatch.size() << " case(s)" << endl;

        while (regex_search(source, doesMatch, pattern))
        {
            cout << doesMatch.str(1) << endl;
            cout << "At index " << doesMatch.position(1) << endl;
            source = doesMatch.suffix().str();
        }
    }
}