#include <iostream>
#include <iomanip>
#include "Time.h"

Time::Time(int h, int m, int s)
{
	hour = h;
	minute = m;
	second = s;
}

int Time::getHour() const
{
	return hour;
}

void Time::setHour(int h)
{
	hour = h;
}

int Time::getMinute() const
{
	return minute;
}

void Time::setMinute(int m)
{
	minute = m;
}

int Time::getSecond() const
{
	return second;
}

void Time::setSecond(int s)
{
	second = s;
}

void Time::setTime(int h, int m, int s)
{
	hour = h;
	minute = m;
	second = s;
}

void Time::print() const
{
	std::cout << std::setfill('0'); // <iomanip>
	std::cout
		<< std::setw(2) << hour << ":"
		<< std::setw(2) << minute << ":"
		<< std::setw(2) << second << std::endl;
}

void Time::nextSecond()
{
	++second;

	if (second >= 60)
	{
		second = 0;
		++minute;
	}

	if (minute >= 60)
	{
		minute = 0;
		++hour;
	}

	if (hour >= 24)
	{
		hour = 0;
	}
}