#include <iostream>
#include <vector>

int main()
{
	int temp;
	std::vector<int> vector1;

	do
	{
		std::cout << "Fill the vector with numbers (-1 to cancel): ";
		std::cin >> temp;
		vector1.push_back(temp);

	} while (temp >= 0);

	//Exclude last stack (because negative):
	vector1.pop_back(); 

	for (int i = 0; i < vector1.size(); i++)
	{
		//std::cout << vector1.at(i) << std::endl;
		std::cout << vector1[i] << std::endl;
	}

	vector1.clear();

	system("pause");
	return 0;
}