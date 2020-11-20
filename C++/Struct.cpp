#include <iostream>
#include <cstring>

struct character
{
	int age;
	char gender;
	char desc[15];
	char *name;
	std::string email = "example@mail.net";
};

int main()
{
	auto desc = "something";
	character foo;

	foo.age = 20;
	foo.gender = 'm';
	std::strcpy(foo.desc, desc);
	foo.name = new char[80];

	std::cout << "Enter a new name: ";
	std::cin >> foo.name;
	std::cout << "Name: " << foo.name << " , Age: " << foo.age << " , Description: " << foo.desc << ", Email: " << foo.email << std::endl;

	delete foo.name;

	// Another example
	character *player;
	player = new character;

	player->age = 18;
	player->gender = 'f';

	//std::cout << "Player's age: " << player->age << std::endl;

	delete player;

	return 0;
}