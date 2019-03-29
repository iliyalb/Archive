//Libraries
#include <conio.h>
#include <ctime>
#include <iostream>
#include <Windows.h>

//Map
const int width = 20;
const int height = 20;

//Fields
bool gameOver;
int x, y, fruitX, fruitY, score, tail = 0, tailX[100], tailY[100];

//Custom data type
enum eDirection
{
	STOP = 0,
	LEFT,
	RIGHT,
	UP,
	DOWN
};

eDirection direction;

//Functions
void Setup()
{
	gameOver = false;
	direction = STOP;
	score = 0;

	x = width / 2;
	y = height / 2;
}

void Fruit()
{
	srand(time(NULL));
	fruitX = rand() % width;
	fruitY = rand() % height;
}

void Draw()
{
	system("cls");

	for (int i = 0; i < width + 2; i++)
		std::cout << "#";
	std::cout << std::endl;

	for (int i = 0; i < height; i++)
	{
		for (int j = 0; j < width; j++)
		{
			if (j == 0)
				std::cout << "#";

			if (i == y && j == x)
				std::cout << "O";
			else if (i == fruitY && j == fruitX)
				std::cout << "$";
			else
			{
				bool printed = false;

				for (int k = 0; k < tail; k++)
				{
					if (tailX[k] == j && tailY[k] == i)
					{
						std::cout << "o";
						printed = true;
					}
				}

				if (!printed)
				{
					std::cout << " ";
				}

			}

			if (j == width - 1)
				std::cout << "#";
		}
		std::cout << std::endl;
	}

	for (int i = 0; i < width + 2; i++)
		std::cout << "#";
	std::cout << std::endl;

	std::cout << "\nScore: " << score << std::endl;
}

void Input()
{
	if (_kbhit())
	{
		switch (_getch())
		{
		case 'w':
			direction = UP;
			break;
		case 'a':
			direction = LEFT;
			break;
		case 's':
			direction = DOWN;
			break;
		case 'd':
			direction = RIGHT;
			break;
		case 'x':
			gameOver = true;
			break;
		}
	}
}

void Logic()
{
	int prevX2, prevY2, prevX = tailX[0], prevY = tailY[0];

	tailX[0] = x;
	tailY[0] = y;

	for (int i = 1; i < tail; i++)
	{
		prevX2 = tailX[i];
		prevY2 = tailY[i];

		tailX[i] = prevX;
		tailY[i] = prevY;

		prevX = prevX2;
		prevY = prevY2;
	}

	switch (direction)
	{
	case LEFT:
		x--;
		break;
	case RIGHT:
		x++;
		break;
	case UP:
		y--;
		break;
	case DOWN:
		y++;
		break;
	default:
		break;
	}

	//HARD:
	/* if (x > width || x < 0 || y > height || y < 0)
	{
		std::cout << "YOU DIED!" << std::endl;
		gameOver = true;
	} */

	//EASY:
	if (x >= width)
		x = 0;
	else if (x < 0)
		x = width - 1;

	if (y >= height)
		y = 0;
	else if (y < 0)
		y = height - 1;

	for (int i = 0; i < tail; i++)
	{
		if (tailX[i] == x && tailY[i] == y)
			gameOver = true;
	}

	if (x == fruitX && y == fruitY)
	{
		score += 1;
		tail++;
		Fruit();
	}
}

//Entry
int main()
{
	Setup();

	while (!gameOver)
	{
		Draw();
		Input();
		Logic();
		Sleep(60);
	}

	system("pause");
	return 0;
}