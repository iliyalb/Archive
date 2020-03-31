#include "Author.h"

int main()
{

	Author john("John Doe", "JohnDoe@mail.com", 'M');

	john.print();

	john.setEmail("JohnDoe@altmail.net");

	john.print();

	return 0;
}