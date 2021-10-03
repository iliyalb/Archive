#include <stdio.h>

float Q_rsqrt(float number)
{
    long i;
    float x2, y;
    const float threehalfs = 1.5F;

    x2 = number * 0.5F;
    y = number;
    i = *(long*) &y;
    i = 0x5f3759df - (i >> 1);
    y = *(float*) &i;
    y = y * (threehalfs - (x2*y*y));

    return y;
}

int main() 
{
   printf("%.7f", Q_rsqrt(4.27f));
   return 0;
}

// How Quake III was so optimized: 
// Fast inverse square root algorithm 

// Vectors in 3D space use floats and while working with vectors there are two important scalar aspects for our game engine which are longitude (direction) and magnitude (x,y).
// Developers of the Quake wanted to do 1 divided by square root of a normalized vector (used for projection) but doing it directly was too costly.
// The solution was bit operation (because they're efficient) which floats don't support. So they casted it to long value type which supports what they needed.
// But they didin't actually cast it and instead of passing and converting the number, they passed the address.
// This way the value residing in that address is no longer being treated as a float and engine sees it as a long.

// Shifting numbers to the left doubles it and shifting it to the right halves it.
// Shifting exponent of a number to the left squares the number and shifting it to the right gets us the square root.
// Negating the exponent gives us 1/sqrt which was exactly what Quake needed.
// According to the IEEE 754 standard, bits of a number are it's own logarithm. That means calculating 1/sqrt(y) gives us log(1/sqrt(y)).
// By writing the y as y^(-1/2) we can take out the exponent and get -1/2*log(y) which is far more easier to calculate.
// This equation however has -1 divided by 2 and division is also costly. So instead of dividing, it can be bit shifted to the right.
// The magic number of 0x5f3759df is the remnants of scaling factor and shifting in bit form represantation.
// After this square root calculation, the casting solution is reversed and we have a float again.
// But the number we have is an approximation. That's where Newton Iteration comes in.

// Thanks to the Newton Iteration we can get a really good approximation. Newton's method is a technique that finds a root for a given function.
// It finds an x for which f(x) equals to zero. It takes an approximation and returns a better one.
// This solution can be repeated to get close to the actual solution (0). One iteration was enough for quake.
// The ratio between y and it's offset gets the x and subtracting this offset (x-(f(x)/f'(x))) gets us the new x.
// All this calculation was done without using any division. That's why it's fast.