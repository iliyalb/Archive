#include <cstdlib>
#include <string>
#include <iostream>
#include <iomanip>
#include <iterator>
#include <utility>
#include <tuple>
#include <map>

typedef std::pair<std::string, int> pair;

int main(int argc, char **argv)
{
    int i, x1, x2, x3, year, firstDayInCurrentMonth, numDays, day, currentMonth = 1;
    std::string monthName;
    std::cout << "What year do you want a calendar for? ";
    std::cin >> year;

    // Calculate first day of the year
    x1 = (year - 1) / 4;
    x2 = (year - 1) / 100;
    x3 = (year - 1) / 400;

    // Start of the year
    firstDayInCurrentMonth = (year + x1 - x2 + x3) % 7;

    // Define months
    std::map<int, pair> months =
        {
            {1, std::make_pair("January", 31)},
            {2, std::make_pair("February", 28)},
            {3, std::make_pair("March", 31)},
            {4, std::make_pair("April", 30)},
            {5, std::make_pair("May", 31)},
            {6, std::make_pair("June", 30)},
            {7, std::make_pair("July", 31)},
            {8, std::make_pair("August", 31)},
            {9, std::make_pair("September", 30)},
            {10, std::make_pair("October", 31)},
            {11, std::make_pair("November", 30)},
            {12, std::make_pair("December", 31)},
        };

    // Loop over all months
    while (currentMonth <= 12)
    {
        auto itr = months.find(currentMonth);
        std::tie(monthName, numDays) = itr->second;

        std::cout << "\n S  M  T  W  T  F  S"
                  << "\n"
                  << "____________________" << std::endl;
        day = 1;
        i = firstDayInCurrentMonth;
        while (i > 0)
        {
            std::cout << "   ";
            i--;
        }

        while (day <= numDays)
        {
            std::cout << std::setw(2) << day << " ";

            // 5 weeks in a month resets firstDay to 0
            if (firstDayInCurrentMonth >= 6)
            {
                std::cout << std::endl;
                firstDayInCurrentMonth = 0;
            }
            else
            {
                firstDayInCurrentMonth++;
            }
            day++;
        }
        std::cout << "\n\n"
                  << std::endl;
        currentMonth++;
    }

    return 0;
}