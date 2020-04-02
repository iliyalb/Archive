#include <iostream>
#include <string>
#include <stack>

int main()
{
	std::stack <std::string> stackNames;

	stackNames.push("Alice");
	stackNames.push("John");

	std::cout << "There are " << stackNames.size() << " names in the stack. ";
	std::cout << "The name on top is " << stackNames.top() << std::endl;

	stackNames.pop(); // Deletes John

	std::cout << "Sorry, it seems the name on top is " << stackNames.top() << '!' << std::endl;

	return 0;
}