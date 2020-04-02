#include <iostream>
#include <vector>

int main()
{
	std::vector<int> vNumber;
	std::vector<int> vAnotherNumber;

	for (int i = 0; i < 10; i++)
	{
		vNumber.push_back(i); //pop_back() to remove
	}

	vAnotherNumber.assign(vNumber.begin(), vNumber.end());

	for (int i = 0; i < vAnotherNumber.size(); i++)
	{
		std::cout << vAnotherNumber.at(i) << "\t";
	}

	return 0;
}