#include <iostream>
#include <vector>

int main()
{
	// same as std::vector<int> vNumber; vNumber.assign(10, 0);
	std::vector<int> vNumber(10, 0);

	for (int i = 0; i < vNumber.size(); i++)
	{
		//same as cout << "Element " << i << ": " << vNumber[i] << endl;
		std::cout << "Element " << i << ": " << vNumber.at(i) << std::endl;
	}

	return 0;
}