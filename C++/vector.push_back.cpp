#include <iostream>
#include <vector>

int main(int argc, char** argv)
{
	std::vector<int> vNums(2);
	vNums[0] = 1;
	vNums[1] = 1;
	vNums.push_back(3);
	std::cout << "Vector Size: " << vNums.size() << std::endl;

	return 0;
}