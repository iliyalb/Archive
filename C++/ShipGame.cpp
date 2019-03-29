#include <iostream>
#include <ctime>

using namespace std;

const int ROWS = 3;
const int COLUMNS = 3;

int matrix[ROWS][COLUMNS];
int maxships = 3;

void Clear()
{
	for (int i = 0; i < ROWS; i++)
	{
		for (int j = 0; j < COLUMNS; j++)
		{
			matrix[i][j] = 0;
		}
	}
}

void Show()
{
	for (int i = 0; i < ROWS; i++)
	{
		for (int j = 0; j < COLUMNS; j++)
		{
			cout << matrix[i][j] << " ";
		}
		cout << "\n";
	}
}

void SetShips()
{
	int s = 0;

	srand(time(NULL));

	while (s < maxships)
	{
		int x = rand() % ROWS;
		int y = rand() % COLUMNS;

		if (matrix[x][y] != 1)
		{
			s++;
			matrix[x][y] = 1;
		}
	}
}

int NumberOfShips()
{
	int c = 0;
	for (int i = 0; i < ROWS; i++)
	{
		for (int j = 0; j < COLUMNS; j++)
		{
			if (matrix[i][j] == 1)
			{
				c++;
			}
		}
	}
	return c;
}

bool Attack(int x, int y)
{
	if (matrix[x][y] == 1)
	{
		matrix[x][y] = 2;
		return true;
	}
	return false;
}

int main()
{
	int X, Y;

	Clear();
	SetShips();

	cout << "Ship Battle Game in C++:\n";

	while (true)
	{
		cout << "Enter attack coordinates (X) (Y): ";
		cin >> X >> Y;

		if (X < 0 || Y < 0)
		{
			break;
		}

		if (Attack(X, Y))
		{
			cout << "HIT!\n";
		}
		else
		{
			cout << "MISS\n";
		}

		cout << "Ships left: " << NumberOfShips() << "\n";

		if (NumberOfShips() <= 0)
		{
			cout << "VICTORY!";
			break;
		}
	}

	cout << "\nMAP:\n";
	Show();
	return 0;
}