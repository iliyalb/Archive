#include <iostream>
#include <string>

class Parent
{
private:
	std::string secrets;
	void GetSecrets();

protected:
	std::string creditcards;
	void GetCreditCards();

public:
	std::string information;
	void GetInformation();
	Parent() { secrets = "no one should know this"; creditcards = "some may know this"; information = "anyone can know this"; }

};

void Parent::GetSecrets()
{
	std::cout << "Secrets, " << secrets << std::endl;
}

void Parent::GetCreditCards()
{
	std::cout << "Credit Cards, " << creditcards << std::endl;
}

void Parent::GetInformation()
{
	std::cout << "Information, " << information << std::endl;
}

class Child : public Parent
{
public:
	void SetInformation() { information = "child modified it"; }
};

int main()
{
	Parent p;
	Child c;

	std::cout << "Parent knows:\n";

	p.GetInformation();

	std::cout << "Child knows:\n";

	c.GetInformation();

	//Modification
	c.SetInformation();
	std::cout << std::endl;

	std::cout << "Now, Parent knows:\n";

	p.GetInformation();

	std::cout << "Now, Child knows:\n";

	c.GetInformation();

	system("pause");
	return 0;
}