#include <iostream>
#include <fstream>

int main()
{
	std::ifstream fin("file.txt", std::ifstream::in);
	char words[50];
	int numberOfWords = 0;

	while (fin.good())
	{
		fin >> words;
		numberOfWords++;
	}

	std::cout << "Words: " << numberOfWords << std::endl;
	fin.close();

	return 0;
}