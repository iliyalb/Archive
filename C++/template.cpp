#include <cstdlib>
#include <iostream>
#include <string>

template <class T>
T Addition(T a, T b)
{
    return a + b;
}

template <class returnType, class argumentType>
returnType cast(argumentType T)
{
    return (returnType)T;
}

template <typename T>
void showOutput(T info)
{
    if (typeid(info) == typeid(const char*))
    {
        std::cout << "REFRAIN FROM USING CHARACTERS!" << std::endl;
    }
    else
    {
        std::cout << info << std::endl;
    }
}

template <class T>
T GetMaximum(T x,T y)
{
    T result = (x>y) ? x : y;
    return result;
}

// Another way to implement
template <class T>
class ValueComparison 
{
    T x,y;
    //ctor
    public:
    ValueComparison(T x,T y)
    {
        this->x = x;
        this->y = y;
    }
    // Implement in child classes
    T GetMaximumTheOtherWay(T x, T y);
};

// Implementing
template <class T>
T ValueComparison<T>::GetMaximumTheOtherWay(T x, T y)
{
    T result = (x>y) ? x:y;
    return result;
}

int main(int argc, char **argv)
{
    int x = Addition(1, 2);
    double y = Addition<double>(5.5, 4.5);
    ValueComparison <int> oValueComparison(646,464);

    std::cout << x << " , " << y << std::endl;
    std::cout << cast<int>(10.85) << std::endl;
    showOutput("Example");
    showOutput(1313);
    std::cout << GetMaximum(10,50) << std::endl;
    std::cout << oValueComparison.GetMaximumTheOtherWay(30,60) << std::endl;

    return 0;
}