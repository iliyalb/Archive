#include <iostream>
#include <cmath>
#include <ctime>
#include <string>

using namespace std;

int main()
{
	int num, numrand;
	char yn;
	string name;

	srand(time(NULL));

	cout << "Welcome, your name: "; cin >> name;
	cout << "Hello " << name << " do you want to play a game (y/n): ";
	cin >> yn;

	if (yn == 'n' || yn == 'N')
	{
		return 0;
	}
	else if (yn == 'y' || yn == 'Y')
	{
		while (true)
		{
			cout << "\nGuess the number! (0 to 5): ";
			cin >> num;

			numrand = rand() % 6;

			if (numrand == num)
				cout << "You win!\n";
			else if (num < 0)
				break;
			else
				cout << "You lose! : " << numrand;

		}
	}
	else
	{
		cout << "no u";
	}

	return 0;
}