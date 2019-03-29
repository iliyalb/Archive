#include <iostream>

/*
Use references in complicated and big projects,
always try to use references instead of pointers
and only use pointers when it's extremely necessary
*/

//Pointer
void increase(int * p)
{
	//Access to address of the value
	(*p)++;
}

//Reference
void increase(int & p)
{
	//Direct access to the value, not copied
	p++;
}

int main()
{
	/*
	Avoid pointers as much as you can.
	Pointers are very useful but are unsafe
	and it's hard to keep track of them.
	References are similar but less risky.
	*/

	int a = 10, b = 10;
	std::cout << "a = " << a << ", b = " << b << "\n" << std::endl;

	//With a pointer:
	increase(&a);
	std::cout << "Pointer: a = " << a << std::endl;

	//With a reference:
	increase(b);
	std::cout << "Reference: b = " << b << std::endl;

	getchar();
	return 0;
}