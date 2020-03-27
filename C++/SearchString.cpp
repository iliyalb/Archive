#include<iostream> 
#include<string>

int main()
{
	std::string line;
	char search;

	std::cout << "Enter a sentence: ";
	std::getline(std::cin,line);

	std::cout << std::endl << "Enter a character to search: ";
	std::cin >> search;

	int result = count(line.begin(), line.end(), search);
	std::cout << std::endl << "Total length: " << line.size();
	std::cout << std::endl << "Found match: " << result;

	return 0;
}