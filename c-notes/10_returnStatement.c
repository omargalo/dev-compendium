#include <stdio.h>
#include <stdlib.h>

// We define a function before the main function because the main function is the entry point of the program.
double cube(double num)
{
    // return statement is used to exit a function and return a value to the caller

    /*
    double result = num * num * num;
    return result;
    */

   // This is the same as the above code
   return num * num * num;

}

int main()
{
    printf("Answer is: %f\n", cube(3.0));

    return 0;
}