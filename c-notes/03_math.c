#include <stdlib.h>
#include <stdio.h>

int main()
{
    // %f will return 7.700000
    printf("%f", 7.7);
    // %f will return 6.600000
    printf("%f", 3.3 + 3.3);
    // %f will return 12.500000
    printf("%f", 9 + 3.5);
    // %d will return 1, because 5/4 = 1.25, but it will an integer
    printf("%d", 5/4);
    // %f will return 1.250000, because 5/4 = 1.25
    printf("%f", 5/4.0);

    // 4^3 = 64
    printf("%f", pow(4, 3));
    // sqrt(25) = 5
    printf("%f", sqrt(25));
    // ceil(36.356) = 37
    printf("%f", ceil(19.356));
    // floor(36.356) = 36
    printf("%f", floor(19.356));

    return 0;
}