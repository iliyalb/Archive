#include<iostream> 

int main()
{
	int total, price, quantity, discount;

	std::cout << "Enter quantity: "; std::cin >> quantity;
	std::cout << "\nEnter price: "; std::cin >> price;

	total = price * quantity;

	if (total > 3000)
	{
		discount = (total * 0.25); //25% discount
		total = total - discount; //Applying discount
		std::cout << "\nTotal: " << total;
	}
	else
	{
		std::cout << "\nTotal: " << total;
	}

	return 0;
}