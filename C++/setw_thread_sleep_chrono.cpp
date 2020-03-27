#include <iostream> // std::cout, std::endl
#include <iomanip>  // std::setw
#include <thread>   // std::this_thread::sleep_for
#include <chrono>   // std::chrono::seconds

int i = 0;

int main()
{
	i++;
	std::cout << "A" << std::setw(i) << "B" << std::endl;
	
	if (i <= 50)
	{
		std::this_thread::sleep_for(std::chrono::milliseconds(100));
		main();
	}

	return 0;
}