#include <stdlib.h>

int main ()
{
    // Constants are values that cannot be changed
    const int FAV_NUM = 7;
    printf("%d\n", FAV_NUM);
    //FAV_NUM = 8; // This will throw an error
    printf("%d\n", FAV_NUM);

    return 0;
}