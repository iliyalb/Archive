#include <iostream>

struct character
{
	int age;
	char gender;
	char* name;
};

int main()
{
	character foo;

	foo.age = 20;
	foo.gender = 'm';
	foo.name = new char[80];

	std::cout << "Enter a new name: ";
	std::cin >> foo.name;
	std::cout << "Name: " << foo.name << " , Age: " << foo.age << std::endl;

	delete foo.name;

	// Another example
	character* player;
	player = new character;

	player->age = 18;
	player->gender = 'f';

	//std::cout << "Player's age: " << player->age << std::endl;

	delete player;

	return 0;
}