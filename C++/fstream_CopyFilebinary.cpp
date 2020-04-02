#include <fstream>

int main()
{
	std::ifstream fin;
	std::ofstream fout;

	fin.open("file.txt", std::ios::in | std::ios::binary);
	fout.open("file-copy.txt", std::ios::out | std::ios::binary);

	fout << fin.rdbuf();

	fin.close();
	fout.close();

	return 0;
}