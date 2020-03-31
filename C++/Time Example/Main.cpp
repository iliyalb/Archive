#include "Time.h"

int main()
{
	Time t1(12,50,59);

	t1.print();

	t1.setMinute(59);

	t1.nextSecond();

	t1.print();

	return 0;
}