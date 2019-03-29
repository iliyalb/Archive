#include <conio.h>
#include <time.h>
#include <iostream>
#include <deque>
#include <vector>

class Player
{
public:
	int x, y;
	Player(int width)
	{
		x = width / 2; y = 0;
	}
};

class Lane
{
private:
	std::deque<bool> cars;
	bool right;

public:
	Lane(int width)
	{
		for (int i = 0; i < width; i++)
			cars.push_front(true);
		right = rand() % 2;
	}

	void Move()
	{
		if (right)
		{
			if (rand() % 10 == 1)
				cars.push_front(true);
			else
				cars.push_front(false);
			cars.pop_back();
		}
		else
		{
			if (rand() % 10 == 1)
				cars.push_back(true);
			else
				cars.push_back(false);
			cars.pop_front();
		}

	}

	bool CheckPos(int pos)
	{
		return cars[pos];
	}

	void ChangeDirection()
	{
		right = !right;
	}
};

class Game
{
private:
	bool quit;
	int numberOfLanes, width, score;
	Player * player;
	std::vector<Lane*> map;

public:
	Game(int width = 20, int height = 10)
	{
		numberOfLanes = height;
		this->width = width;
		quit = false;

		for (int i = 0; i < numberOfLanes; i++)
			map.push_back(new Lane(this->width));
		player = new Player(this->width);
	}

	~Game()
	{
		delete player;

		for (int i = 0; i < map.size(); i++)
		{
			Lane * current = map.back();
			map.pop_back();
			delete current;
		}
	}

	void Draw()
	{
		system("cls");

		for (int i = 0; i < numberOfLanes; i++)
		{
			for (int j = 0; j < width; j++)
			{
				if (i == 0 && j == 0)
					std::cout << "\xDA";
				if (i == 0 &&  j == width - 1)
					std::cout << "\xBF";


				if (i == numberOfLanes - 1 && j == 0)
					std::cout << "\xC0";
				if (i == numberOfLanes - 1 && j == width - 1)
					std::cout << "\xD9";

				if (map[i]->CheckPos(j) && i != 0 && i != numberOfLanes - 1)
					std::cout << "#";
				else if (player->x == j && player->y == i)
					std::cout << "V";
				else
					std::cout << " ";
			}
			std::cout << std::endl;
		}
		std::cout << "\nScore: " << score << std::endl;
	}

	void Input()
	{
		if (_kbhit())
		{
			char current = _getch();

			if (current == 'a')
				player->x--;

			if (current == 'd')
				player->x++;

			if (current == 'w')
				player->y--;

			if (current == 's')
				player->y++;

			if (current == 'q' || current == 'x')
				quit = true;
		}
	}

	void Logic()
	{
		for (int i = 1; i < numberOfLanes - 1; i++)
		{
			if (rand() % 10 == 1)
				map[i]->Move();

			if (map[i]->CheckPos(player->x) && player->y == i)
				quit = true;
		}

		if (player->y == numberOfLanes - 1)
		{
			score++;
			player->y = 0;
			std::cout << "\x07";
			map[rand() % numberOfLanes]->ChangeDirection();
		}
	}

	void Run()
	{
		while (!quit)
		{
			Input();
			Draw();
			Logic();
		}
	}
};

int main()
{
	srand(time(NULL));
	Game game(30, 7);
	game.Run();

	std::cout << "YOU DIED!" << std::endl;

	getchar();
	return 0;
}