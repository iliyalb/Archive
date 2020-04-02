#include <fstream>

class SomeClass
{
private:
	char str[16] = "SOME CLASS DATA";
public:
	size_t getSize()
	{
		return strlen(str);
	}
};

int main()
{
	SomeClass oSomeClass;

	std::ofstream fout;

	fout.open("file.txt", std::ios::in | std::ios::binary);
	fout.write((char *)&oSomeClass, oSomeClass.getSize());
	fout.close();
	
	return 0;
}