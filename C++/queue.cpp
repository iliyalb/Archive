#include <iostream>
#include <string>
#include <queue>

int main()
{
	std::queue<std::string> queueNames;

	queueNames.push("Alice");
	queueNames.push("John");
	queueNames.push("Yu");

	std::cout << "There are currently " << queueNames.size() << " people in the queue. ";
	std::cout << "The first person standing in the front is " << queueNames.front() << std::endl;

	queueNames.pop(); //Deletes Alice

	std::cout << "Sorry, I meant the first person standing in the front is " << queueNames.front() << "!" << std::endl;
	std::cout << "And all the way back is " << queueNames.back() << std::endl;

	return 0;
}