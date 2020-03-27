/* Write a program to implement the number guessing game.
*	Computer must choose a random number between 1 to 100
*	User has to try guessing the number in as few attempts as possible
*	Computer has to evaluate each guess and indicate that the input is:
*		-Too high
*		-Too low
*		-Right
*/

#include <iostream> 
#include <stdlib.h>
#include <time.h>

int main()
{
	int number, guess, tries=0;
	srand(time(0));
	number = rand() % 100 + 1;



	do {
		std::cout << "\nEnter a number (1-100): "; std::cin >> guess;
		tries++;

		if (guess > number)
		{
			std::cout << "Try lower" << std::endl;
		}
		else if (guess < number)
		{
			std::cout << "Try higher" << std::endl;
		}
		else if (guess == number)
		{
			std::cout << "Bingo! Number of tries: " << tries << std::endl;
		}
	} while (guess != number);

	main();

	return 0;
}