#include <iostream>

using namespace std;

int main()
{
	int matrix[10][10];

	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			matrix[i][j] = 0;
			cout << matrix[i][j] << " ";
		}
		cout << "\n";
	}

	return 0;
}