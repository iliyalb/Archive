#include <iostream>
#include <vector>

int main()
{
	struct sSomeBaseObject
	{
		// virtual indicates children can have their own implementation
		virtual const char* Identify()
		{
			return "BaseObject";
		}
	};

	struct sSomeSubObjectA : public sSomeBaseObject
	{
		const char* Identify()
		{
			return "SubObject A";
		}
	};

	struct sSomeSubObjectB : public sSomeBaseObject
	{
		const char* Identify()
		{
			return "SubObject B";
		}
	};

	// Create a vector of objects
	std::vector<sSomeBaseObject*> vVector;

	// Initializing vector
	vVector.push_back(new sSomeBaseObject());
	vVector.push_back(new sSomeSubObjectA());
	vVector.push_back(new sSomeSubObjectB());
	vVector.push_back(new sSomeSubObjectA());
	vVector.push_back(new sSomeSubObjectA());

	for (auto& a : vVector)
		std::cout << a->Identify() << std::endl;

	// Freeing up container
	for (auto& a : vVector)
		delete a;

	// Cleaning vector
	vVector.clear();

	return 0;
}