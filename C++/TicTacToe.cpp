#include  <iostream>

//Define variables
char matrix[3][3];
char player = 'X';
int counter;

///Draw the field
void Draw()
{
	system("cls");
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			std::cout << matrix[i][j] << " ";
		}
		std::cout << std::endl;
	}
}

///Get input
void Input()
{
	int input;
	std::cout << player << "'s turn, "<< "Choose a number (1-9): ";
	std::cin >> input;

	switch (input)
	{
	case 1:
		if (matrix[0][0] == '#')
			matrix[0][0] = player;
		else
			Input();
		break;
	case 2:
		if (matrix[0][1] == '#')
			matrix[0][1] = player;
		else
			Input();
		break;
	case 3:
		if (matrix[0][2] == '#')
			matrix[0][2] = player;
		else
			Input();
		break;
	case 4:
		if (matrix[1][0] == '#')
			matrix[1][0] = player;
		else
			Input();
		break;
	case 5:
		if (matrix[1][1] == '#')
			matrix[1][1] = player;
		else
			Input();
		break;
	case 6:
		if (matrix[1][2] == '#')
			matrix[1][2] = player;
		else
			Input();
		break;
	case 7:
		if (matrix[2][0] == '#')
			matrix[2][0] = player;
		else
			Input();
		break;
	case 8:
		if (matrix[2][1] == '#')
			matrix[2][1] = player;
		else
			Input();
		break;
	case 9:
		if (matrix[2][2] == '#')
			matrix[2][2] = player;
		else
			Input();
		break;
	default:
		break;
	}
}

///Toggle between players (X,O)
void Toggle()
{
	if (player == 'X')
		player = 'O';
	else
		player = 'X';
}

///Game over conditions
char Win()
{
	//Player 1
	if (matrix[0][0] == 'X' && matrix[0][1] == 'X' && matrix[0][2] == 'X')
		return 'X';
	if (matrix[1][0] == 'X' && matrix[1][1] == 'X' && matrix[1][2] == 'X')
		return 'X';
	if (matrix[2][0] == 'X' && matrix[2][1] == 'X' && matrix[2][2] == 'X')
		return 'X';

	if (matrix[0][0] == 'X' && matrix[1][0] == 'X' && matrix[2][0] == 'X')
		return 'X';
	if (matrix[0][1] == 'X' && matrix[1][1] == 'X' && matrix[2][1] == 'X')
		return 'X';
	if (matrix[0][2] == 'X' && matrix[1][2] == 'X' && matrix[2][2] == 'X')
		return 'X';

	if (matrix[0][0] == 'X' && matrix[1][1] == 'X' && matrix[2][2] == 'X')
		return 'X';
	if (matrix[2][0] == 'X' && matrix[1][1] == 'X' && matrix[0][2] == 'X')
		return 'X';

	//Player 2
	if (matrix[0][0] == 'O' && matrix[0][1] == 'O' && matrix[0][2] == 'O')
		return 'O';
	if (matrix[1][0] == 'O' && matrix[1][1] == 'O' && matrix[1][2] == 'O')
		return 'O';
	if (matrix[2][0] == 'O' && matrix[2][1] == 'O' && matrix[2][2] == 'O')
		return 'O';

	if (matrix[0][0] == 'O' && matrix[1][0] == 'O' && matrix[2][0] == 'O')
		return 'O';
	if (matrix[0][1] == 'O' && matrix[1][1] == 'O' && matrix[2][1] == 'O')
		return 'O';
	if (matrix[0][2] == 'O' && matrix[1][2] == 'O' && matrix[2][2] == 'O')
		return 'O';

	if (matrix[0][0] == 'O' && matrix[1][1] == 'O' && matrix[2][2] == 'O')
		return 'O';
	if (matrix[2][0] == 'O' && matrix[1][1] == 'O' && matrix[0][2] == 'O')
		return 'O';

	return '/';
}

int main()
{
	//Entry
	std::cout << "Tic Tac Toe" << std::endl;

	counter = 0;

	//Initialize matrix
	for (int i = 0; i < 3; i++)
		for (int j = 0; j < 3; j++)
			matrix[i][j] = '#';

	//Update
	while (true)
	{
		counter++;

		Input();
		Draw();

		if (Win() == 'X')
		{
			std::cout << "X wins!" << std::endl;
			break;
		}
		else if (Win() == 'O')
		{
			std::cout << "O wins!" << std::endl;
			break;
		}
		else if (Win() == '/' && counter >= 9)
		{
			std::cout << "Draw!" << std::endl;
			break;
		}

		Toggle();
	}

	//Exit
	system("pause");
	return 0;
}