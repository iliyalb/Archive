#include <iostream>
#include <fstream>

int main()
{
	std::ifstream fin("file.txt",std::ifstream::in); 
	//fin.open("file.txt");

	char ch = fin.get();
	
	while (!fin.eof())
	{
		std::cout << ch;
		fin.get(ch);
	}

	fin.close();

	return 0;
}