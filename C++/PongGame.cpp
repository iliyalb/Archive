#include <conio.h>
#include <iostream>
#include <time.h>

enum eDirection
{
	STOP = 0,
	LEFT = 1,
	UPLEFT = 2,
	DOWNLEFT = 3,
	RIGHT = 4,
	UPRIGHT = 5,
	DOWNRIGHT = 6
};

class Ball
{
private:
	int x, y, originalX, originalY;
	eDirection direction;

public:
	Ball(int posX, int posY)
	{
		originalX = posX;
		originalY = posY;
		x = posX;
		y = posY;
		direction = STOP;
	}

	void Reset()
	{
		x = originalX;
		y = originalY;
		direction = STOP;
	}

	void ChangeDirection(eDirection direction)
	{
		this->direction = direction;
	}

	void RandomDirection()
	{
		direction = (eDirection)((rand() % 6) + 1);
	}

	void Move()
	{
		switch (direction)
		{
		case STOP:
			break;
		case LEFT:
			x--;
			break;
		case UPLEFT:
			x--; y--;
			break;
		case DOWNLEFT:
			x--; y++;
			break;
		case RIGHT:
			x++;
			break;
		case UPRIGHT:
			x++; y--;
			break;
		case DOWNRIGHT:
			x++; y++;
			break;
		default:
			break;
		}
	}

	inline int getX() { return x; }
	inline int getY() { return y; }
	inline eDirection GetDirection() { return direction; }

	friend std::ostream & operator<<(std::ostream & o, Ball b)
	{
		o << "Ball [" << b.x << "," << b.y << "][" << b.direction << "]";
		return o;
	}

};

class Paddle
{
private:
	int x, y, originalX, originalY;

public:
	Paddle()
	{
		x = y = 0;
	}

	Paddle(int posX, int posY) : Paddle()
	{
		originalX = posX;
		originalY = posY;
		x = posX;
		y = posY;
	}

	void Reset()
	{
		x = originalX;
		y = originalY;
	}

	inline int getX() { return x; }
	inline int getY() { return y; }
	inline void moveUp() { y--; }
	inline void moveDown() { y++; }

	friend std::ostream & operator<<(std::ostream & o, Paddle p)
	{
		o << "Ball [" << p.x << "," << p.y << "]";
		return o;
	}
};

class GameManager
{
private:
	int width, height, score1, score2;
	char up1, up2, down1, down2;
	bool quit;
	Ball * ball;
	Paddle * player1;
	Paddle * player2;

public:
	GameManager(int width, int height)
	{
		srand(time(NULL));
		quit = false;
		up1 = 'w'; up2 = 'i';
		down1 = 's'; down2 = 'k';
		score1 = score2 = 0;
		this->width = width;
		this->height = height;
		ball = new Ball(width / 2, height / 2);
		player1 = new Paddle(1, (height / 2) - 3);
		player2 = new Paddle(width - 2, (height / 2) - 3);
	}

	~GameManager()
	{
		delete ball, player1, player2;
	}

	void ScoreUp(Paddle * player)
	{
		if (player == player1)
			score1++;
		else if (player == player2)
			score2++;

		ball->Reset();
		player1->Reset();
		player2->Reset();
	}

	void Draw()
	{
		system("cls");

		for (int i = 0; i < width + 2; i++)
			std::cout << "\xB2";
		std::cout << std::endl;

		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				int ballx = ball->getX();
				int bally = ball->getY();

				int player1x = player1->getX();
				int player2x = player2->getX();

				int player1y = player1->getY();
				int player2y = player2->getY();

				if (j == 0)
					std::cout << "\xB2";

				if (ballx == j && bally == i)
					std::cout << "O";
				else if (player1x == j && player1y == i)
					std::cout << "\xDB";
				else if (player2x == j && player2y == i)
					std::cout << "\xDB";
				else if (player1x == j && player1y + 1 == i)
					std::cout << "\xDB";
				else if (player1x == j && player1y + 2 == i)
					std::cout << "\xDB";
				else if (player1x == j && player1y + 3 == i)
					std::cout << "\xDB";
				else if (player2x == j && player2y + 1 == i)
					std::cout << "\xDB";
				else if (player2x == j && player2y + 2 == i)
					std::cout << "\xDB";
				else if (player2x == j && player2y + 3 == i)
					std::cout << "\xDB";
				else
					std::cout << " ";

				if (j == width - 1)
					std::cout << "\xB2";
			}
			std::cout << std::endl;
		}

		for (int i = 0; i < width + 2; i++)
			std::cout << "\xB2";
		std::cout << std::endl;

		std::cout
			<< "Score 1: " << score1 << std::endl
			<< "Score 2: " << score2 << std::endl;
	}

	void Input()
	{
		ball->Move();

		int ballx = ball->getX();
		int bally = ball->getY();

		int player1x = player1->getX();
		int player2x = player2->getX();

		int player1y = player1->getY();
		int player2y = player2->getY();

		if (_kbhit)
		{
			char current = _getch();

			if (current == up1)
				if (player1y > 0)
					player1->moveUp();

			if (current == up2)
				if (player2y > 0)
					player2->moveUp();

			if (current == down1)
				if (player1y + 4 < height)
					player1->moveDown();

			if (current == down2)
				if (player2y + 4 < height)
					player2->moveDown();

			if (ball->GetDirection() == STOP)
				ball->RandomDirection();

			if (current == 'q' || current == 'x')
				quit = true;
		}
	}

	void Logic()
	{
		int ballx = ball->getX();
		int bally = ball->getY();

		int player1x = player1->getX();
		int player2x = player2->getX();

		int player1y = player1->getY();
		int player2y = player2->getY();

		//LEFT PADDLE
		for (int i = 0; i < 4; i++)
		{
			if (ballx == player1x + 1)
				if (bally == player1y + i)
					ball->ChangeDirection((eDirection)((rand() % 3) + 4));
		}

		//RIGHT PADDLE
		for (int i = 0; i < 4; i++)
		{
			if (ballx == player2x - 1)
				if (bally == player2y + i)
					ball->ChangeDirection((eDirection)((rand() % 3) + 1));
		}

		//BOTTOM WALL
		if (bally == height - 1)
			ball->ChangeDirection(ball->GetDirection() == DOWNRIGHT ? UPRIGHT : UPLEFT);

		//TOP WALL
		if (bally == 0)
			ball->ChangeDirection(ball->GetDirection() == UPRIGHT ? DOWNRIGHT : DOWNLEFT);

		//RIGHT WALL
		if (ballx == width - 1)
			ScoreUp(player1);

		//LEFT WALL
		if (ballx == 0)
			ScoreUp(player2);
	}

	void Run()
	{
		while (!quit)
		{
			Draw();
			Input();
			Logic();
		}
	}
};

int main()
{
	GameManager game(40, 20);
	game.Run();
	return 0;
}