#include <iostream>
#include <fstream>

int main()
{
	std::ifstream fin("file.txt", std::ifstream::in);
	char characters = fin.get();
	int numberOfCharacters = 0;

	while (!fin.eof())
	{
		fin.get(characters);
		numberOfCharacters++;
	}

	std::cout << "Characters: " << numberOfCharacters << std::endl;
	fin.close();

	return 0;
}