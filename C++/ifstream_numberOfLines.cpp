#include <iostream>
#include <fstream>

int main()
{
	std::ifstream fin("file.txt", std::ifstream::in);
	char lines[50];
	int numberOfLines = 0;

	while (!fin.eof())
	{
		fin.getline(lines, 50);
		numberOfLines++;
	}

	std::cout << "Lines: " << numberOfLines << std::endl;
	fin.close();

	return 0;
}